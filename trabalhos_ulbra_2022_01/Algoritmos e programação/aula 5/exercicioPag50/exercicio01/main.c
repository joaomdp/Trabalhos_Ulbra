#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1, num2, sub;

    printf("Digite um valor maior que zero: ");
    scanf("%d", &num1);
    printf("Digite outro valor maior que zero: ");
    scanf("%d", &num2);

    sub = num1 - num2;

    printf("O resultado da subtracao eh: %d\n", sub);
    return 0;
}
