#include <stdio.h>
#include <stdlib.h>

float main()
{
    int n1, n2;
    float div;
    char opcao;

    do{
        printf("Digite o valor de 1: ");
        scanf("%f%*c", &n1);
        do{
            printf("Digite o valor de 2: ");
            scanf("%f%*c", &n2);
                if(n2==0){
                    printf("Valor invalido\n");
    }
    }while (n2==0);
        div=n1/n2;
        printf("A divisao e %.2f\n", div);
        printf("Deseja efetuar um novo calculo? [s/n]\n");
        scanf("%c%*c", &opcao);

    }while((opcao=='s')||(opcao=='S'));

    return 0;
}
