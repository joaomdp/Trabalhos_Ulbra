#include <stdio.h>
#include <stdlib.h>

int main()
{
   float sal, novoSal, novoSal2, novoSal3, novoSal4, novoSal5, novoSal6;

    printf("Digite o seu salario atual: ");
    scanf("%f%*c", &sal);

    novoSal = (sal*50/100) + sal;

    novoSal2 = (sal*40/100) + sal;

    novoSal3 = (sal*30/100) + sal;

    novoSal4 = (sal*20/100) + sal;

    novoSal5 = (sal*10/100) + sal;

    novoSal6 = (sal*5/100) + sal;

    if (sal<=300){
        printf("O salario novo e: %.2f", novoSal);
    }else if ((sal>300) && (sal<=500)){
        printf("O salario novo e: %.2f", novoSal2);
    }else if (sal>500 && sal<=700){
        printf("O seu novo salario e: %.2f", novoSal3);
    }else if (sal>700 && sal<=800){
        printf("O seu novo salario e: %.2f", novoSal4);
    }else if (sal>800 && sal<=1000){
        printf("O seu novo salario e: %.2f", novoSal5);
    }else if (sal>1000){
        printf("O seu novo salario e: %.2f", novoSal6);
    }
    return 0;
}
