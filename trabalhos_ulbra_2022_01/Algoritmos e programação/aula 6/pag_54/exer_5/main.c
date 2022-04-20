#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1, n2, n3, n4;

    printf("Digite tres numeros em ordem crescente\n");

    printf("O primeiro numero e:\n ");
    scanf("%d%*c", &n1);

    printf("O segundo numero e:\n ");
    scanf("%d%*c", &n2);

    printf("O terceiro numero e:\n ");
    scanf("%d%*c", &n3);


    printf("Digite um numero (fora dessa ordem):\n ");
    scanf("%d%*c", &n4);

    if (n4 > n3){
        printf("A ordem decrescente e: %d\n", n4);
        printf("%d\n", n3);
        printf("%d\n", n2);
        printf("%d\n", n1);
    }


    return 0;
}
