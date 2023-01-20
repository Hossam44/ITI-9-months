#include <stdio.h>
#include <stdlib.h>

int main()
{
    int sum=0,n,i=0;
    while(sum<=100){
        i++;
        printf("Enter %i Number:",i);
        scanf("%d",&n);
        sum+=n;
        printf("Sum Now=%d\n",sum);
    }

    return 0;
}
