#include <stdio.h>
#include <stdlib.h>

int main()
{
    //10. Faça um programa para ler a nota da prova de 15 alunos e armazene num vetor, calcule e imprima a média geral.
    int valores[15];
    int i;
    float soma=0,media;

    for(i=0;i<15;i++){
        printf("Digite a %d nota na prova: ", i+1);
        scanf("%d%*c", &valores[i]);
    }
    for(i=0;i<15;i++){
        soma=soma+valores[i];
        media=soma/15;
    }
    for(i=0;i<15;i++){
        printf("valores[%d] = %d\n", i+1,valores[i]);
    }
    printf("A media da turma foi: %.2f\n", media);

    return 0;
}
