#include    <stdio.h>
#include    <stdlib.h>
#include    <stdbool.h>
#include    <time.h>
#include    <malloc.h>
#include    <string.h>

#include    "resource_detector.h"

#undef      malloc
#undef      free
#undef      main
#undef      fopen
#undef      fclose

#define MAGIC_CODE      0x78563412

#define ADDR(addr,offset)               ((addr) + (offset))
#define SET_MAGIC_CODE(addr,offset)     *((int *) ADDR(addr,offset)) = MAGIC_CODE
#define CHECK_MAGIC_CODE(addr,offset)   (*((int *) ADDR(addr,offset)) == MAGIC_CODE)

typedef struct mem_info
{
    char *              addr;
    unsigned int        size;
    char *              file;
    unsigned int        line;
    struct mem_info *   next;
} MEM_INFO;

static MEM_INFO * head = NULL;
static int        file_counter = 0;

static void
invalidate (MEM_INFO * curr)
{
    char * user_addr;
    char * raw_addr;
    unsigned int size;

    user_addr = curr->addr;
    size = curr->size;
    raw_addr = ADDR (user_addr, -sizeof (int));

    if (CHECK_MAGIC_CODE (user_addr, -sizeof(int)) && CHECK_MAGIC_CODE (user_addr, size))
    {
        /* OK */
    }
    else
    {
        fprintf (stderr, "ERROR: addr %p (%s, line %d): out-of-bound access\n", user_addr, curr->file, curr->line);
    }

    memset (raw_addr, 0xff, size + (2 * sizeof(int)));
    free (raw_addr);
    free (curr);
}

/*
 * replacement of malloc
 */
extern void *
xmalloc (unsigned int size, char * file, unsigned int line)
{
    char * raw_addr = malloc (size + (2 * sizeof(int)));
    char * user_addr;
    MEM_INFO * curr = NULL;

    if (raw_addr == NULL)
    {
        fprintf (stderr, "ERROR: malloc failed for %d bytes (%s, line %d)\n", size, file, line);
        return (NULL);
    }
    else
    {
        user_addr = ADDR (raw_addr, sizeof (int));
        SET_MAGIC_CODE (raw_addr, 0);
        SET_MAGIC_CODE (user_addr, size);

        curr = (MEM_INFO *) malloc (sizeof(MEM_INFO));
        curr->addr = user_addr;
        curr->size = size;
        curr->file = file;
        curr->line = line;

        curr->next = head;
        head = curr;
    }
    return ((void *) user_addr);
}

/*
 * replacement of free
 */
extern void
xfree (void * addr, char* filename, int linenr)
{
    char * user_addr = (char *) addr;
    MEM_INFO * curr = head;
    MEM_INFO * prev = NULL;

    if (curr == NULL)
    {
        fprintf (stderr, "ERROR: memory list is empty (addr %p) in %s : %d\n", user_addr, filename, linenr);
        return;
    }
    if (curr->addr == user_addr)
    {
        head = curr->next;
        invalidate (curr);

        return;
    }

    /* check if allocated memory is in our list */
    prev = curr;
    curr = curr->next;
    while (curr != NULL)
    {
        if (curr->addr == user_addr)
        {
            prev->next = curr->next;
            invalidate (curr);
            return;
        }
        prev = curr;
        curr = curr->next;
    }
    fprintf (stderr, "ERROR: addr %p not malloc-ed in %s : %d\n", user_addr, filename, linenr);
}

/*
 * writes all info of the unallocated memory
 */
static void
resource_detection (void)
{
    MEM_INFO * curr;
    time_t now;

    now = time (NULL);
    if (head != NULL)
    {
        fprintf (stderr, "Memory Leak Summary, generated: %s", ctime (&now));
        fprintf (stderr, "%s\n", "-------------------");
        for (curr = head; curr != NULL; curr = curr->next)
        {
            fprintf (stderr, "addr: %p\n", curr->addr);
            fprintf (stderr, "size: %d bytes\n", curr->size);
            fprintf (stderr, "file: %s\n", curr->file);
            fprintf (stderr, "line: %d\n", curr->line);
            fprintf (stderr, "%s\n", "-------------------");
        }
        return;
    }

    if (file_counter != 0)
    {
        fprintf (stderr, "File Management Summary, generated: %s", ctime (&now));
        fprintf (stderr, "-----------------------\n");
        fprintf (stderr, "number of open files: %d\n", file_counter);
        fprintf (stderr, "-----------------------\n");
        return;
    }
    printf ("\nResource checks: OK\n\n");
}

extern FILE *
xfopen (const char * name, const char * mode)
{
    FILE* result = fopen(name, mode);
    if (result != NULL)
    {
        file_counter++;
    }
    return result;
}

extern int
xfclose(FILE * fptr, char* filename, int linenr)
{
    file_counter--;
    if (file_counter < 0)
    {
        fprintf (stderr, "ERROR: trying to close an unopened file in %s : %d.\n", filename, linenr);
        return (-1);
    }
    return (fclose (fptr));
}

extern int
main (int argc, char * argv[])
{
    atexit (resource_detection);

    return (xmain (argc, argv));
}
