#include <stdio.h>
#include <stdlib.h>

int main()
{
    float valores[10], quadrado[10];

    for(int i=0;i<10;i++){
        printf("Informe um valor real\n");
        scanf("%f%*c", &valores[i]);
        quadrado[i]=valores[i]*valores[i];
        printf("%.1f e o seu quadrado e: %.1f\n", valores[i], quadrado[i]);

    }
    return 0;
}
