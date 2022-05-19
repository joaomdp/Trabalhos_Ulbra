#include <stdio.h>
#include <stdlib.h>
#include<locale.h>
int main()
{
    setlocale(LC_ALL,"portuguese");
    int numero, soma;
    soma=0;
    int i=0;
    while(i<10){
        printf("Digite o numero %d\n", i+1);
        scanf("%d", &numero);
        soma=soma+numero;
        i++;
    }
    printf("A soma é: %d", soma);
    return 0;
}
