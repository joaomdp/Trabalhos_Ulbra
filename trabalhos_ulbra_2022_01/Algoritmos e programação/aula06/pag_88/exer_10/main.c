#include <stdio.h>
#include <stdlib.h>

int main()
{
    float pFabr, pFinal, pFinal2, pFinal3;

    printf("Digite o preco de fabrica: ");
    scanf("%f%*c", &pFabr);

    pFinal = (pFabr * 5/100) + pFabr;
    pFinal2 = (pFabr * 10/100)  + (pFabr * 15/100) + pFabr ;
    pFinal3 = (pFabr * 15/100)  + (pFabr * 20/100) + pFabr ;

    if (pFabr <= 12000){
        printf("O valor final e: %.2f\n", pFinal);
    }else if (pFabr >1200 && pFabr <25000){
        printf("O valor final e: %.2f\n", pFinal2);
    }else if (pFabr >25000){
        printf("O valor final e: %.2f\n", pFinal3);
    }


    return 0;
}
