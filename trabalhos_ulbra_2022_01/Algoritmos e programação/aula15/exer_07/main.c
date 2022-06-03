#include <stdio.h>
#include <stdlib.h>

int main()
{

//7. Escreva um programa que leia 10 números inteiros e os armazene em um vetor. Imprima  o vetor, o maior elemento e a posição em que ele se encontra.

    int valores[10];
    int i;

    for(i=0;i<10;i++){
        printf("Digite o numero %d: ", i+1);
        scanf("%d%*c", &valores[i]);
    }
    int maior=valores[0];
    int posicao=1;
    for(i=0;i<10;i++){
        if(valores[i]>maior){
            maior=valores[i];
            posicao=i+1;
        }
    }
    printf("O maior valor e:");
    for(i=0;i<10;i++){
        printf("%d", valores[i]);
    }
    printf("E esta na posicao: %d", posicao);
    return 0;
}
