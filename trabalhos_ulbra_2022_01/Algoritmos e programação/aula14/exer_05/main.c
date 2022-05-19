#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1,n2;

    do{
        printf("Digite um valor inteiro: \n");
        scanf("%d%*c", &n1);

        printf("Digite um valor inteiro: \n");
        scanf("%d%*c", &n2);

    if (n1>n2){
        printf("Ordem crescente\n");
    }else {
        printf("Ordem decrescente\n");
    }
    }while(n1==n2);
    printf("Os valores sao iguais");

    return 0;
}
