#include <stdio.h>
#include <stdlib.h>
int ar[10];
int main()
{
    int arr[3][5],sum_col[5]={0};
    for(int i=0;i<3;i++)
    {
        for(int j=0;j<5;j++)
        {
            scanf("%d",&arr[i][j]);
        }
    }
    for(int i=0;i<3;i++)
    {
        for(int j=0;j<5;j++)
        {
            sum_col[j]+=arr[i][j];
        }
    }

    for(int i=0;i<5;i++)
    {
        printf("\nThe %d average col :%d",i+1,sum_col[i]/3);
    }
    return 0;
}
