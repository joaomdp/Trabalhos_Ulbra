#include <stdio.h>
#include <stdlib.h>

int main()
{
    float  nota1, nota2, nota3, peso1, peso2, peso3, media;

    printf ( " ========== Programa para somar as notas, os pesos e mostrar a media ==========\n\n " );

    printf("Digite o valor da primeira nota: ");
    scanf("%f", &nota1);

    printf("Digite o valor de peso: ");
    scanf("%f", &peso1);

    printf("Digite o valor da segunda nota: ");
    scanf("%f", &nota2);

    printf("Digite o valor de peso: ");
    scanf("%f", &peso2);

    printf("Digite o valor da terceira nota: ");
    scanf("%f", &nota3);

    printf("Digite o valor de peso: ");
    scanf("%f", &peso3);

    media = (nota1*peso1 + nota2*peso2 + nota3*peso3)/(peso1 + peso2 + peso3);

    printf("A media eh: %.2f\n", media);

    return 0;
}
