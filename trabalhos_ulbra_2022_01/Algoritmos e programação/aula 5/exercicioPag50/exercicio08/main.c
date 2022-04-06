#include <stdio.h>
#include <stdlib.h>

int main()
{
    float quilo, gramas;
    printf("Digite o seu peso em quilos: ");
    scanf("%f%*c", &quilo);
    gramas = quilo * 1000;
    printf("O seu peso em gramas e: %.2f\n", gramas);
    return 0;
}
