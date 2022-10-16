public class Aluno1 {
    double prova1;
    double prova2;

    double media;

    public double definirValores(double prova1, double prova2){
        this.prova1=prova1;
        this.prova2=prova2;
    }

    public double calcularMedia() {
        this.media = prova1 + prova2;
    }
}
