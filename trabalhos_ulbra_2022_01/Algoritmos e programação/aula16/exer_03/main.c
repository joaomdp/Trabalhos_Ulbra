#include <stdio.h>
#include <stdlib.h>

int main()
{
    int vetor[15],i,cont=0;
    for(i=0;i<15;i++){
        printf("Digite o %d valor: ", i+1);
        scanf("%d%*c", &vetor[i]);
    }
    for(i=0;i<15;i++){
        if(vetor[i]==30){
            printf("Na posicao %d existe o numero 30\n", i+1);
            cont=1;
        }
    }
    if(cont=0){
        printf("O nuemero 30 nao existe no vetor");
    }
    return 0;
}
