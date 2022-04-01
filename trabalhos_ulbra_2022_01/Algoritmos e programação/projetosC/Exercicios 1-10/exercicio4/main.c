#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, novosal;

    printf ( " ========== Programa para descobrir seu novo salario com aumento de 25% ==========\n\n " );

    printf("Digite o salario atual: ");
    scanf("%f", &sal);

    novosal = (sal * 25 / 100)+ sal;

    printf("O novo salario eh: %.2f\n", novosal);

    return 0;
}
