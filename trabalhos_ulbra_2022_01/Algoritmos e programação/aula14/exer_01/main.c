#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i;
    float nota,media,soma;
    soma=0;
    i=0;
    do{
        printf("Digite a nota\n");
        scanf("%f%*c", &nota);

        if(nota>=0){
            i++;
            soma=soma+nota;
        }else{
            printf("Encerrando");
            break;
        }

    }while(nota>=0);
    media=soma/i;
    printf("A media e %.2f\n", media);
    printf("Foram lidos %d\n", i);
    return 0;
}
