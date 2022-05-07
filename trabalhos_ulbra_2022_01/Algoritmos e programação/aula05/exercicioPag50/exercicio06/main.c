#include <stdio.h>
#include <stdlib.h>

int main()
{
    float salario, valorVenda, comi, novoSal;

    printf("Digite o seu salario: ");
    scanf("%f%*c", &salario);

    printf("Digite o valor de vendas: ");
    scanf("%f%*c", &valorVenda);

    comi = valorVenda * 4 / 100;
    novoSal = salario + comi;

    printf("A comissao e: %.2f\n", comi);
    printf("O salario final e: %.2f\n", novoSal);
    return 0;
}
