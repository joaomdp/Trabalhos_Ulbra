#include <stdio.h>
#include <stdlib.h>

int main()
{
    float sal, novoSal, novoSal2, novoSal3;

    printf("Digite o seu salario atual: ");
    scanf("%f%*c", &sal);

    novoSal = (sal*15/100) + sal;

    novoSal2 = (sal*10/100) + sal;

    novoSal3 = (sal*5/100) + sal;

    if (sal<=300){
        printf("O salario novo e: %.2f", novoSal);
    }else if ((sal>300) && (sal<=600)){
        printf("O salario novo e: %.2f", novoSal2);
    }else if (sal>600 && sal<=900){
        printf("O seu novo salario e: %.2f", novoSal3);
    }else{
        printf("Voce nao possui aumento\n seu salario continua sendo: %.2f", sal);
    }
    return 0;
}
