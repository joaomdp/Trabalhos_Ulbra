#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n,i;
    printf("Digite um numero para descobrir sua tabuada\n");
    scanf("%d%*c", &n);
    for (i=1;i<11;i++){
        printf("%d X %d = %d\n", i, n, (n*i));
    }
    return 0;
}
