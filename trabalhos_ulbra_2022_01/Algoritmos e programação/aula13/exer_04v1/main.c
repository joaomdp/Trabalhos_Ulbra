#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i;
    float soma,nota,media;
    i=1;
    soma=0;
    do{
        printf("Digite a nota %d:\n", i);
        scanf("%f%*c", &nota);
        soma=soma+nota;
        i++;
    }while(i<10);
    media=soma/10;
    printf("A media e: %f", media);
    return 0;
}
