import java.util.Random;
import java.util.Scanner;

public class Matriz {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o tamanho da matriz: ");
        int tamanhoMatriz = scanner.nextInt();

        int[][] matriz = new int[tamanhoMatriz][tamanhoMatriz];
        Random random = new Random();
        for (int i = 0; i < tamanhoMatriz; i++) {
            for (int j = 0; j < tamanhoMatriz; j++) {
                matriz[i][j] = random.nextInt(2);
            }
        }

        for (int i = 0; i < tamanhoMatriz; i++) {
            for (int j = 0; j < tamanhoMatriz; j++) {
                System.out.print(matriz[i][j] + " ");
            }
            System.out.println();
        }

        int contagem00 = 0;
        int contagem01 = 0;
        int contagem10 = 0;
        int contagem11 = 0;

        long iniciarTimer = System.currentTimeMillis();

        for (int i = 0; i < tamanhoMatriz - 1; i++) {
            for (int j = 0; j < tamanhoMatriz - 1; j++) {
                if (matriz[i][j] == 0 && matriz[i][j + 1] == 0 && matriz[i + 1][j] == 0 && matriz[i + 1][j + 1] == 0) {
                    contagem00++;
                } else if (matriz[i][j] == 0 && matriz[i][j + 1] == 0 && matriz[i + 1][j] == 1 && matriz[i + 1][j + 1] == 0) {
                    contagem01++;
                } else if (matriz[i][j] == 1 && matriz[i][j + 1] == 0 && matriz[i + 1][j] == 0 && matriz[i + 1][j + 1] == 1) {
                    contagem10++;
                } else if (matriz[i][j] == 1 && matriz[i][j + 1] == 1 && matriz[i + 1][j] == 1 && matriz[i + 1][j + 1] == 1) {
                    contagem11++;
                }
            }
        }

        long fimTimer = System.currentTimeMillis();
        long tempoDeExecucao = fimTimer - iniciarTimer;

        System.out.println("Padrão (00) encontrado " + contagem00 + " vezes.");
        System.out.println("Padrão (01) encontrado " + contagem01 + " vezes.");
        System.out.println("Padrão (10) encontrado " + contagem10 + " vezes.");
        System.out.println("Padrão (11) encontrado " + contagem11 + " vezes.");
        System.out.println("Tempo necessário para encontrar todos os padrões: "+ tempoDeExecucao + " ms");
    }
}