#include <stdio.h>
#include <stdlib.h>

int main()
{
    float area, raio;
    printf ( " ========== Programa para descobrir a area de um circulo ==========\n\n " );
    printf("Digite o valor do raio: ");
    scanf("%f", &raio);

    area = 3.14 * (raio * raio);

    printf("A area desse circulo eh: %.2f\n", area);

    return 0;
}
