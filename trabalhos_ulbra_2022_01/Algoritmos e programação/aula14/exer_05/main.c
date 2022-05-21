#include <stdio.h>
#include <stdlib.h>

int main()
{
    int x,soma,f;
    soma=0;
    f=10;
    for(x=1;x<f;x++){
        if(x%2==0){
            f=f-1;
        }
        soma=x+f;
        x++;
    }
    printf("Valor de x=%d\n", x);
    printf("Valor de soma=%d\n", soma);
    printf("Valor de f=%d\n", f);
    return 0;
}
