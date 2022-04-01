#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int num;
    float quad, cubo, r2, r3;

    printf("Digite um numero positivo maior que zero: ");
    scanf("%d", &num);

    quad = pow(num, 2);
    printf("O numero digitado ao quadrado: %.0f\n", quad);

    cubo = pow(num, 3);
    printf("O numero digitado ao cubo: %.1f\n", cubo);

    r2 = sqrt(num);
    printf("A raiz quadrada do numero digitado: %.1f\n", r2);

    r3 = cbrt(num);
    printf("A raiz cubica do numero digitado: %.1f\n", r3);

    return 0;
}
