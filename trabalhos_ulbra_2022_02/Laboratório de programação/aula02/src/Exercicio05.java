import java.util.Scanner;

public class Exercicio05 {
    public static void main(String[] args) {
        float distancia, combustivel,consumo_medio;

        Scanner tc = new Scanner(System.in);
        System.out.println("Digite a distancia total percorrida: ");
        distancia = tc.nextFloat();
        System.out.println("Digite o total de combustivel gasto: ");
        combustivel = tc.nextFloat();

        consumo_medio = distancia / combustivel;

        System.out.println("O consumo medio do veiculo e de: "+consumo_medio);
    }
}
