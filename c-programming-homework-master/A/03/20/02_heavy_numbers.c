#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a=0, b, sum=0;
    float avg, n;

    while(a<=1 || a>=9999)scanf("%d", &a);

    for(n=0; a != 0; ){
        b = a % 10;
        a = a / 10;
        sum = sum + b;
        n = n + 1;
    }

    avg = sum / n;

    if(avg > 7)printf("heavy");
    else printf("light");

    return 0;
}
