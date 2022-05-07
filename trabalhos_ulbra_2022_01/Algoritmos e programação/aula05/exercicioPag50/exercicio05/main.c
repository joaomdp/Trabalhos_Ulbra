#include <stdio.h>
#include <stdlib.h>

int main()
{
    float preco, aumento;
    printf("Digite o preco do produto: ");
    scanf("%f", &preco);

    aumento = preco * 90/100;
    printf("O preco com aumento: %.2f\n", aumento);
    return 0;
}
