#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    float n1, n2, soma, raiz, op;

    printf("Menu\n\n");
    printf("1-Somar dois numeros\n");
    printf("2-Raiz quadrada de um numero\n");
    printf("Digite sua opcao: ");
    scanf("%f%*c", &op);

    if (op == 1){
        printf("Digite um valor para o primeiro numero: ");
        scanf("%f%*c", &n1);
        printf("Digite um valor para o segundo numero: ");
        scanf("%f%*c", &n2);
        soma = n1 + n2;
        printf("A soma dos dois numeros e: %.2f\n", soma);
    }
    if (op == 2){
        printf("Digite um valor: ");
        scanf("%f%*c", &n1);
        raiz = sqrt (n1);
        printf("A raiz quadrada do numero e: %.2f\n", raiz);
    }
    if (op!=1 && op!=2){
        printf("Opcao invalida");
    }
    return 0;
}
