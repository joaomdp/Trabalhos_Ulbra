#include <stdio.h>
#include <stdlib.h>

int main()
{
    int cont=1000;

    while (cont<=1500){
        if(cont%2!=0){
            printf("Os numeros impares sao: %d\n", cont);
        }
        cont++;
    }
    return 0;
}
