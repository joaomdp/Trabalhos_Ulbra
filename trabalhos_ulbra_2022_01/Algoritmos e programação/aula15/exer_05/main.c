#include <stdio.h>
#include <stdlib.h>

int main()
{
    int valor[10];
    int i,pares;
    for(i=0;i<10;i++){
        printf("Digite um valor: ");
        scanf("%d", &valor[i]);
        if(valor[i]%2==0){
            pares++;
            printf("Valores pares", pares);
        }
    }
    return 0;
}
