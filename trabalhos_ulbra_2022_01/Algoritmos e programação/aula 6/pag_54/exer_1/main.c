#include <stdio.h>
#include <stdlib.h>

int main()
{
    float nota, aval, exame, media;

    printf("Digite a nota do trabalho de laboratiorio: ");
    scanf("%f%*c", &nota);

    printf("Digite a nota da avaliacao trimestral: ");
    scanf("%f%*c", &aval);

    printf("Digite a nota do exame final: ");
    scanf("%f%*c", &exame);

    media = ( nota * 2 + aval * 3 + exame * 5 ) / 10;
    printf("A media ponderada: %.2f\n", media);

    if  (media >= 8 && media <=10){
        printf("Obteve o conceito A\n", media);
    }

    if  (media >= 7 && media < 8){
        printf("Obteve o conceito B\n", media);
    }

    if  (media >= 6 && media < 7){
        printf("Obteve o conceito C\n", media);
    }

    if  (media >= 5 && media < 6){
        printf("Obteve o conceito D\n", media);
    }

    if  (media >= 0 && media < 5){
        printf("Obteve o conceito E\n", media);
    }



    return 0;
}
