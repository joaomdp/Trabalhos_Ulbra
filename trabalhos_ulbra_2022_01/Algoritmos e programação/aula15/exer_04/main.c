#include <stdio.h>
#include <stdlib.h>

int main()
{
    int vet[8],x,y,soma;

    for(int i=0;i<8;i++){
        printf("Digite um valor: ");
        scanf("%d", &vet[i]);
    }
    printf("Digite um X: ");
    scanf("%d", &x);
    printf("Digite um y: ");
    scanf("%d", &y);
    soma = vet[x] + vet[y];
    printf("O valor da soma e: %d", soma);
    return 0;
}
