#include <stdio.h>
#include <stdlib.h>

int main()
{
    for(int i=1000;i<1500;i++){
        if(i%2!=0){
            printf("Numero impar: %d\n", i);
        }
    }

    return 0;
}
