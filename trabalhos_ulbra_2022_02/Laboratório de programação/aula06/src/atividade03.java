import java.util.Scanner;

public class atividade03 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] vetorA = new int[15];
        int[] vetorB = new int[vetorA.length];

        for(int i=0;i<vetorA.length;i++){
            System.out.println("Entrar com um valor na posicao: "+i);
            vetorA[i] = scan.nextInt();
            vetorB[i] = vetorA[i];
        }

        System.out.println("Vetor A =");

        for (int i=0; i< vetorA.length;i++){
            System.out.println(vetorA[i]+"");
        }

        System.out.println();

        System.out.println("Valores ao quadrado =");
        for (int i=0;i< vetorB.length;i++){
            int [] quad = new int[vetorB.length];
            quad[i] = vetorB[i] * vetorB[i];
            System.out.println(quad[i]+"");
        }
    }
}
