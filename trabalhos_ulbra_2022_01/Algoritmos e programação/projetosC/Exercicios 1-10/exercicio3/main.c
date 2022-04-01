#include <stdio.h>
#include <stdlib.h>

int main()
{
    int  nota1, nota2, nota3, peso1, peso2, peso3, media;

    printf("Digite o valor da primeira nota: ");
    scanf("%d", &nota1);

    printf("Digite o valor de peso: ");
    scanf("%d", &peso1);

    printf("Digite o valor da segunda nota: ");
    scanf("%d", &nota2);

    printf("Digite o valor de peso: ");
    scanf("%d", &peso2);

    printf("Digite o valor da terceira nota: ");
    scanf("%d", &nota3);

    printf("Digite o valor de peso: ");
    scanf("%d", &peso3);

    media = (nota1*peso1 + nota2*peso2 + nota3*peso3)/(peso1 + peso2 + peso3);

    printf("A media eh: %d\n", media);

    return 0;
}
