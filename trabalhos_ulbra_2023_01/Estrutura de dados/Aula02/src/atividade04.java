import java.util.Scanner;

public class atividade04 {
    public static void main(String[] args) {
        int inteiros[], quant =0;
        Scanner tc =new Scanner(System.in);

        System.out.println("Insira a quantidade de vezes que o programa vai executar: ");
        quant = tc.nextInt();

        inteiros = new int[quant];
        for (int i=0;i<quant;i++){
            System.out.println("Insira o valor "+(i+1));
            inteiros[i] = tc.nextInt();
        }
        for (int x=quant;x>0;x--){
            System.out.println(inteiros[x-1]);
        }

    }
}
