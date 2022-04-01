#include <stdio.h>
#include <stdlib.h>

int main()
{
    float peso, gato1, gato2, total;

    printf("Digite o peso do saco de racao: ");
    scanf("%d", &peso);
    printf("Digite a quantidade fornecida para o gato 1: ");
    scanf("%d", &gato1);
    printf("Digite a quantidade fornecida para o gato 2: ");
    scanf("%d", &gato2);

    gato1 = gato1 / 1000;
    gato2 = gato2 / 1000;

    total = peso - 5 * (gato1 + gato2);

    printf("O restante de racao: %d%\n", total);
    return 0;
}
