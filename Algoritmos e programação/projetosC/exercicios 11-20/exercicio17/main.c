#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, c1, c2, cpmf1, cpmf2, saldo;

    printf("Digite o salario atual: ");
    scanf("%f", &sal);
    printf("Digite o valor do primeiro cheque: ");
    scanf("%f", &c1);
    printf("Digite o valor do segundo cheque: ");
    scanf("%f", &c2);

    cpmf1 = c1 * 0.38 / 100;
    cpmf2 = c2 * 0.38 / 100;

    saldo = sal - c1 - c2 - cpmf1 - cpmf2;

    printf("O valor final do saldo: %.2f\n", saldo);
    return 0;
}
