import java.util.Scanner;

public class atividade01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String nomes[] = new String[5];
        double notas[]= new double[5];
        int cont = 0;
        double soma = 0, media =0;

        for (int i=0;i<5;i++){
            System.out.println("Digite seu nome: ");
            nomes[i] = sc.nextLine();
        }

        for (int i=0;i<5;i++){
            System.out.println("Digite sua nota: ");
            notas[i] = sc.nextDouble();
            if (soma >= 0) {
                soma = notas[i] + soma;
                cont++;
            }
            media = soma/cont;

            if (notas[i]>media){
                System.out.println(notas[i]);
            }
        }
    }
}
