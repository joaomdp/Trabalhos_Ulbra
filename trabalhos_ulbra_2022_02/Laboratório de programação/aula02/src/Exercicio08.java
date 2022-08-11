import javax.swing.*;
import java.util.Scanner;

public class Exercicio08 {
    public static void main(String[] args) {
        int x=0, y=0, troca;

        Scanner tc = new Scanner(System.in);
        System.out.println("Informe o primeiro valor: ");
        x = tc.nextInt();
        System.out.println("Informe o segundo valor: ");
        y = tc.nextInt();

        troca = x;
        x = y;
        y = troca;

        System.out.println("O valor de x e: " + x);
        System.out.println("O valor de y e: " + y);

    }
}
