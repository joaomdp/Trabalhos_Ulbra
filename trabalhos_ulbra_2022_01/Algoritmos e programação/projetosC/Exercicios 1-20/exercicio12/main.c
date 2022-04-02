#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int n1, n2, r1, r2;

    printf( " ========== Esse programa calcula e mostra o numero desejado elevado a outro ========== \n\n");

    printf("Digite um valor maior que zero: ");
    scanf("%d", &n1);

    printf("Digite outro valor maior que zero: ");
    scanf("%d", &n2);

    r1 = pow(n1, n2);
    r2 = pow(n2, n1);

    printf("O primeiro valor elevado ao segundo: %.2d\n", r1);
    printf("O segundo valor elevado ao primeiro: %.2d\n", r2);

    return 0;
}
