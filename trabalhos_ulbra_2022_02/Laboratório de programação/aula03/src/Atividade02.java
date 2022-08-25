import java.text.NumberFormat;
import java.util.Locale;
import java.util.Scanner;

public class Atividade02 {
    public static void main(String[] args) {
        float valor_produto, novo_valor;
        int opcao;

        do {
            Scanner tc = new Scanner(System.in);
            System.out.println("Insira o valor do produto:");
            valor_produto = tc.nextFloat();

            novo_valor = valor_produto * 12 / 100  + valor_produto;

            NumberFormat nf1 = NumberFormat.getCurrencyInstance(new Locale("pt","BR"));
            System.out.println("O valor do produto com acressimo de 12% e: ");
            System.out.println((nf1.format(Math.round(novo_valor))));

            System.out.println("Deseja ajustar mais algum produto? \n (1-SIM 0-NAO)");
            opcao = tc.nextInt();

        }while (opcao!=0);

        System.out.println("Programa encerrado!!");

    }
}
