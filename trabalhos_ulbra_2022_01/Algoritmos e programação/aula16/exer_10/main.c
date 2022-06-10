#include <stdio.h>
#include <stdlib.h>

int main()
{
    int tamanho=5;
    char produto[tamanho];
    float preco[tamanho],soma=0,media=0;
    int quant1,quant2,i;

    for(i=0;i<tamanho;i++){
        printf("Digite o %d produto:\n",i+1);
        scanf("%s%*c", &produto[i]);
        printf("Digite o preco do %d produto:\n",i+1);
        scanf("%d%*c",&preco[i]);
    }
    quant1=0;
    for(i=0;i<tamanho;i++){
        if(preco[i]<50){
            quant1=quant1+1;
        }
    }
    printf("A quantidade de produtos menores que R$50,00 e: %d\n\n",quant1);

    printf("Relatorio dos produtos com preco entre R$50,00 e R$100,00\n");
    for(i=0;i<tamanho;i++){
        if(preco[i]>50 && preco[i]<100){
            printf("%s",produto[i]);
        }
    }
    soma=0;
    quant2=0;
    for(i=0;i<tamanho;i++){
        if(preco[i]>100){
            soma=preco[i]+soma;
            quant2=quant2+1;
        }
    }
    media=soma/quant2;
    printf("A media dos precos superiores a R$100,00 e: %.2f\n", media);
    return 0;
}
