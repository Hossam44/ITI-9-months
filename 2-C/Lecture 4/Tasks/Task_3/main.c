#include <stdio.h>
#include <stdlib.h>

int main()
{
    char Name[30],Last_Name[30];
    printf("Enter Your Fist Name :");
    gets(Name);
    printf("Enter Your Last Name :");
    gets(Last_Name);
    strcat(Name," ");
    strcat(Name,Last_Name);
    printf("Full Name :");
    printf("%s",Name);


    return 0;
}
