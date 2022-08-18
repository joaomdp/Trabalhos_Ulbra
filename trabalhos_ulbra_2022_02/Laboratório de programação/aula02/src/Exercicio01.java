public class Exercicio01 {
    public static void main(String[] args) {
        float nota1, nota2, nota3, parcial1,parcial2,parcial3, media;
        nota1 = 8.5f;
        nota2 = 7.5f;
        nota3 = 6.0f;

        parcial1 = nota1*3;
        parcial2 = nota2*2;
        parcial3 = nota3*5;

        media = (parcial1+parcial2+parcial3)/10;

        System.out.println("A media final do aluno e: "+media);
    }
}
