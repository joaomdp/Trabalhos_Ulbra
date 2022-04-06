#include <stdio.h>
#include <stdlib.h>

int main()
{
    float lado, area;
    printf("Digite o lado do quadrado: ");
    scanf("%f%*c", &lado);
    area = lado * lado;
    printf("A area do quadrado informado e: %.2f\n", area);
    return 0;
}
