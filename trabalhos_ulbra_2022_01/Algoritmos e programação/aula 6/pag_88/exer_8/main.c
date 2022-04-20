#include <stdio.h>
#include <stdlib.h>

int main()
{
     float sal, novoSal, novoSal2;

    printf("Digite o seu salario: ");
    scanf("%f%*c", &sal);

    novoSal = sal * 35/100 + sal;

    novoSal2 = sal * 15/100 + sal;
    if ( sal <= 300 ){
        printf("Seu novo salario e: %.2f", novoSal);
    }else if (sal > 300 ){
        printf("Seu novo salario e: %.2f", novoSal2);
    }
    return 0;
}
