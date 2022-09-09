import java.util.Scanner;

public class Atividade05 {
    public static void main(String[] args) {
        Scanner tc = new Scanner(System.in);

        System.out.println("Digite uma palavra: ");
        String palavra = tc.nextLine();

        if(palavra=="sexo"&&palavra=="sexual"){
            System.out.println("Conteudo impróprio");
        }else {
            System.out.println("Conteudo liberado");
        }
    }
}
