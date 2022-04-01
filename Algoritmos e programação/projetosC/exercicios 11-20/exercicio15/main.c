#include <stdio.h>
#include <stdlib.h>

int main()
{
    float p_fab, perc_d, perc_i, vlr_d, vlr_i, p_fin;

    printf("Digite o preço do veiculo: ");
    scanf("%f", &p_fab);

    printf("Digite o percentual de lucro do distribuidor: ");
    scanf("%f", &perc_d);

    printf("Digite o percentual do imposto: ");
    scanf("%f", &perc_i);
    vlr_d = p_fab * perc_d / 100;
    vlr_i = p_fab * perc_i / 100;
    p_fin = p_fab + vlr_d + vlr_i;

    printf("O valor correspondente ao lucro do distribuidor: %.2f\n", vlr_d);
    printf("O valor correspondente aos impostos: %.2f\n", vlr_i);
    printf("O preço final do veiculo: %.2f\n", p_fin);

    return 0;
}
