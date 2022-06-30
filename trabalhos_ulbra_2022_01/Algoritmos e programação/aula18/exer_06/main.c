#include<stdio.h>

int main(){

int valor1[10], valor2[10], i, x;

do{
    printf("Insira um valor: \n");
    scanf("%d",&valor1[i]);
    valor2[i]=valor1[i];

}while(i=0);

for(i=1; i<=9; i++){

    printf("Insira um valor: \n");
    scanf("%d",&valor1[i]);

for(x=0; x<10; x++){

if(valor2[x]==valor1[i]){

    printf("Esse numero ja foi digitado anteriormente.\n");
    printf("Por favor, digite outro numero: \n");
    scanf("%d",&valor1[i]);
}

if(valor2[x]==valor1[i]){

    printf("Esse numero ja foi digitado anteriormente.\n");
    printf("Por favor, digite outro numero: \n");
    scanf("%d",&valor1[i]);
}

    valor2[x]=valor1[i];

}

}

printf("Valores presentes no vetor:\n");

for(i=0; i<10; i++){

printf("%d\n",valor1[i]);

}
return 0;
}
