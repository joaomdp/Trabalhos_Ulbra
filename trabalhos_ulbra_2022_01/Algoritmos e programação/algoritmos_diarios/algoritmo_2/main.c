#include<stdio.h>

int main(){
    int numero[10], soma, media;

    soma=0;
    int i;
    for(i=1;i<10;i++){
        printf("Digite um numero\n");
        scanf("%d%*c", &numero[i]);
            soma = soma+numero[i];
            media=soma/10;
    }


    printf("A soma dos 10 numeros: %d\n", soma);
    printf("A media dos 10 numeros: %d\n", media);

    printf("Quais numeros estao acima da media?\n");
    for(i=0;i<10;i++){
        if(numero[i]>media){
            printf("Valor[%d] e maior que media\n", numero[i]);
        }
    }

    printf("Exibir o vetor?\n");
    for(i=0;i<9;i++);{
        printf("Valor [%d] posicao %d\n", numero[i],i);
    }
}
