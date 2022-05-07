#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, perc, aumento, novosal;

    printf ( " ========== Programa para descobrir seu novo salario com o porcentual desejado ==========\n\n " );

    printf("Digite o salario atual: ");
    scanf("%f", &sal);

    printf("Digite o percentual desejado: ");
    scanf("%f", &perc);

    aumento = (sal * perc / 100);

    printf("Aumento de: %.2f\n", aumento);

    novosal = sal + aumento;

    printf("Seu novo salario, com aumento eh: %.2f\n", novosal);

    return 0;
}
