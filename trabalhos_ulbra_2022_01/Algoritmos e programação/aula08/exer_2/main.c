#include <stdio.h>
#include <stdlib.h>

int main()
{
    int idade;

    printf("Digite sua idade atual: ");
    scanf("%d%*c", &idade);

    if (idade<=17){
        printf("Voce e menor de idade");
    }else if (idade>=18){
        printf("Voce e maior de idade");
    }else {
        printf("Valor invalido");
    }
    return 0;
}
