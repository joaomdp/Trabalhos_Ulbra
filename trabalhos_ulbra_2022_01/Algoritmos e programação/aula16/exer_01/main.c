#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i, valor[6], par=0, impar=0;
    for (i=0;i<6;i++){
        printf("Digite o %d valor: ", i+1);
        scanf("%d%*c", &valor[i]);
        if(valor[i]%2==0){
            par++;
        }else{
            impar++;
        }
    }
    printf("Todos os numeros pares: \n");
    for(i=0;i<6;i++){
        if(valor[i]%2==0){
            printf("%d\n", valor[i]);
        }
    }
    printf("Quantidades de numeros pares: %d\n", par);
    printf("Todos os numeros impares:\n");
    for(i=0;i<6;i++){
        if(valor[i]%2!=0){
            printf("%d\n", valor[i]);
        }
    }
    printf("Quantidade de numeros impares: %d", impar);
    return 0;
}
