#include <stdio.h>
#include <stdlib.h>

int main()
{
    int A[]={1,0,5,-2,-5,7};
    int soma;
    soma=A[0]+A[1]+A[5];
    printf("A soma e : %d\n", soma);
    A[4]=100;
    int i;
    for(i=0;i<6;i++){
     printf("O valor e: %d\n", A[i]);
    }
    return 0;
}
