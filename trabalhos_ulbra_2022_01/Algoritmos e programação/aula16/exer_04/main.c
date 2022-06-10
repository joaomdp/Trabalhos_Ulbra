#include <stdio.h>
#include <stdlib.h>

int main()
{
    float vetor[10],positivo,negativo;
    int i,soma=0;
    for(i=0;i<10;i++){
        printf("Digite o %d valor: ", i+1);
        scanf("%f%*c", &vetor[i]);
            if(vetor[i]<0){
                negativo++;
            }else if(vetor[i]>10){
                positivo++;
            }
    }
    for(i=0;i<10;i++){
        if(vetor[i]<0){
            printf("Os numeros %.2f sao negativos\n", vetor[i]);
        }
    }
    for(i=0;i<10;i++){
        soma=soma+vetor[i];
    }
    printf("A soma : %d\n", soma);
    return 0;
}
