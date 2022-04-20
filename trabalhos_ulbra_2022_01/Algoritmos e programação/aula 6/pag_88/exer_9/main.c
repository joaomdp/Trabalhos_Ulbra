#include <stdio.h>
#include <stdlib.h>

int main()
{
    float saldo_medio, valor_credito1, valor_credito2, valor_credito3, valor_credito4;

    printf("Digite o valor do saldo medio do ultimo ano: ");
    scanf("%f%*c", &saldo_medio);

    valor_credito1 = (saldo_medio * 30/100) + saldo_medio;
    valor_credito2 = (saldo_medio * 25/100) + saldo_medio;
    valor_credito3 = (saldo_medio * 20/100) + saldo_medio;
    valor_credito4 = (saldo_medio * 10/100) + saldo_medio;

    if (saldo_medio > 400){
        printf("O seu saldo medio e: %.2f\n", saldo_medio);
        printf("O valor de credito e: %.2f\n", valor_credito1);
    }else if (saldo_medio =400 && saldo_medio >301){
        printf("O seu saldo medio e: %.2f\n", saldo_medio);
        printf("O valor de credito e: %.2f\n", valor_credito2);
    }else if (saldo_medio =300 && saldo_medio >201){
        printf("O seu saldo medio e: %.2f\n", saldo_medio);
        printf("O valor de credito e: %.2f\n", valor_credito3);
    }else if (saldo_medio <=200){
        printf("O seu saldo medio e: %.2f\n", saldo_medio);
        printf("O valor de credito e: %.2f\n", valor_credito4);
    }
    return 0;
}
