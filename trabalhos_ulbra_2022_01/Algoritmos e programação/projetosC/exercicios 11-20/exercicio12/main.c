#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1, n2, soma;
    float r1, r2;

    printf( " ========== Esse programa calcula e mostra o numero desejado elevado a outro ========== \n\n");

    printf("Digite um valor maior que zero: ");
    scanf("%d", &n1);

    printf("Digite outro valor maior que zero: ");
    scanf("%d", &n2);

    soma = n1 + n2;
    printf("A soma desses dois numeros eh: %d\n", soma);

    r1 = pow(n1, n2);
    r2 = pow(n2, n1);

    printf("O primeiro valor elevado ao segundo: %.1f\n", r1);
    printf("O segundo valor elevado ao primeiro: %.1f\n", r2);

    return 0;
}
