#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    float num, quad, cubo, r2, r3;

    printf( " ========== Programa para calcular o numero ao quadrado, cubica e raizes\n\n  ");

    printf("Digite um numero positivo maior que zero: ");
    scanf("%f", &num);

    quad = pow(num, 2);
    printf("O numero digitado ao quadrado: %.2f\n", quad);

    cubo = pow(num, 3);
    printf("O numero digitado ao cubo: %.2f\n", cubo);

    r2 = sqrt(num);
    printf("A raiz quadrada do numero digitado: %f\n", r2);

    r3 = cbrt(num);
    printf("A raiz cubica do numero digitado: %.2f\n", r3);

    return 0;
}
