#include <stdio.h>
#include <stdlib.h>

int main()
{
    int base, altura, area;
    printf ( " ========== Programa para descobrir a area de um triangulo ==========\n\n " );

    printf("Digite a base do triangulo: ");
    scanf("%d", &base);

    printf("Digite a altura do triangulo: ");
    scanf("%d", &altura);

    area = (base * altura)/2;

    printf("A area do triangulo eh: %.2d\n", area);
    return 0;
}
