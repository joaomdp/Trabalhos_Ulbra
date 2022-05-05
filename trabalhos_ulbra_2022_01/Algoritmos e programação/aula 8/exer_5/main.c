#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1, n2;

    printf("Digite um numero: ");
    scanf("%d%*c", &n1);

    printf("Digite outro numero: ");
    scanf("%d%*c", &n2);

    if (n1%2==0){
        printf("O valor %d e multiplo de 2\n", n1);
    }else{
        printf("O valor %d nao e multiplo de 2\n", n1);
    }
    if (n2%2==0){
        printf("O valor %d e multiplo de 2\n", n2);
    }else{
        printf("O valor %d nao e multiplo de 2\n", n2);
    }
    return 0;
}
