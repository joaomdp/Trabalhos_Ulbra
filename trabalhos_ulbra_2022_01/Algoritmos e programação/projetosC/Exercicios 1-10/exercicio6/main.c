#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, salreceber, grat, imp;

    printf ( " ========== Programa para ver seu salario base a receber ==========\n\n " );

    printf("Digite o salario atual: ");
    scanf("%f", &sal);

    grat = sal * 5 / 100;

    imp = sal * 7 / 100;

    salreceber = sal + grat - imp;

    printf("O salario a receber eh: %.2f\n", salreceber);
    return 0;
}
