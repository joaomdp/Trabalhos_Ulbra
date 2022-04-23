#include<stdio.h>

#include<stdlib.h>


int main(){

int i;
float a,b,c;

printf("Digite 1,2 ou 3 para I:\n");

scanf("%d",&i);

printf("Digite tres valores distintos para A,B e C:\n");

scanf("%f%f%f",&a,&b,&c);

if(i==1)

{

    if(a<b && a<c)

        if(b<c)

        printf("Os valores em ordem crescente sao: %.2f – %.2f – %.2f.\n",a,b,c);

        else

        printf("Os valores em ordem crescente sao: %.2f – %.2f – %.2f.\n",a,c,b);

        if(b<a && b<c)

        if(a<c)

        printf("Os valores em ordem crescente sao: %.2f – %.2f – %.2f.\n",b,a,c);

        else

        printf("Os valores em ordem crescente sao: %.2f – %.2f – %.2f.\n",b,c,a);

        if(c<a && c<b)

            if(a<b)

            printf("Os valores em ordem crescente sao: %.2f – %.2f – %.2f.\n",c,a,b);

            else

            printf("Os valores em ordem crescente sao: %.2f – %.2f – %.2f.\n",c,b,a);

}

if(i==2)

{

    if(a>b && a>c)

        if(b>c)

        printf("Os valores em ordem decrescente sao: %.2f – %.2f – %.2f.\n",a,b,c);

        else

        printf("Os valores em ordem decrescente sao:  %.2f – %.2f – %.2f.\n",a,c,b);

            if(b>a && b>c)

                if(a>c)

                printf("Os valores em ordem decrescente sao:  %.2f – %.2f – %.2f.\n",b,a,c);

                else

                printf("Os valores em ordem decrescente sao:  %.2f – %.2f – %.2f.\n",b,c,a);

                    if(c>a && c>b)

                        if(a>b)

                        printf("Os valores em ordem decrescente sao:  %.2f – %.2f – %.2f.\n",c,a,b);

                        else

                        printf("Os valores em ordem decrescente sao:  %.2f – %.2f – %.2f.\n",c,b,a);

}

{

    if(i==3)

        {

            if(a>b && a>c)

            printf("A ordem desejada e %.2f – %.2f – %.2f.\n:", b,a,c);

                if(b>a && b>c)

                printf("A ordem desejada e %.2f – %.2f – %.2f.\n", a,b,c);

                    if(c>a && c>b)

                    printf("A ordem desejada e %.2f – %.2f – %.2f.\n", a,c,b);

        }

}

system("pause");

return 0;

}
