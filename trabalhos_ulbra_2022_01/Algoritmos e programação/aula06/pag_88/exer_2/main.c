#include <stdio.h>
#include <stdlib.h>

int main()
{
    float nota1, nota2, media;

    printf("Digite sua primeira nota: ");
    scanf("%f%*c", &nota1);

    printf("Digite sua segunda nota: ");
    scanf("%f%*c", &nota2);

    media = (nota1 + nota2)/2;

    if ( media >= 7){
        printf("Voce foi aprovado");
    }else if ( media >=4){
        printf("Tera que fazer o exame");
    }else{
        printf("Voce foi reprovado");
    }

    return 0;
}
