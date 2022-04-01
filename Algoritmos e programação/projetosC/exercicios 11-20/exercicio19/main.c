#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a_degrau, a_usuario, qtd_degraus;

    printf("Qual a altura da escada: ");
    scanf("%d", &a_degrau);
    printf("Qual a altura onde esta o usuario: ");
    scanf("%d", &a_usuario);

    qtd_degraus = a_usuario / a_degrau;

    printf("A quantidade de degraus e: %d\n", qtd_degraus);
    return 0;
}
