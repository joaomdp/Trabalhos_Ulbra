import java.util.Random;

public class exercicio07 {
    public static void main(String[] args) {
        String meses[] = new String[12];

        meses[0] = "Janeiro";
        meses[1] = "Fevereiro";
        meses[2] = "Março";
        meses[3] = "Abril";
        meses[4] = "Maio";
        meses[5] = "Junho";
        meses[6] = "Julho";
        meses[7] = "Agosto";
        meses[8] = "Setembro";
        meses[9] = "Outubro";
        meses[10] = "Novembro";
        meses[11] = "Dezembro";

        Random gerador = new Random();
        int valor = gerador.nextInt(12);

        switch (valor){
            case 0:
                System.out.println(meses[0]);
                break;
            case 1:
                System.out.println(meses[1]);
                break;
            case 2:
                System.out.println(meses[2]);
                break;
            case 3:
                System.out.println(meses[3]);
                break;
            case 4:
                System.out.println(meses[4]);
                break;
            case 5:
                System.out.println(meses[5]);
                break;
            case 6:
                System.out.println(meses[6]);
                break;
            case 7:
                System.out.println(meses[7]);
                break;
            case 8:
                System.out.println(meses[8]);
                break;
            case 9:
                System.out.println(meses[9]);
                break;
            case 10:
                System.out.println(meses[10]);
                break;
            case 11:
                System.out.println(meses[11]);
                break;
        }

    }
}
