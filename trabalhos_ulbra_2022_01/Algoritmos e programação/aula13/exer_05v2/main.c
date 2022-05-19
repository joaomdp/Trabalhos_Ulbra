#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n,i,soma;
    soma=0;
    i=0;
        printf("Digite um numero: \n");
        scanf("%d%*c", &n);

    while(i<=n){
        soma=i+soma;
        i++;
    }
    printf("A soma de 1 ate %d e %d", n, soma);
    return 0;
}
