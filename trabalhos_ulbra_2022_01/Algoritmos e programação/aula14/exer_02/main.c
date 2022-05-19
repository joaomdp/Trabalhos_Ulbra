#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;

    do{
    printf("Digite o valor a ser testado\n");
    scanf("%d%*c", &n);
    if(n>0){
        printf("Valor positivo\n");
    }else if (n<0){
        printf("Valor negativo\n");
    }
    }while(n!=0);
    return 0;
}
