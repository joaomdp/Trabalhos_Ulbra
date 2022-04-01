#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1, n2;
    float r1, r2;

    printf("Digite o valor de n1: ");
    scanf("%d", &n1);

    printf("Digite o valor de n2: ");
    scanf("%d", &n2);

    r1 = pow(n1, n2);
    r2 = pow(n2, n1);

    printf("O valor de n1: %.0f\n", r1);
    printf("O valor de n2: %.0f\n", r2);

    return 0;
}
