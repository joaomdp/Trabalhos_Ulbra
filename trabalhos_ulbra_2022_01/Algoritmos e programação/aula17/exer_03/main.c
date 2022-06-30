#include <stdio.h>
#include <stdlib.h>
#include<string.h>
int main()
{
    //FUP que leia 3 strings e escreva em ordem alfabética
    char letra[2];
    int i;
    for(i=0;i<3;i++){
        printf("Digite a %d letra:\n", i+1);
        scanf("%s%*c", &letra[i]);
    }
    for(i=0;i<3;i++){
        if(letra[i>letra[i]){
            printf("%s\n%s\n%s", letra[i]);
        }
    }
    return 0;
}
