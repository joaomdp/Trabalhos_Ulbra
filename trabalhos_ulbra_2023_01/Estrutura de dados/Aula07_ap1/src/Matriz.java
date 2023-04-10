import java.util.Random;
import java.util.Scanner;

public class Matriz {
    private static int[][] matrix;
    private static int matrixSize;
    private static String[] patterns;
    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.print("Digite o tamanho da matriz (exemplo: 100): ");
        matrixSize = scanner.nextInt();

        System.out.print("Digite a quantidade de padrões que deseja encontrar (exemplo: 2): ");
        int numPatterns = scanner.nextInt();

        patterns = new String[numPatterns];
        for (int i = 0; i < numPatterns; i++) {
            System.out.print("Digite o padrão " + (i+1) + " que deseja encontrar (exemplo: 01): ");
            patterns[i] = scanner.next();
        }

        generateMatrix();
        printMatrix();

        System.out.println("Procurando padrões...");
        for (String pattern : patterns) {
            findPattern(pattern);
        }

        scanner.close();
    }

    private static void generateMatrix() {
        matrix = new int[matrixSize][matrixSize];
        Random random = new Random();
        for (int i = 0; i < matrixSize; i++) {
            for (int j = 0; j < matrixSize; j++) {
                matrix[i][j] = random.nextInt(2);
            }
        }
    }

    private static void printMatrix() {
        for (int i = 0; i < matrixSize; i++) {
            for (int j = 0; j < matrixSize; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }
    }

    private static void findPattern(String pattern) {
        int count = 0;
        long startTime = System.currentTimeMillis();
        for (int i = 0; i < matrixSize; i++) {
            for (int j = 0; j < matrixSize - pattern.length() + 1; j++) {
                String sub = "";
                for (int k = 0; k < pattern.length(); k++) {
                    sub += Integer.toString(matrix[i][j + k]);
                }
                if (sub.equals(pattern)) {
                    count++;
                }
            }
        }
        long endTime = System.currentTimeMillis();
        long duration = endTime - startTime;
        System.out.println("Padrão " + pattern + ": " + count + " vezes, tempo: " + duration + "ms");
    }
}
