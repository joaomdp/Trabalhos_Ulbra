#include <stdio.h>
#include <stdlib.h>
#include<string.h>

int main()
{
    char nome[10];
    char sobrenome[10];
    char nomeCompleto[20];

    puts("Digite seu nome");
    gets(nome);
    puts("Digite seu sobrenome");
    gets(sobrenome);

    strcat(nomeCompleto,nome);
    strcat(nomeCompleto," ");
    strcat(nomeCompleto,sobrenome);

    puts(nomeCompleto);
    return 0;
}
