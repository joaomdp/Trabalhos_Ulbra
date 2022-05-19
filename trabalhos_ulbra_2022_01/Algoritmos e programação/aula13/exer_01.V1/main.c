#include <stdio.h>
#include <stdlib.h>
#include<locale.h>
int main()
{
    setlocale(LC_ALL,"portuguese");
    int numero, soma, i;

    for(int i=0;i<10;i++){
    printf("Digite um numero: ");
    scanf("%d%*c", &numero);
    soma=numero+soma;
    }
    printf("A soma é:%d", soma);
    return 0;
}
