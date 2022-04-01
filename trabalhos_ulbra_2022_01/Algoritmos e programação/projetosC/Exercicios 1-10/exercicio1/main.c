#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    int n1, n2, n3, n4, soma;

    printf("Digite um valor: ");
    scanf("%d", &n1);

    printf("Digite outro valor: ");
    scanf("%d", &n2);

    printf("Digite outro valor: ");
    scanf("%d", &n3);

    printf("Digite outro valor: ");
    scanf("%d", &n4);

    soma = n1 + n2 + n3 + n4;

    printf("O valor da soma = %d\n", soma);

    system ("pause");
    return 0;
}
