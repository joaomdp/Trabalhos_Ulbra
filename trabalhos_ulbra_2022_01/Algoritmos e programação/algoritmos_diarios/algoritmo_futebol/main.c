#include <stdio.h>
#include <stdlib.h>
#include<locale.h>
int main()
{
    setlocale(LC_ALL, "portuguese");

    float valor;
    int jogadores;

    printf("Informe quantos goleiros foram jogar no dia: ");
    scanf("%d", &jogadores);



    if (jogadores==0){
        valor = 160 / 14;
        printf("O valor pago por cada jogador é: %.2f", valor);
    }else if (jogadores==1){
        valor = 160/13;
        printf("O valor pago por cada jogador é: %.2f", valor);
    }else if(jogadores==2){
        valor = 160/12;
        printf("O valor pago por cada jogador é: %.2f", valor);
    }else{
        printf("Valor inválido");
    }
    return 0;
}
