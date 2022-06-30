#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main () {

int valor[10];
int i, x, ja_consta, j;

srand (time(NULL));

for (i=0; i<10; i++) {
    valor[i] = rand() % 10 + 1;
do {
    ja_consta = 1;
for (j=0; j<i; j++)
if (valor[i] == valor[j]) {

valor[i] = rand() % 10 + 1;

ja_consta = 0;
}
} while (ja_consta == 0);
}

printf("Informe um numero entre 1 e 10: ");
scanf("%d", &x);
i=0;

while ((i<10) && (valor[i] != x))
    i++;
if (i < 10)
    printf("%d encontra-se na posicao %d do vetor\n", x, i);
else
    printf("%d nao existe no vetor\n", x);

return 0;
}
