#include <stdio.h>
#include <stdlib.h>

int main()
{
    float baseMaior, baseMenor, altura, area;
    printf("Digite o valor da base maior do trapezio: ");
    scanf("%f%*c", &baseMaior);

    printf("Digite o valor da base menor do trapezio: ");
    scanf("%f%*c", &baseMenor);

    printf("Digite a altura do trapezio: ");
    scanf("%f%*c", &altura);

    area = ((baseMaior+baseMenor)* altura)/2;
    printf("O resultado da area desse trapezio e: %.2f\n", area);
    return 0;
}
