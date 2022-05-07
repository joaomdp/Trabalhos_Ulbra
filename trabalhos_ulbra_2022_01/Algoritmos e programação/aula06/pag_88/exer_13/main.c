#include <stdio.h>
#include <stdlib.h>

int main()
{
    float valor_produto, valor_final, valor_final2, valor_final3;

    printf("Digite o valor do produto: ");
    scanf("%f%*c", &valor_produto);

    valor_final = valor_produto * 5/100 + valor_produto;
    valor_final2 = valor_produto * 10/100 + valor_produto;
    valor_final3 = valor_produto * 15/100 + valor_produto;

    if (valor_produto<=50){
        printf("O novo valor do produto e: %.2f", valor_final);
    }else if (valor_produto>51 && valor_produto<100){
        printf("O novo valor do produto e: %.2f", valor_final2);
    }else{
        printf("O novo valor do produto e: %.2f", valor_final3);
    }
    if (valor_final, valor_final2, valor_final3<=80){
        printf("|Barato");
    }else if (valor_final, valor_final2, valor_final3>81 && valor_final, valor_final2, valor_final3<=120){
        printf("|Normal");
    }else if (valor_final, valor_final2, valor_final3>121 && valor_final, valor_final2, valor_final3<=200){
        printf("|Caro");
    }else if (valor_final, valor_final2, valor_final3>200){
        printf("|Muito caro");
    }

    return 0;
    }
