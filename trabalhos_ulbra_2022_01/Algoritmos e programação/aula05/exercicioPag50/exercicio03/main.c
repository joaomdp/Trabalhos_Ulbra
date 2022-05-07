#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1, num2;
    float div;

    printf("Digite um valor maior que zero: ");
    scanf("%d", &num1);
    printf("Digite outro valor maior que zero: ");
    scanf("%d", &num2);
    div = num1 / num2;
    printf("O resultado da divisao: %.2f\n", div);
    return 0;
}
