#include <stdio.h>
#include <stdlib.h>
int main()
{
    int m1[3][2],m2[2][1],m3[3][1];
    //First Matrix Content
    printf("Enter the First Matrix :\n");
    for(int i=0;i<3;i++)
    {
        printf("The %i Row :",i+1);
        for(int j=0;j<2;j++)
        {
            scanf("%d",&m1[i][j]);
        }
    }
    //second Matrix Content
    printf("\nEnter the Second Matrix :\n");
    for(int i=0;i<2;i++)
    {
        printf("The %i Row :",i+1);
        for(int j=0;j<1;j++)
        {
            scanf("%d",&m2[i][j]);
        }
    }


    for(int i=0;i<3;i++)
    {
        m3[i][0]=0;
        for(int j=0;j<2;j++)
        {
            m3[i][0]+=(m1[i][j]*m2[j][0]);
        }
    }
    //Final Result Matrix
    printf("\nThe Final Result :\n");

    for(int i=0;i<3;i++)
    {
        printf("The %i Row :",i+1);
        printf("%d",m3[i][0]);
        printf("\n");
    }

    return 0;
}
