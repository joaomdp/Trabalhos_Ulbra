#include <stdio.h>
#include <stdlib.h>

int main()
{
    float preco;
    int cod;

    printf("Digite o valor do produto: ");
    scanf("%f%*c", &preco);

    printf("Digite o codigo do produto: ");
    scanf("%d%*c", &cod);

    if (cod==1){
        printf("Preco: %.2f\n Regiao: Sul", preco);
    }else if (cod==2){
        printf("Preco: %.2f\n Regiao: Norte", preco);
    }else if (cod==3){
        printf("Preco: %.2f\n Regiao: Leste", preco);
    }else if (cod==4){
        printf("Preco: %.2f\n Regiao: Oeste", preco);
    }else if (cod==5  || cod==6){
        printf("Preco: %.2f\n Regiao: Nordeste", preco);
    }else if (cod==7 || cod==8 || cod==9){
        printf("Preco: %.2f\n Regiao: Sudeste",preco);
    }else if (cod>=10 && cod<=20){
        printf("Preco: %.2f\n Regiao: Centro-oeste", preco);
    }else {
        printf("Codigo invalido");
    }




    return 0;
}
