#include <stdio.h>
#include <stdlib.h>

int main()
{
    int senha, cont, correta;
    correta = 1234;

    for (cont=0;cont!=correta;cont++){
        printf("Digite a senha: ");
        scanf("%d", &senha);
        if (senha==correta){
            printf("Acesso permitido\n\n");
            printf("Numeros de tentativas: %d", cont);
            break;
        }else{
            printf("Acesso negado\n\n");
        }
    }
    return 0;
}
