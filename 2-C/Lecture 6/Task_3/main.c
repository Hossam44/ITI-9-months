#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[5],*ptr;
    ptr=arr;
    for(int i=0;i<5;i++)
    {
        scanf("%i",ptr+i);
    }
    for(int i=0;i<5;i++)
    {
        printf("%i ",*(ptr+i));
    }
    return 0;
}
