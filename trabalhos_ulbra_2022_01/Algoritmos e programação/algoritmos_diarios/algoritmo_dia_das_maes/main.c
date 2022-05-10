#include <stdio.h>
#include <stdlib.h>
#include<locale.h>
int main()
{
    float valor, dif;
    int irmao;

    setlocale(LC_ALL, "portuguese");

    printf("Digite o valor do presente: ");
    scanf("%f%*c", &valor);

    printf("Informe em quantos irmãos será dividido: ");
    scanf("%d%*c", &irmao);

    dif = valor / irmao;

    printf("O valor pago por cada irmão será %.2f\n", dif);
    printf("Um feliz dia das mães\n");
    return 0;
}
