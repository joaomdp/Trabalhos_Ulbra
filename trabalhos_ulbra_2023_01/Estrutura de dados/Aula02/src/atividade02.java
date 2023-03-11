import java.util.Scanner;

public class atividade02 {
    public static void main(String[] args) {
        int quantNotas;
        double media, soma = 0;
        double notas[];

        Scanner tc = new Scanner(System.in);

        System.out.println("Qual a quatidade de notas desejadas: ");
        quantNotas = tc.nextInt();
        notas = new double[quantNotas];

        for (int i=0;i<quantNotas;i++){
            System.out.println("Digite a nota " + (i+1));
            notas[i] = tc.nextDouble();
            soma = soma + notas[i];
        }
        media = soma/quantNotas;
        System.out.println("Notas maiores que a média: "+ media);
        for (int i=0;i<quantNotas;i++){
            if (notas[i]>media){
                System.out.println(notas[i]);
            }
        }
        System.out.println("Agora as notas inferiores a média: "+ media);
        for (int i=0;i<quantNotas;i++){
            if (notas[i]<media){
                System.out.println(notas[i]);
            }
        }

    }
}
