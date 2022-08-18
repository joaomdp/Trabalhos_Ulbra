import java.util.Scanner;

public class Exercicio05 {
    public static void main(String[] args) {
        double km1, km2,TaxaDeConsumo, kmtotal, litros;
        Scanner tc = new Scanner(System.in);

        System.out.println("Informe o KM inicial: ");
        km1 = tc.nextFloat();
        System.out.println("Informe o KM final: ");
        km2 = tc.nextFloat();
        System.out.println("Informe a quantidade de litros consumidos: ");
        litros = tc.nextFloat();

        kmtotal = km1 - km2;

        TaxaDeConsumo = kmtotal/litros;
        System.out.println("O total percorrido foi de " +kmtotal + " Km");
        System.out.println("A taxa media de consumo e de " +TaxaDeConsumo +" Litros por Km percorridos");
    }
}
