#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1, num2, num3;

    printf("Digite o primeiro numero: ");
    scanf("%d%*c", &num1);

    printf("Digite o segundo numero: ");
    scanf("%d%*c", &num2);

    printf("Digite o terceiro numero: ");
    scanf("%d%*c", &num3);

    if  (num1 < num2 && num1 < num3 )
    if  (num2 < num3){
        printf("A ordem crescente e: %d -", num1);
        printf("%d -", num2);
        printf("%d\n", num3);
    }else {
        printf("A ordem crescente e: %d -", num1);
        printf("%d -", num3);
        printf("%d\n", num2);
    }

    if  (num2 < num1 && num2 < num3 )
    if  (num1 < num3){
        printf("A ordem crescente e: %d -", num2);
        printf("%d -", num1);
        printf("%d\n", num3);
    }else {
        printf("A ordem crescente e: %d -", num2);
        printf("%d -", num3);
        printf("%d\n", num1);
    }

    if  (num3 < num1 && num3 < num2 )
    if  (num1 < num2){
        printf("A ordem crescente e: %d -", num3);
        printf("%d -", num1);
        printf("%d\n", num2);
    }else {
        printf("A ordem crescente e: %d -", num3);
        printf("%d -", num2);
        printf("%d\n", num1);
    }



    return 0;
}
