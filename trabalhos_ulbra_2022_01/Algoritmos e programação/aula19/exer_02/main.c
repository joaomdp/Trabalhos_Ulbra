#include<stdio.h>
#include<string.h>

int main(){

    float notas1[10];
    float notas2[10];
    float medias[10];
    char nomes[10][15];
    char aprovados[10][10];
    char reprovados[10][10];
    int aprov = 0, reprov = 0;
    int cont = 0, op;
    int funcao, posicao, i=0;
    float compare;

    for(i=0;i<5;i++){
        printf("Digite a primeira nota: \n");
        scanf("%f%*c", &notas1[i]);
        printf("Digite a segunda nota: \n");
        scanf("%f%*c", &notas2[i]);

        medias[i] = (notas1[i]+notas2[i])/2;

        printf("Digite o nome do aluno:\n");
        gets(nomes[i]);

        if(medias[i]>=6){
            strcpy(aprovados[aprov], nomes[i]);
            aprov++;
        }else{
            strcpy(reprovados[reprov], nomes[i]);
            reprov++;
        }
        printf("Digite:\n 1-Para adicionar novos alunos. \n 2-Ir para a proxima parte.\n");
        scanf("%d%*c", &op);

        if(op==2){
            break;
        }
        cont++;
    }
    do{
        printf("\n\nDigite:\n 1-Listar todos os alunos aprovados. \n 2-Listar todos os alunos reprovados. \n 3-Listar todos os alunos com a nota maior que a nota informada pelo usuario. \n 4-Informar uma posicao e o programa exibir os dados do aluno. \n 5-Encerrar o programa. \n");
        scanf("%d%*c", &funcao);
        switch(funcao){
        case 1:
            for(i=0;i<aprov;i++){
                printf("Aluno %s aprovado.\n", aprovados[i]);
            }
        break;
        case 2:
            for(i=0;i<reprov;i++){
                printf("Aluno %s reprovado.\n", reprovados[i]);
            }
        break;
        case 3:
            printf("Digite a nota de comparacao: \n");
            scanf("%f%*c", &compare);
            for(i=0;i<cont;i++){
                if(medias[i]>compare){
                    printf("O aluno %s tem a nota maior que o comparativo.\n", nomes[i]);
                }
            }
        break;
        case 4:
            printf("Digite a posicao desejada: \n");
            scanf("%d%*c", &posicao);
            if(posicao<=cont){
                printf("O aluno %s com a primara nota de %.2f com segunda nota de %.2f com media de %.2f.\n", nomes[posicao], notas1[posicao], notas2[posicao], medias[posicao]);
            }else{
                printf("Posicao invalida");
            }
        break;
        }
    }while(funcao!=5);
}
