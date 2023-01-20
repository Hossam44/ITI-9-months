#include <stdio.h>
#include <stdlib.h>
int main()
{
    int n,m,a,d;
    do{
        //First Matrix Size
        printf("Enter the Row Size of The First Matrix :");
        scanf("%d",&m);
        printf("Enter the Col Size of The First Matrix :");
        scanf("%d",&n);


        //second Matrix Size
        printf("Enter the Row Size of The Second Matrix :");
        scanf("%d",&a);
        if(a==n)
        {
            printf("Enter the Col Size of The Second Matrix :");
            scanf("%d",&d);
        }
        else
        {
            printf("****** ERROR ------ u should Enter Right Matrix ******\n");
        }
    }while(a!=n);

    int m1[m][n],m2[a][d],m3[m][d];

    //First Matrix Content
    printf("Enter the First Matrix :\n");
    for(int i=0;i<m;i++)
    {
        printf("The %i Row :",i+1);
        for(int j=0;j<n;j++)
        {
            scanf("%d",&m1[i][j]);
        }
    }

    //second Matrix Content
    printf("\nEnter the Second Matrix :\n");
    for(int i=0;i<a;i++)
    {
        printf("The %i Row :",i+1);
        for(int j=0;j<d;j++)
        {
            scanf("%d",&m2[i][j]);
        }

    }

    for(int i=0;i<m;i++)
    {
        for(int k=0;k<d;k++)
        {
            m3[i][k]=0;

            for(int j=0;j<n;j++)
            {
                m3[i][k]+=(m1[i][j]*m2[j][k]);
            }
        }
    }
    //Final Result Matrix
    printf("\nThe Final Result :\n");
    for(int i=0;i<m;i++)
    {
        printf("The %i Row :",i+1);
        for(int j=0;j<d;j++)
            printf("%d ",m3[i][j]);
        printf("\n");
    }

    return 0;
}
