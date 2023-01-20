#include <stdio.h>
#include <stdlib.h>

int main()
{
    char Name[30],ch;
    int i=0;
    printf("Enter Your Name :");
    for(i=0;i<30;i++)
    {
        ch=getche();
        if(ch==13)
        {
            Name[i]='\0';
            break;
        }
        Name[i]=ch;
    }
    i=0;
    printf("\nName :");
    while(Name[i]!='\0')
    {
        printf("%c",Name[i++]);
    }
    return 0;
}
