#include <stdio.h>
#include <stdlib.h>

int main()
{
    float n1, n2, resultado;

    printf("Digite um numero: ");
    scanf("%f%*c", &n1);

    printf("Digite um numero: ");
    scanf("%f%*c", &n2);


    if (n1>n2){
        resultado = n1 + 100;
        printf("O maior numero somado a 100 e: %.2f", resultado);
    }else if (n2>n1){
        resultado = n2 + 100;
        printf("O maior numero somado a 100 e: %.2f", resultado);
    }else{
        printf("Os valores sao iguais");
    }
    return 0;
}
