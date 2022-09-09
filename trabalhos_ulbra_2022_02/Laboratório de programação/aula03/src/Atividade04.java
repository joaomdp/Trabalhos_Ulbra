import java.util.Scanner;

public class Atividade04 {

    public static void main(String[] args) {

        String palavra = "Ola mundo";

        inverteComStringBuilder(palavra);

    }

    public static void inverteComStringBuilder(String texto) {
        System.out.print("\t");
        StringBuilder invertido = new StringBuilder(texto).reverse();
        System.out.println(invertido);
    }
}
