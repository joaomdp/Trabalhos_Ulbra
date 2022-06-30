#include <stdio.h>
#include <math.h>
#include <string.h>

int main()
{

    char palavra[20];
    int contador, numVogais = 0;

    printf("Digite uma palavra: \n");
    scanf("%s",&palavra);

    for(contador=0; contador < palavra[contador]; contador++){

    if (palavra[contador]== 'A' || palavra[contador]== 'E'  || palavra[contador]== 'I' || palavra[contador]== 'O' || palavra[contador]== 'U' || palavra[contador]== 'a' || palavra[contador]== 'e'  || palavra[contador]== 'i' || palavra[contador]== 'o' || palavra[contador]== 'u'){
        numVogais++;
    }
    }

    printf("Numeros de vogais de %s: %d\n",palavra,numVogais);
    printf("A palavra %s possui %d letras",palavra, contador);
    return 0;
}

