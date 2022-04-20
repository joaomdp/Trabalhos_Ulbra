#include <stdio.h>
#include <stdlib.h>

int main()
{
    int numero1, numero2, op, media, dif, prod, div;

    printf("Digite um numero inteiro: ");
    scanf("%d%*c", &numero1);

    printf("Digite outro numero inteiro: ");
    scanf("%d%*c", &numero2);

    printf("1- Media dos numeros\n");
    printf("2- Diferenca dos numeros\n");
    printf("3- Produto dos numeros\n");
    printf("4- Divisao dos numeros(o numero 2 deve ser maior que o numero 1)\n");
    printf("Digite qual operacao deseja:\n ");
    scanf("%d", &op);

    media = (numero1+ numero2)/2;
    dif =  numero1 - numero2;
    prod = numero1 * numero2;
    div = numero1 / numero2;

    if (op==1){
        printf("A media dos valores: %d", media);
    }else if (op==2){
        printf("A diferenca do maior para o menor: %d", dif);
    }else if (op==3){
        printf("O produto entre os numeros: %d ", prod);
    }else if (op==4){
        printf("A divisao do primeiro numero pelo segundo: %d", div);
    }else {
        printf("opcao invalida");
    }

    return 0;
}
