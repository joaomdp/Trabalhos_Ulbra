#include <stdio.h>
#include <stdlib.h>

int main()
{
    float n1, n2;

    printf("Digite um valor: ");
    scanf("%f%*c", &n1);

    printf("Digite outro valor: ");
    scanf("%f%*c", &n2);

    if(n1>n2){
        printf("O maior valor e: %.1f", n1);
    }else if (n2>n1){
        printf("O maior valor e: %.1f", n2);
    }else {
        printf("Os valores sao iguais");
    }

    return 0;
}
