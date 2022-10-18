public class Aplicacao {
    public static void main(String[] args) {
        //Criar turma
        Turma turma = new Turma();

        //Criar Aluno
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();
        Aluno aluno3 = new Aluno();

        //Associacao dos alunos e a turma
        turma.aluno1 = aluno1;
        turma.aluno2 = aluno2;
        turma.aluno3 = aluno3;

        //Criar provas
        Prova aluno1Prova1 = new Prova();
        aluno1Prova1.notaParte1 = 4.0;
        aluno1Prova1.notaParte2 = 2.5;
        aluno1.prova1 = aluno1Prova1;

        Prova aluno1Prova2 = new Prova();
        aluno1Prova2.notaParte1 = 1.0;
        aluno1Prova2.notaParte2 = 7.0;
        aluno1.prova2 = aluno1Prova2;

        Prova aluno2Prova1 = new Prova();
        aluno2Prova1.notaParte1 = 4.0;
        aluno2Prova1.notaParte2 = 2.5;
        aluno2.prova1 = aluno2Prova1;

        Prova aluno2Prova2 = new Prova();
        aluno2Prova1.notaParte1 = 1.0;
        aluno2Prova2.notaParte2 = 7.0;
        aluno2.prova2 = aluno2Prova2;

        Prova aluno3Prova1 = new Prova();
        aluno3Prova1.notaParte1 = 4.0;
        aluno3Prova1.notaParte2 = 2.5;
        aluno3.prova1 = aluno3Prova1;

        Prova aluno3Prova2 = new Prova();
        aluno3Prova2.notaParte1 = 1.0;
        aluno3Prova2.notaParte2 = 7.0;
        aluno3.prova2 = aluno3Prova2;

        //Imprimir a media de cada aluno
        System.out.println("A media do aluno 1 e: " + turma.aluno1.calcularMedia());
        System.out.println("A media do aluno 2 e: " + turma.aluno2.calcularMedia());
        System.out.println("A media do aluno 3 e: " + turma.aluno3.calcularMedia());

        //Imprimir a media da turma
        System.out.println("A media da turma e: " + turma.calcularMedia());
    }
}
