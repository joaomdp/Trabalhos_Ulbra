#include <stdio.h>
#include <stdlib.h>

int main()
{
    float  poup, fund, valor;

    int tipo;

    printf("Escolha qual o tipo de investimento\n\nTipo 1 - Poupanca\nTipo 2 - Fundos de renda fixa\n");
    scanf("%d%*c", &tipo);

    poup = (valor * 3/100) + valor;
    fund = (valor * 4/100) + valor;

    printf("Digite o valor desejado: ");
    scanf("%f%*c", &valor);

    if (tipo==1){
        printf("O valor ficara: %.2f", poup);
    }else if (tipo==2){
        printf("O valor ficara: %.2f", fund);
    }else {
        printf("O numero escolhido e invalido");
    }

    return 0;
}
