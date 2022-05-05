#include <stdio.h>
#include <stdlib.h>

int main()
{
    int idade;

    printf("Digite sua idade: ");
    scanf("%d%*c", &idade);

    if (idade>=18 && idade<=69){
        printf("Voce tem o direito de voto obrigatorio");
    }else if(idade<18 && idade>=16){
        printf("Voce tem o direito de voto facultativo");
    }else if(idade>=70){
        printf("Voce tem o direito de voto facultativo");
    }else {
        printf("Voce nao tem o direito de votar");
    }
    return 0;
}
