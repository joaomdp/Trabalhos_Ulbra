public class Aluno {
    Prova prova1;
    Prova prova2;

    double calcularMedia(){
        double media = prova1.calcularNotaTotal() + prova2.calcularNotaTotal();
        return media / 2;
    }
}
