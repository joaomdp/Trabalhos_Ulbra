#include <stdio.h>
#include <stdlib.h>

int main()
{
    int valor1, valor2;
    printf("Digite um valor: ");
    scanf("%d%*c", &valor1);
    printf("Digite outro valor: ");
    scanf("%d%*c", &valor2);

    if (valor1 < valor2){
        printf("%d e menor que %d", valor1, valor2);
    }else {
        printf("%d e menor que %d", valor2, valor1);
    }
    return 0;
}
