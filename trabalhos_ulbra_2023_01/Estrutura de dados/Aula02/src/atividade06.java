import java.util.Random;

public class atividade06 {
    public static void main(String[] args) {
        int vetor[];
        vetor = new int[50];
        Random gerador = new Random();

        for (int i=0;i<50;i++){
            vetor[i] = gerador.nextInt(100);
            System.out.println(vetor[i]);
        }

    }
}
