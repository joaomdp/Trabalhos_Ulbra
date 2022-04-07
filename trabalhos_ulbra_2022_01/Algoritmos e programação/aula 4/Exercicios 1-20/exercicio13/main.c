#include <stdio.h>
#include <stdlib.h>

int main()
{
    float pes, poleg, jardas, milhas;

    printf( " ========== Programa para calcular as medidas em pés ========== " );

    printf("Digite a medida: ");
    scanf("%f", &pes);

    poleg = pes * 12;
    jardas = pes / 3;
    milhas = pes / 5280;

    printf("%.2f pes=%.2f Polegada\n",pes,poleg);
    printf("%.2f pes=%.2f jardas\n",pes,jardas);
    printf("%.2f pes=%f milhas\n",pes,milhas);


    return 0;
}
