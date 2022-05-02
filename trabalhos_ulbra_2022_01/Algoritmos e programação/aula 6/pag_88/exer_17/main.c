#include <stdio.h>
#include <stdlib.h>

int main()
{
    int senha;

    printf("Digite a senha correta: ");
    scanf("%d%*c", &senha);

    switch (senha){
        case 4531 :
        printf("Senha correta");
        break;

        default :
        printf("Senha incorreta");
    }
    return 0;
}
