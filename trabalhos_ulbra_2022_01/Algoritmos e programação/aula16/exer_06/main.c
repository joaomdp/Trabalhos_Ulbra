#include <stdio.h>
#include <stdlib.h>

int main()
{
    int A[30], B[30], i;
    for(i=0;i<30;i++){
        if(A[i]==0){
            B[i]=1;
        }else{
            B[i]=A[i];
        }
    }
    for(i=0;i<30;i++){
        printf("A[%d]=%d\n", i,A[i]);
    }
    for(i=0;i<30;i++){
        printf("B[%d]=%d\n", i,B[i]);
    }
    return 0;
}
