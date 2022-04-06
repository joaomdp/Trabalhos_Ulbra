#include <stdio.h>
#include <stdlib.h>
#include<math.h>

int main()
{
    float peso, emagre, engord;
    printf("Digite o seu peso: ");
    scanf("%f%*c", &peso);

    engord = peso +(peso*15/100);
    emagre = peso -(peso*20/100);

    printf("O novo peso caso engorde: %.2f\n", engord);
    printf("O novo peso caso emagreca: %.2f\n", emagre);
    return 0;
}
