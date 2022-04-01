#include <stdio.h>
#include <stdlib.h>

int main()
{
    float nota1, nota2, nota3, media;

    printf ( " ========== Programa para somar notas e mostrar a media ==========\n\n " );
    printf("Digite a primeira nota: ");
    scanf("%f", &nota1);

    printf("Digite a segunda nota: ");
    scanf("%f", &nota2);

    printf("Digite a terceira nota: ");
    scanf("%f", &nota3);

    media =(nota1+nota2+nota3)/3;

    printf("A media das nota eh: %.2f\n", media);

    return 0;
}
