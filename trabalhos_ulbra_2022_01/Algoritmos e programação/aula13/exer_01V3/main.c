#include <stdio.h>
#include <stdlib.h>
#include<locale.h>
int main()
{
    setlocale(LC_ALL,"portuguese");

    int numero, soma;
    int i=0;

    do{
        printf("Digite o numero %d\n", i+1);
        scanf("%d%*c", &numero);
        soma=numero+soma;
        printf("A soma dos números é: %d\n", soma);
    }while(i!=10);

    return 0;
}
