#include <stdio.h>
#include <stdlib.h>

int main()
{
    int **marks,std_num,sub_n,*sum,*avg;
    printf("Enter Number Of Students :");
    scanf("%d",&std_num);
    sum = (int *)malloc(std_num*sizeof(int));

    marks = (int**)malloc(std_num*sizeof(int));

    printf("Enter Number Of subjects :");
    scanf("%d",&sub_n);
    avg = (int *)malloc(sub_n*sizeof(int));

    for(int i=0;i<std_num;i++)
    {
        marks[i]=(int *)malloc(sub_n*sizeof(int));
    }

    for(int i=0;i<std_num;i++)
        sum[i]=0;

     for(int i=0;i<sub_n;i++)
        avg[i]=0;

    for(int i=0;i<std_num;i++)
    {
        for(int j=0;j<sub_n;j++)
        {
            scanf("%d",&marks[i][j]);
            sum[i]+=marks[i][j];
            avg[j]+=marks[i][j];
        }
    }
    for(int i=0;i<std_num;i++)
    {
        printf("Sum %d :%d\n",i+1,sum[i]);
    }
    for(int i=0;i<sub_n;i++)
    {
        avg[i]/=std_num;
        printf("avg %d :%d\n",i+1,avg[i]);
    }
    return 0;


}
