import java.util.Random;
public class Matriz {

    private static int[][] matriz = new int[100][100];

    public static void main(String[] args) {
        gerarMatriz();
        mostrarMatriz();

        System.out.println("Padrões encontrados:");
        encontrarPadroes("01");
        encontrarPadroes("11");
        encontrarPadroes("00");
        encontrarPadroes("10");
    }

    private static void gerarMatriz() {
        Random random = new Random();
        for (int i = 0; i < 100; i++) {
            for (int j = 0; j < 100; j++) {
                matriz[i][j] = random.nextInt(2);
            }
        }
    }

    private static void mostrarMatriz() {
        for (int i = 0; i < 100; i++) {
            for (int j = 0; j < 100; j++) {
                System.out.print(matriz[i][j] + " ");
            }
            System.out.println();
        }
    }

    private static void encontrarPadroes(String pattern) {
        int count = 0;
        long iniciarTimer = System.currentTimeMillis();
        for (int i = 0; i < 100; i++) {
            for (int j = 0; j < 100 - pattern.length() + 1; j++) {
                String sub = "";
                for (int k = 0; k < pattern.length(); k++) {
                    sub += Integer.toString(matriz[i][j + k]);
                }
                if (sub.equals(pattern)) {
                    count++;
                }
            }
        }
        System.out.println("Padrão " + pattern + ": " + count + " vezes");
    }
}


