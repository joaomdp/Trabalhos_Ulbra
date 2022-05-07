#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1, n2, n3;
        printf("Digite tres numeros inteiros: ");
        scanf("%d %d %d", &n1, &n2, &n3);

        if  (n1 > n2  && n1 > n3) {
            printf("O maior numero e: %d", n1);
        }else if ((n2 > n1)&& (n2 >n3)){
             printf("O maior numero e: %d", n2);
        }else {
             printf("O maior numero e: %d", n3);
        }
    return 0;
}
