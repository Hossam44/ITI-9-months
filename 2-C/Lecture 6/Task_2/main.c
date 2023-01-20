#include <stdio.h>
#include <stdlib.h>

void swap(int *x,int *y)
{
    *x+=*y;
    *y=*x-*y;
    *x=*x-*y;
}
int main()
{
    printf("Hello world!\n");
    int x=5,y=2;

    //swap(&x,&y);

    x+=y;
    y=x-y;
    x=x-y;

    printf("X :%d     Y :%d",x,y);
    return 0;
}
