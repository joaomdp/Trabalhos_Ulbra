#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, valorReceb, valorReceb2, valorReceb3, valorReceb4;

        printf("Digite o seu salario: ");
        scanf("%f%*c", &sal);

    valorReceb = sal - (sal*7/100) + 100 ;

    valorReceb2 = sal - (sal*7/100) + 75 ;

    valorReceb3 = sal -(sal*7/100) + 50 ;

    valorReceb4 = sal + 35;

if (sal<350){
    printf("O valor a receber e de: %.2f", valorReceb);
}else if (sal>350 && sal<=600){
    printf("O salario a receber e: %.2f", valorReceb2);
}else if (sal>=600 && sal<=900){
    printf("O salario a receber e: %.2f", valorReceb3);
}else {
    printf("O salario a receber e: %.2f", valorReceb4);
}

    return 0;
}
