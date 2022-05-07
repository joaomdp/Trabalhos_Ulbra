#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1, num2, num3, multi;

    printf("Digite um valor maior que zero: ");
    scanf("%d", &num1);
    printf("Digite outro valor maior que zero: ");
    scanf("%d", &num2);
    printf("Digite outro valor maior que zero: ");
    scanf("%d", &num3);

    multi = num1*num2*num3;

    printf("O resultado da multiplicacao: %d\n", multi);

    return 0;
}
