#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[10]={0};
    for(int i=0;i<10;i++)
    {
        scanf("%d",&arr[i]);
    }
    for(int i=0;i<10;i++)
    {
        printf("%d ",arr[i]);
    }
    return 0;
}
