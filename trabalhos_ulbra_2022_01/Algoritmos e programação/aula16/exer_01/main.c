#include <stdio.h>
#include <stdlib.h>

int main()
{
    int valores[6];
    int i;
    int cont;

    for (i=0;i<6;i++){
        printf("Digite o valor %d:", i+1);
        scanf("%d%*c", &valores[i]);
    }
    for (i=0;i<6;i++){
        if(valores[i]%2==0){
            printf("Os numeros pares sao: %d\n", valores[i]);
            printf("Sao %d numeros pares", pares);
        }
    }
    return 0;
}
