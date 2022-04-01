#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, salreceber, imp;
    printf ( " ========== Programa para ver o salario base a receber  ==========\n\n " );

    printf("Digite o seu salario atual: ");
    scanf("%f", &sal);

    imp = sal * 10 / 100;

    salreceber = sal + 50 - imp;

    printf("O salario a receber eh: %.2f\n", salreceber);

    return 0;
}
