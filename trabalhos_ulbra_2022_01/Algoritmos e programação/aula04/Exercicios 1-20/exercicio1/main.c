#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    int n1, n2, n3, n4, soma;

    printf( " ========== Programa para somar numeros inteiros ========== \n\n " ) ;

    printf("Digite um valor: ");
    scanf("%d%*c", &n1);

    printf("Digite outro valor: ");
    scanf("%d%*c", &n2);

    printf("Digite outro valor: ");
    scanf("%d%*c", &n3);

    printf("Digite outro valor: ");
    scanf("%d%*c", &n4);

    soma = n1 + n2 + n3 + n4;

    printf("O valor da soma = %d\n\n", soma);

    system ("pause");
    return 0;
}
