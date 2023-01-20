#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;
    printf("1-football\n");
    printf("2-tennis\n");
    printf("3-vollybool\n");

    printf("Enter UR choice:");
    scanf("%d",&n);
    switch(n){
    case 1:
        printf("Hello in Fottbool\n");
        break;
    case 2:
        printf("Hello in tennis\n");
        break;
    case 3:
        printf("Hello in vollybool\n");
        break;
    default:
        printf("ERROR\n");
        break;
    }
    return 0;
}
