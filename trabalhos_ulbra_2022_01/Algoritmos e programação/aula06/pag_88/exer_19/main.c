#include <stdio.h>
#include <stdlib.h>

int main()
{
    float h, peso_homem, peso_mulher;
    char homem, mulher;

    printf("Digite sua altura: ");
    scanf("%f%*c", &h);

    printf("Escolha uma opcao\n ");
    printf("1-Homem\n");
    printf("2-Mulher\n");
    scanf("%c%*c", &homem);
    scanf("%c%*c", &mulher);

    peso_homem = (72,7*h) - 58;
    peso_mulher = (62,1*h) - 44.7;

    if (homem){
        printf("Seu peso ideal e: %.2f", peso_homem);
    }else {
        printf("Seu peso ideal e: %.2f", peso_mulher);
    }


    return 0;
}
