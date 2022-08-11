import java.util.Scanner;

public class Exercicio10 {
    public static void main(String[] args) {
        float preco_custo,valor_venda, percentual;

        Scanner tc = new Scanner(System.in);
        System.out.println("Informe o valor do produto: ");
        preco_custo = tc.nextFloat();
        System.out.println("Informe o percentual: ");
        percentual = tc.nextFloat();

        valor_venda = (preco_custo * percentual/100) + preco_custo;

        System.out.println("O valor final do produto e: "+valor_venda);
    }
}
