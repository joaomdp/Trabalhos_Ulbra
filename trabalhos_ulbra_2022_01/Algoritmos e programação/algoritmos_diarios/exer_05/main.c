#include <stdio.h>
#include <stdlib.h>
#include<locale.h>
int main()
{
    setlocale(LC_ALL, "portuguese");

    int n1, n2, n3, n4, valorFinal;

    printf("Insira qualquer n�mero inteiro: ");
    scanf("%d", &n1);

    printf("Insira outro n�mero inteiro: ");
    scanf("%d", &n2);

    printf("Insira outro n�mero inteiro: ");
    scanf("%d", &n3);

    printf("Insira outro n�mero inteiro: ");
    scanf("%d", &n4);

    if (n1>n2 && n1>n3 && n1>n4){
       valorFinal = n2 + n3 + n4;
       printf("Os tr�s menores n�meros s�o: %d - %d - %d\n", n2, n3, n4);
       printf("O valor da soma dos tr�s menores n�meros �: %d", valorFinal);
    }else if (n2>n1 && n2>n3 && n2>n4){
        valorFinal = n1 + n3 + n4;
        printf("Os tr�s menores n�meros s�o: %d - %d - %d\n", n1, n3, n4);
        printf("O valor da soma dos tr�s menores n�meros �: %d", valorFinal);
    }else if (n3>n1 && n3>n2 && n3>n4){
        valorFinal = n1 + n2 + n4;
        printf("Os tr�s menores n�meros s�o: %d - %d - %d\n", n1, n2, n4);
        printf("O valor da soma dos tr�s menores n�meros �: %d", valorFinal);
    }else if (n4>n1 && n4>n2 && n4>n3){
        valorFinal = n1 + n2 + n3;
        printf("Os tr�s menores n�meros s�o: %d - %d - %d\n", n1, n2, n3);
        printf("O valor da soma dos tr�s menores n�meros �: %d", valorFinal);
    }else {
        printf("Valor inv�lido");
    }
    return 0;
}
