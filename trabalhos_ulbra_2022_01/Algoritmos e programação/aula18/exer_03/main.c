#include <stdio.h>
#include <conio.h>

int main(){

    int a=0,i,j,w,flag;
    int valor[10],iguais[10];

    for(i=0;i<10;i++){
        printf("Entre com o elemento[ %d ] : ",i+1);
        scanf("%d",&valor[i]);
    }
    for(i=0; i<10; i++){
        for(j=0; j<10; j++){
            flag=0;
            if(valor[i]==valor[j] && i != j){
                for(w=0; w<10; w++){
                    if(iguais[w] == valor[j])
                        flag=1;
                }
                if(flag==0){
                    iguais[a]=valor[i];
                    a++;
                }
            }
        }
     }
     for(i=0; i<a; i++){
        printf("%d - %d sao iguais\n",iguais[i], iguais[i]);
     }
     return 0;
}
