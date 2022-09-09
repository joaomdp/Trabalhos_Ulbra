import java.util.Scanner;

public class atividade02 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] vetorA = new int[8];
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

        System.out.println("Valores multiplicados =");
        for (int i=0;i< vetorB.length;i++){
            int [] multi = new int[vetorB.length];
            multi[i] = vetorB[i] * 2;
            System.out.println(multi[i]+"");
        }
    }
}
