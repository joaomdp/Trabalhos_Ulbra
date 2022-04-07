#include <stdio.h>
#include <stdlib.h>

int main()
{
    float dep, taxa, rend, total;
    printf ( " ========== Programa para ver o valor de rendimento de um deposito ==========\n\n " );

    printf("Digite o valor do deposito: ");
    scanf("%f", &dep);

    printf("Digite o valor da taxa de juros: ");
    scanf("%f", &taxa);

    rend = dep * taxa / 100;

    total = dep + rend;

    printf("O valor da rendimento eh: %.2f\n", rend);

    printf("O valor toral depois do rendimento eh: %.2f\n", total);

    return 0;
}
