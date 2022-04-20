#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, novoSal;

    printf("Digite o seu salario: ");
    scanf("%f%*c", &sal);

    novoSal = sal * 30/100 + sal;

    if ( sal <= 500 ){
        printf("Seu novo salario e: %.2f", novoSal);
    }else {
        printf("Voce nao tem direito a aumento");
    }
    return 0;
}
