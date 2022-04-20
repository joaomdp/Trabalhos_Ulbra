#include <stdio.h>
#include <stdlib.h>

int main()
{
    float nota_1, nota_2, nota_3, media, nota_exame;

    printf("Digite a primeira nota: ");
    scanf("%f%*c", &nota_1);

    printf("Digite a segunda nota: ");
    scanf("%f%*c", &nota_2);

    printf("Digite a terceira nota: ");
    scanf("%f%*c", &nota_3);

    media = (nota_1 + nota_2 + nota_3) / 3;

    printf("A media aritmetica: %.2f\n", media);

    if (media >= 0 && media < 3){
        printf("Voce foi reprovado", media);
    }
    if (media >= 3 && media < 7){
        printf("Devera fazer o exame\n");
        nota_exame = 12 - media;
        printf("Deve tirar nota %.2f para ser aprovado\n", nota_exame);
    }
    if (media >=7 && media <=10) {
        printf("Voce foi aprovado", media);
    }


    return 0;
}
