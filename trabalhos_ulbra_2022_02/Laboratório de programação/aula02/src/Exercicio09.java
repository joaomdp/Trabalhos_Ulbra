import java.util.Scanner;

public class Exercicio09 {
    public static void main(String[] args) {
        float valor_produto, valor_final;

        Scanner tc = new Scanner(System.in);
        System.out.println("Informe o valor do produto: ");
        valor_produto = tc.nextFloat();

        valor_final = valor_produto / 5;

        System.out.println("O produto no valor de "+valor_produto+ " dividido em 5 parcelar, fica: "+valor_final);
    }
}
