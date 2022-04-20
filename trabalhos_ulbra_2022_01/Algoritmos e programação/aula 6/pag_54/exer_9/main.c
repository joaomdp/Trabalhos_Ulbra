#include <stdio.h>
#include <stdlib.h>
#include<time.h>
struct rgAgora{
    int dia, mes, ano;
    int h, m, s;
};

int main(){
    struct tm tempo;
    time_t tempoSeg;

    time (&tempoSeg);
    tempo = *localtime(&tempoSeg);

    struct rgAgora agora;

    agora.dia = tempo.tm_mday;
    agora.mes = tempo.tm_mon + 1;
    agora.ano = tempo.tm_year + 1900;
    agora.h = tempo.tm_hour;
    agora.m = tempo.tm_min;
    agora.s = tempo.tm_sec;

    printf("Hoje e %02d/%02d/%d as %02d:%02d:%02d horas. \n", agora.dia, agora.mes, agora.ano, agora.h, agora.m, agora.s);
    return 0;
}
