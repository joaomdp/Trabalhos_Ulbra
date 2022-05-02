#include <stdio.h>
#include <stdlib.h>

int main()
{
    float preco, novo1, novo2;

    printf("Digite o preco do produto: ");
    scanf("%f%*c", &preco);

    novo1 = preco*10/100-(preco) ;

    novo2 = preco*15/100-(preco);

    if (preco<=30){
        printf("Voce nao possui desconto\n");
        printf("O valor final do produto e: %.2f", preco);
    }else if (preco>=31 && preco<=100) {
        printf("O valor com desconto aplicado e: %.2f", novo1);
    }else if (preco>101){
        printf("O valor com desconto aplicado e: %.2f", novo2);
    }
    return 0;
}
