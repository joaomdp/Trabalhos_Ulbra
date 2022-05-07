#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("========== O programa calcula e mostra a medida de uma escada ==========\n\n " );

    float ang, alt, escada, radiano;

    printf("Digite o valor de angulo: \n");
    scanf("%f", &ang);

    printf("Digite o valor da altura: \n");
    scanf("%f", &alt);

    radiano = ang * 3.14 / 180;
    escada = alt / sin(radiano);

    printf("A medida dessa escada: %f\n", escada);


    return 0;
}
