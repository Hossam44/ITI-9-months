#include <stdio.h>
#include <stdlib.h>
int ar[10];
int main()
{
    int arr[3][5],sum_row[3]={0};
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
            sum_row[i]+=arr[i][j];
        }
    }
    for(int i=0;i<3;i++)
    {
        printf("\nThe %d Row_Sum :%d",i+1,sum_row[i]);
    }
    return 0;
}
