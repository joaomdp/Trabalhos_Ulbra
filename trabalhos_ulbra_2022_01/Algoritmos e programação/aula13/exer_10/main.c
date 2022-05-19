#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i, valor;

    do{

    printf("Digite um valor inteiro\n: ");
    scanf("%d%*c", &valor);

    if (valor%2==0){
        printf("Numero par\n");
    }else{
        printf("Numero impar\n");
    }
    printf("\n-----------------------\n");
    i++;
    }while(i<10);
    return 0;
}
