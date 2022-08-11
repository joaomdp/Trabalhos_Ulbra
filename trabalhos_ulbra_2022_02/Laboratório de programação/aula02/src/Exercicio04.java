import java.util.Scanner;

public class Exercicio04 {
    public static void main(String[] args) {
        int num1, num2, soma;

        Scanner tc = new Scanner(System.in);
        System.out.println("Digite um numero");
        num1 = tc.nextInt();

        System.out.println("Digite outro numero");
        num2 = tc.nextInt();

        soma = num1 + num2;

        System.out.println("A soma dos dois numeros e: "+soma);
    }
}
