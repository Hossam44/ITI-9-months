#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[10]={0},min=1e9+7,max=-1e9+7;
    for(int i=0;i<10;i++)
    {
        scanf("%d",&arr[i]);
    }
    for(int i=0;i<10;i++)
    {
        if(arr[i]>max)
            max=arr[i];
        if(arr[i]<min)
            min=arr[i];
    }
    printf("Max Number :%d",max);
    printf("\nMin Number :%d",min);

    return 0;
}
