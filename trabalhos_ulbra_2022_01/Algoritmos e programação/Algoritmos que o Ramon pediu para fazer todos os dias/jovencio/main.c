#include <stdio.h>
#include <math.h>

int main(){
    int idade, dif;

    printf("Insira sua idade: ");
    scanf("%d%*c", &idade);

    if (idade>=18){
        printf("Voce ja pode frequentar o Clube dos Coroas no entrevero");
    }else{
        dif = 18 - idade;
        printf("Voce e menor de idade, falta %d anos para voce ser de maior", dif);
    }
    return 0;
}
