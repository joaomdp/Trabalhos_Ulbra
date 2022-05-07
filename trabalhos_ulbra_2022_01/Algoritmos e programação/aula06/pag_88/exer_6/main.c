#include <stdio.h>
#include <stdlib.h>
#include <math.h>
int main()
{
      float numero1, numero2, op, elev, quad1, quad2, cub1, cub2;

    printf("Digite um numero inteiro: ");
    scanf("%f%*c", &numero1);

    printf("Digite outro numero inteiro: ");
    scanf("%f%*c", &numero2);

    printf("1- Primeiro numero elevado ao segundo\n");
    printf("2- Raiz quadrada de cada um dos numeros\n");
    printf("3- Raiz cubica de cada um dos numeros\n");
    printf("Digite qual operacao deseja:\n ");
    scanf("%f", &op);

    elev = pow (numero1, numero2);
    quad1 = sqrt (numero1);
    quad2 = sqrt (numero2);
    cub1 =  cbrt(numero1);
    cub2 = cbrt (numero2);
    if (op==1){
        printf("O numero 1 elevado ao numero 2: %.2f", elev);
    }else if (op==2){
        printf("A raiz quadrada de cada numero: %.2f %.2f", quad1, quad2);
    }else if (op==3){
        printf("A raiz cubica de cada numero: %.2f %.2f", cub1, cub2);
    }else {
        printf("opcao invalida");
    }
    return 0;
}
