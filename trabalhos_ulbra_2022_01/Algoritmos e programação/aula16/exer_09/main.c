#include <stdio.h>
#include <stdlib.h>

int main()
{
    int tamanho=10;
    int A[tamanho],B[tamanho],i,resultado;
    for(i=0;i<tamanho;i++){
        printf("Digite o %d valor correspondente ao primeiro vetor: ", i+1);
        scanf("%d%*c", &A[i]);
    }
    for(i=0;i<tamanho;i++){
        printf("Digite o %d valor correspondente ao segundo vetor: ", i+1);
        scanf("%d%*c", &B[i]);
    }
      for(i=0;i<tamanho;i++){
        resultado=A[i]*B[i];
        printf("O resultado da multiplicacao de %d X %d e = %d\n", A[i], B[i], resultado);
    }
    return 0;
}
