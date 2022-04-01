#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, novosal;

    printf("Digite o salario desejado: ");
    scanf("%f", &sal);

    novosal = (sal * 25 / 100)+ sal;

    printf("O novo salario eh: %.2f\n", novosal);

    return 0;
}
