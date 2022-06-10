#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i,vetor[5],soma=0;
    for(i=0;i<5;i++){
        printf("Digite o %d valor\n", i+1);
        scanf("%d%*c", &vetor[i]);
    }
    for(i=0;i<5;i++){
        soma=soma+vetor[i];
    }
    printf("Os numeros digitados foram:\n");
    printf("%d+%d+%d+%d+%d=%d", vetor[0],vetor[1],vetor[2],vetor[3],vetor[4], soma);
    return 0;
}
