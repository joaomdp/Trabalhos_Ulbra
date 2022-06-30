#include <stdio.h>
#include <stdlib.h>
#include<time.h>
int main()
{
    int i=0, vetor[100], ordem,cont=0,cont9=0, maior=0;
    srand(time(NULL));
    for(i=0;i<100;i++){
        vetor[i]=rand()%1000;
        if(vetor[i]==999){
            cont9++;
            break;
        }
        if(vetor[i]>maior){
            maior=vetor[i];
        }
        cont++;
    }
    do{
       printf("Digite a opcao desejada:\n 1- Exibir a lista dos numeros. \n 2- Exiba o vetor na forma inversa. \n 3-Exibir o maior numero. \n 4-Exibir quantos numeros foram sorteado. \n 5-Encerrar o programa. \n");
       scanf("%d%*c", &ordem);
       switch(ordem){
            case 1:
            for(i=0;i<cont;i++){
                printf("%d\n", vetor[i]);
            }
            break;
            case 2:
            for(i=cont;i>=0;i--){
                printf("%d\n", vetor[i]);
            }
            break;
            case 3:
                printf("O maior numero e %d\n", maior);
            break;
            case 4:
                printf("foram gerados %d numeros\n", cont);
            break;
       }
    }while(ordem!=5);

    return 0;
}
