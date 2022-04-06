#include <stdio.h>
#include <stdlib.h>

int main()
{
    float nota1, nota2, media;
    printf("Digite sua nota 1: ");
    scanf("%f", &nota1);
    printf("Digite sua nota 2: ");
    scanf("%f", &nota2);

    media = ((nota1 * 2) + (nota2 * 3))/5;

    printf("A media das notas: %.2f\n", media);


    return 0;
}
