import java.util.Scanner;

public class Exercicio06 {
    public static void main(String[] args) {
        String nome = new String();
        float salario_fixo, total_vendas, comissao, salario_final;

        Scanner tc = new Scanner(System.in);
        System.out.println("Digite o seu nome(sem caracter especial): ");
        nome = tc.next();

        System.out.println("Digite o seu salario fixo: ");
        salario_fixo = tc.nextFloat();

        System.out.println("Digite o total de vendas no mes(em dinheiro)");
        total_vendas = tc.nextFloat();

        comissao = total_vendas * 15/100 + total_vendas;

        salario_final = comissao + salario_fixo;

        System.out.println("Nome: "+nome);
        System.out.println("Salario fixo: "+salario_fixo);
        System.out.println("Salario final do mes: "+salario_final);
    }
}
