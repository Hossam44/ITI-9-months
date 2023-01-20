#include <stdio.h>
#include <stdlib.h>
#include <windows.h>


void gotoxy( int column, int line )
{
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
}
int main()
{
    int r=1,c,n;
    do{
        printf("Enter your Size :");
        scanf("%d",&n);
        if(!(n&1))
        {
            printf("-ERROR .... u Shoud Enter odd number -\n");
        }
    }while(!(n&1));
    c=(n/2)+1;

    for(int i=1;i<=n*n;i++)
    {
        int newc=10+(c-1)*3;
        //int newr=5+(r-1)*2;
        gotoxy(newc,r);
        printf("%d",i);
        if(i%n==0)
        {
            r++;
            if(r==n+1)
                r=1;
        }
        else
        {
            r--;
            c--;
            if(r==0)
                r=n;
            if(c==0)
                c=n;
        }
    }
            printf("\n\n");

    return 0;
}
