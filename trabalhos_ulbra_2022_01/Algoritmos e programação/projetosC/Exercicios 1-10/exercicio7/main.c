#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, salreceber, imp;

    printf("Digite o salario desejado: ");
    scanf("%f", &sal);

    imp = sal * 10 / 100;

    salreceber = sal + 50 - imp;

    printf("O salario a receber eh: %.2f\n", salreceber);

    return 0;
}
