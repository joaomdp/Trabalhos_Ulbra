#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1, num2;

    do {
        printf("Digite um valor: \n");
        scanf("%d", &num1);

        printf("Digite outro valor: \n");
        scanf("%d", &num2);

        if (num1 > num2) {
        printf("%d --- %d --- Decrescente\n\n", num1, num2);
        } else if (num1 < num2) {
        printf("%d --- %d --- Crescente\n\n", num1, num2);
        } else {
        printf("%d --- %d\n\n", num1, num2);
        }
}    while (num1 != num2);
    return 0;
}
