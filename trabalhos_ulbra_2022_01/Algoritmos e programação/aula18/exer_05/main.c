#include <stdio.h>
#include <stdlib.h>

int main()
{
    int  A[10];
    int  B[10];
    int  C[10];
    int i;

    for(i=0;i<10;i++){
        printf("Digite o %d valor:\n", i+1);
        scanf("%d%*c", &A[i]);
    }
    for(i=0;i<10;i++){
        printf("Digite o %d valor:\n", i+1);
        scanf("%d%*c", &B[i]);
    }
    for(i=0;i<10;i++){
        C[i] = A[i] - B[i];
        printf("O resultado de %d - %d = %d\n", A[i], B[i], C[i]);
    }
    return 0;
}
