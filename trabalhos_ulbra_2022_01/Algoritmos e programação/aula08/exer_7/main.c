#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i;
    float a, b, c;

    printf("Digite um numero: ");
    scanf("%f%*c", &a);

    printf("Digite outro numero: ");
    scanf("%f%*c", &b);

    printf("Digite outro numero: ");
    scanf("%f%*c", &c);

    printf("1- Mostre os numeros em ordem crescente\n");
    printf("2- Mostre os numeros em ordem decrescente\n");
    printf("3- O maior numero fica no meio\n");
    scanf("%d%*c", &i);

    float maior, menor, meio;

    if (a>b && a>c){
        maior=a;
        if (b>c){
            meio=b;
            menor=c;
        }else{
            meio=c;
            menor=b;
        }
    }else if (b>a && b>c){
        maior=b;
        if (a>c){
            meio=a;
            menor=c;
        }else{
            meio=c;
            menor=a;
        }
    }else {
        maior=c;
        if (a>b){
            meio=a;
            menor=b;
        }else{
            meio=b;
            menor=a;
        }
    }
    switch(i){
    case 1:
        printf("Os numeros em ordem crescente: %.2f %.2f %.2f\n", menor, meio, maior);
        break;
    case 2:
        printf("Os numeros em ordem decrescente: %.2f %.2f %.2f\n", maior, meio, menor);
        break;
    case 3:
        printf("O maior numero fica no meio: %.2f %.2f %.2f\n", meio, maior, menor);
        break;

    default:
        printf("Os numeros sao iguais");
        break;
    }
    return 0;
}
