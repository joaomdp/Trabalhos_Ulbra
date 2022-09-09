import java.util.Scanner;

public class atividade09 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        double[] vetorA = new double[3];
        double[] vetorB = new double[3];
        double[] vetorC = new double[3];

        for(int i=0;i<vetorA.length;i++){
            System.out.println("Entrar com um valor do vetor A: "+i);
            vetorA[i] = scan.nextDouble();
        }

        System.out.println("Vetor A =");

        for (int i=0; i< vetorA.length;i++){
            System.out.println(vetorA[i]+"");
        }

        System.out.println();

        for(int i=0;i<vetorB.length;i++){
            System.out.println("Entrar com um valor do vetor B: "+i);
            vetorB[i] = scan.nextDouble();
        }
        System.out.println("Vetor B =");
        for (int i=0;i< vetorB.length;i++){
            System.out.println(vetorB[i]+"");
        }

        System.out.println("A divisao dos vetores A e B = ");
        for (int i=0;i<vetorC.length;i++){
            vetorC[i]= vetorA[i] / vetorB[i];
            System.out.println("A divisao e = "+vetorC[i]);
        }
    }
}
