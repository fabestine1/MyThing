#ifndef REQUEST_PARSER_H
#define REQUEST_PARSER_H

#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#include <stdint.h>

typedef struct
{
	uint16_t	cmd;
	uint16_t	val;
	
} REQUEST_STRUCT;

extern void parseRequest(REQUEST_STRUCT* rstruct, char request_buffer[], size_t buffer_size);
extern void FilterRequestData(REQUEST_STRUCT* request, char request_buffer[], size_t separatorindex, size_t startindex, size_t endindex);

#endif