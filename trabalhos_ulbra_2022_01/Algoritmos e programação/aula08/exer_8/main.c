#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1, n2, n3, n4;

    printf("Digite um numero: ");
    scanf("%d%*c", &n1);

    printf("Digite outro numero: ");
    scanf("%d%*c", &n2);

    printf("Digite outro numero: ");
    scanf("%d%*c", &n3);

    printf("Digite outro numero: ");
    scanf("%d%*c", &n4);

    if (n1%2==0){
        printf("O valor %d e divisivel de 2\n", n1);
    }else if (n1%3==0){
        printf("O valor %d e divisivel de 3\n", n1);
    }else {
        printf("Valor invalido");
    }

    if (n2%2==0){
        printf("O valor %d e divisivel de 2\n", n2);
    }else if (n2%3==0){
        printf("O valor %d e divisivel de 3\n", n2);
    }else {
        printf("Valor invalido");
    }

    if (n3%2==0){
        printf("O valor %d e divisivel de 2\n", n3);
    }else if (n3%3==0){
        printf("O valor %d e divisivel de 3\n", n3);
    }else {
        printf("Valor invalido");
    }

    if (n4%2==0){
        printf("O valor %d e divisivel de 2\n", n4);
    }else if (n4%3==0){
        printf("O valor %d e divisivel de 3\n", n4);
    }else {
        printf("Valor invalido");
    }
    return 0;
}
