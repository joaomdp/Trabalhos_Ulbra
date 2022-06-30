#include <stdio.h>
#include <stdlib.h>

int main()
{
    int opcao,i;
    float valor[5];

    for(i=0;i<5;i++){
        printf("Digite o %d valor:\n", i+1);
        scanf("%f%*c", &valor[i]);
    }
    do {
        printf("Digite o codigo desejado:\n 0- Fechar programa \n 1- Mostre o vetor na ordem direta \n 2- Mostre o vetor na ordem inversa \n");
        scanf("%d%*c", &opcao);
        switch(opcao){
        case 0:
            printf("Programa finalizado\n");
            break;
        case 1:
            for(i=0;i<5;i++){
                printf("%.1f", valor[i]);
            }
            printf("\n");
            break;
        case 2:
            for(i=4;i>=0;i--){
                printf("%.1f", valor[i]);
            }
            printf("\n");
            break;
            default:
            printf("Opcao invalida\n");
        }
    }while (opcao != 0);
    return 0;
}
