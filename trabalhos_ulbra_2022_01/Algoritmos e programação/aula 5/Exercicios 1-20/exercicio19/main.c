#include <stdio.h>
#include <stdlib.h>

int main()
{
    float a_degrau, a_usuario, qtd_degraus;

    printf("========== O programa mostra quantos degraus o usuario precisa subir ==========\n\n " );

    printf("Qual a altura da escada: ");
    scanf("%f", &a_degrau);
    printf("Qual a altura onde esta o usuario: ");
    scanf("%f", &a_usuario);

    qtd_degraus = a_usuario / a_degrau;

    printf("A quantidade de degraus e: %f\n", qtd_degraus);
    return 0;
}
