#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i;
    float soma,nota,media;
    i=1;
    soma=0;
    for (i=0;i<10;i++){
        printf("Digite a nota\n");
        scanf("%f%*c", &nota);
        soma=soma+nota;
    }
    media=soma/10;
    printf("A media e %.2f", media);
    return 0;
}
