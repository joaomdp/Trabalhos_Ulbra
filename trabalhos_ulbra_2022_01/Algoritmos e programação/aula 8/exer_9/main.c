#include <stdio.h>
#include <stdlib.h>

int main()
{
    float nota1, nota2, nota3, media;

    printf("Digite sua primeira nota: ");
    scanf("%f%*c", &nota1);

    printf("Digite sua segudna nota: ");
    scanf("%f%*c", &nota2);

    printf("Digite sua terceira nota: ");
    scanf("%f%*c", &nota3);

    media = (nota1 + nota2 + nota3)/3;

    if(media>=9.0){
        printf("Sua media e: %.2f\n", media);
        printf("Conceito: A\n");
        printf("Voce foi aprovado");
    }else if (media>=7.5 && media<9){
        printf("Sua media e: %.2f\n", media);
        printf("Conceito: B\n");
        printf("Voce foi aprovado");
    }else if (media>=6.0 && media<7.5){
        printf("Sua media e: %.2f\n", media);
        printf("Conceito: C\n");
        printf("Voce foi aprovado");
    }else if (media>=4.0 && media<6.0){
        printf("Sua media e: %.2f\n", media);
        printf("Conceito: D\n");
        printf("Voce foi reprovado");
    }else if (media<4.0){
        printf("Sua media e: %.2f\n", media);
        printf("Conceito: E\n");
        printf("Voce foi reprovado");
    }else{
        printf("Valor invalido");
    }
    return 0;
}
