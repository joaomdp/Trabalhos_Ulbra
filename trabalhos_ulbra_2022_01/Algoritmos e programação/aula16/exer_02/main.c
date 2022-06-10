#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i, valor[7], dois=0, tres=0;
    for (i=0;i<7;i++){
        printf("Digite o %d valor: ", i+1);
        scanf("%d%*c", &valor[i]);
        if(valor[i]%2==0){
            dois++;
        }else if(valor[i]%3==0){
            tres++;
        }
    }
    printf("Todos os numeros multiplos de dois: \n");
    for(i=0;i<7;i++){
        if(valor[i]%2==0){
            printf("%d\n", valor[i]);
        }
    }
    printf("Todos os numeros multiplos de 3:\n");
    for(i=0;i<7;i++){
        if(valor[i]%3==0){
            printf("%d\n", valor[i]);
        }
    }
    printf("Todos os numeros multiplos de 2 e de 3:\n");
    for(i=0;i<7;i++){
        if(valor[i]%2==0 && valor[i]%3==0){
            printf("%d\n", valor[i]);
        }
    }
    return 0;
}

