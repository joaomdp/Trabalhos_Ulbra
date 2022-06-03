#include <stdio.h>
#include <stdlib.h>

int main()
{
    int valores[10];
    int i,maior, menor;

    for(i=0;i<10;i++){
        printf("Digite um valor: ");
        scanf("%d%*c", &valores[i]);
    }
    maior=valores[0];
    menor=valores[0];

    for(i=0;i<10;i++){
        if(maior<valores[i]){
            maior=valores[i];
        }
        if(menor>valores[i]){
            menor=valores[i];
        }
    }
    printf("O maior e: %d\n", maior);
    printf("O maior e: %d\n", menor);
    return 0;
}
