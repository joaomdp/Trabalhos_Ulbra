#include <stdio.h>
#include <stdlib.h>

int main()
{
    float area, raio;

    printf("Digite o valor do raio: ");
    scanf("%f", &raio);

    area = 3.14 * (raio * raio);

    printf("A area desse circulo eh: %.2f\n", area);

    return 0;
}
