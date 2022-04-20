#include <stdio.h>
#include <stdlib.h>

int main()
{
    float num1, num2;

    printf("Digite o primeiro numero: ");
    scanf("%f%*c", &num1);

    printf("Digite o segundo numero: ");
    scanf("%f%*c", &num2);

    if ( num1 > num2 ){
        printf("O maior numero e: %.2f\n", num1);
    }
     if ( num2 > num1 ){
        printf("O maior numero e: %.2f\n", num2);
    }
     if ( num2 == num1 ){
        printf("Os numeros sao iguais");
    }
    return 0;
}
