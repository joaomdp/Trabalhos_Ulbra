#include <stdio.h>
#include <stdlib.h>
#include<locale.h>

int main()
{
    setlocale(LC_ALL, "portuguese");

    int numero;

    printf("Digite aqui um n�mero inteiro: ");
    scanf("%d%*c", &numero);

    if (numero%5==0){
        printf("Este n�mero � multiplo de 5");
    }else{
        printf("Este n�mero n�o � multiplo de 5");
    }
    return 0;
}
