#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n,i;

    for(i=0;i<5;i++){
        printf("Digite um numero:\n");
        scanf("%d%*c", &n);
        if(n==0){
            printf("Numero nulo\n");
        }else if(n>0){
            printf("Numero positivo\n");
        }else{
            printf("Numero negativo\n");
        }
    }
    return 0;
}
