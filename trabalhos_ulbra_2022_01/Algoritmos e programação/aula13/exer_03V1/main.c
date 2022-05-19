#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1,n2;
    printf("Digite o primeiro numero: ");
    scanf("%d", &n1);

    printf("Digite o segundo numero: ");
    scanf("%d", &n2);

    while(n1<=n2){
        if(n1%2!=0){
            printf("Numero impar: %d", n1);

        }
    }n1++;

    return 0;
}

