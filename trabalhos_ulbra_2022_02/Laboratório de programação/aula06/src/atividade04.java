import java.util.Scanner;

public class atividade04 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        double[] vetorA = new double[3];
        double[] vetorB = new double[vetorA.length];

        for(int i=0;i<vetorA.length;i++){
            System.out.println("Entrar com um valor na posicao: "+i);
            vetorA[i] = scan.nextDouble();
            vetorB[i] = Math.sqrt(vetorA[i]);
        }

        System.out.println("Vetor A =");

        for (int i=0; i< vetorA.length;i++){
            System.out.println(vetorA[i]+"");
        }

        System.out.println();

        System.out.println("Valores da raiz quadrada de cada elemento =");
        for (int i=0;i< vetorB.length;i++){
            System.out.println(vetorB[i]);
        }
    }
}
