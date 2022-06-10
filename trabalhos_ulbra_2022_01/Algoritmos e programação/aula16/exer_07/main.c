#include <stdio.h>
#include <stdlib.h>

int main()
{
    int tamanho=50;
    int vetor[tamanho],i;
    for(i=0;i<tamanho;i++){
        printf("Digite o %d numero: ", i+1);
        scanf("%d%*c", &vetor[i]);
    }
    for(i=0;i<tamanho;i++){
        if(vetor[i]>0){
            printf("Os valores %d sao positivos\n", vetor[i]);
        }
    }
    return 0;
}
