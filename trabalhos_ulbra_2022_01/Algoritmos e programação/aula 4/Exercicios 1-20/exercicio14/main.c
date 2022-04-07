#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ano_atual, ano_nascimento, idade_atual, idade_2050;

    printf( " ========== Programa para descobrir sua idade ==========\n\n " );

    printf("Digite o ano atual: ");
    scanf("%d", &ano_atual);

    printf("Digite o ano de nascimento: ");
    scanf("%d", &ano_nascimento);

    idade_atual = ano_atual - ano_nascimento;
    idade_2050 = 2050 - ano_nascimento;

    printf("A sua idade atual: %d\n", idade_atual);
    printf("Voce tera em 2050: %d\n", idade_2050);

    return 0;
}
