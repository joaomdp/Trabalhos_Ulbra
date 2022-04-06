#include <stdio.h>
#include <stdlib.h>

int main()
{
    int horas_t, vlr_sal_min, vlr_hora_t;
    float vlr_sal_bru, imp, vlr_sal_liq;

    printf( " ========== O programa calcula e mostra o salario a receber ==========\n\n " );

    printf("Digite as horas trabalhadas: ");
    scanf("%d", &horas_t);

    printf("Digite o valor do salario minimo: ");
    scanf("%d", &vlr_sal_min);

    vlr_hora_t = vlr_sal_min / 2;
    vlr_sal_bru = vlr_hora_t * horas_t;
    imp = vlr_sal_bru * 3 / 100;
    vlr_sal_liq = vlr_sal_bru - imp;

    printf("O valor do salario a receber: %f\n", vlr_sal_liq);

    return 0;
}
