import java.util.Scanner;

public class Atividade03 {
    public static void main(String[] args) {
        int sorteio = (int) ((Math.random()*10)+5);
        int cont=0;
        int i=0;
        double senha=0;
        if(sorteio>=5 && sorteio<=10){
            do {
                senha = Math.random()*i;
                i++;
            }while(cont<sorteio);
        }
        System.out.println(senha);
    }
}
