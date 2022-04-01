#include <stdio.h>
#include <stdlib.h>

int main()
{
    int pes, poleg, jardas;
    float milha;

    printf("Digite a medida: ");
    scanf("%d", &pes);

    poleg = pes * 12;
    jardas = pes / 3;
    milha = jardas / 1,760;

    printf("O valor em polegadas: %.2d\n", poleg);
    printf("O valor em jardas: %d\n", jardas);
    printf("O valor em milhas: %.3f\n", milha);

    return 0;
}
