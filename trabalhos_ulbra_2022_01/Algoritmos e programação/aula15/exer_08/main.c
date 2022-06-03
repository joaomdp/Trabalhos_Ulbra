#include <stdio.h>
#include <stdlib.h>

int main()
{
    //8. Crie um programa que lê 6 valores inteiros e, em seguida, mostre na tela os valores lidos ˆ na ordem inversa.
    int valores[6];
    int i;

    for(i=0;i<6;i++){
        printf("Digite um valor: ");
        scanf("%d%*c", &valores[i]);
    }
    printf("Resultado\n");
    for(i=5;i>=0;i--){
        printf("%d\n", valores[i]);
    }
    return 0;
}
