#include <stdio.h>
#include <stdlib.h>

int main()
{
    float n1, n2, resultado;

    printf("Digite um numero: ");
    scanf("%f%*c", &n1);

    printf("Digite outro numero: ");
    scanf("%f%*c", &n2);

    if (n1>n2){
        resultado = n1 - n2;
        printf("A diferenca dos valores e: %.2f", resultado);
    }else if (n2>n1){
        resultado = n2 - n1;
        printf("A diferenca dos valores e: %.2f", resultado);
    }else {
        printf("Os numeros digitados sao iguais");
    }

    return 0;
}
