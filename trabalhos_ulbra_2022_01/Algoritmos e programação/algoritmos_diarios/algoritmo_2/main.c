#include <stdio.h>
#include <stdlib.h>

int main()
{
    int numero;

    printf("Digite um numero inteiro, e descubra se ele e par ou impar: ");
    scanf("%d%*c", &numero);

    if (numero%2==0){
        printf("O numero %d e par", numero);
    }else{
        printf("O numero e impar");
    }
    return 0;
}
