#include <stdio.h>
#include <stdlib.h>
#include<string.h>
int main()
{
    //FUP que leia 3 strings e escreva em ordem alfabética
    char letra1[1];
    char letra2[1];
    char letra3[1];

    printf("Digite uma letra\n");
    scanf("%s%*c",&letra1);
    printf("Digite uma letra\n");
    scanf("%s%*c",&letra2);
    printf("Digite uma letra\n");
    scanf("%s%*c",&letra3);

    strcmp(letra1,letra2)==1;

    printf("%s %s %s",letra1,letra2,letra3);
    return 0;
}
