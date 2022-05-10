#include <stdio.h>
#include <stdlib.h>
#include<locale.h>

int main()
{
    setlocale(LC_ALL, "portuguese");

    int numero;

    printf("Digite aqui um número inteiro: ");
    scanf("%d%*c", &numero);

    if (numero%5==0){
        printf("Este número é multiplo de 5");
    }else{
        printf("Este número não é multiplo de 5");
    }
    return 0;
}
