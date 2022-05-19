#include <stdio.h>
#include <stdlib.h>

int main()
{
    int total=10;
    int matricula, i;
    char nome[10];
    float nota1, nota2, nota3, media;

    for(i=1;i<total;i++){
    printf("Digite o nome %d:\n", i);
    scanf("%s%*c", &nome);

    printf("Digite a matricula:\n");
    scanf("%d%*c", &matricula);

    printf("Digite sua nota 1:\n");
    scanf("%f%*c", &nota1);

    printf("Digite sua nota 2:\n");
    scanf("%f%*c", &nota2);

    printf("Digite sua nota 3:\n");
    scanf("%f%*c", &nota3);

    media = (nota1+nota2+nota3)/3;

    if(media>=7){
        printf("O aluno %s matricula %d foi aprovado media=%.2f\n", nome, matricula, media);
    }else{
        printf("O aluno %s matricula %d foi reprovado media=%.2f\n", nome, matricula, media);
    }
    }
    return 0;
}
