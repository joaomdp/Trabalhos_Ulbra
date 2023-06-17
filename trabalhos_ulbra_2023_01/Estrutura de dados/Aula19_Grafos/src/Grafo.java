import java.util.ArrayList;
import java.util.List;

class Grafo {
    private int numPessoas;
    private List<List<Integer>> adjacencias;

    public Grafo(int numPessoas) {
        this.numPessoas = numPessoas;
        this.adjacencias = new ArrayList<>(numPessoas);

        for (int i = 0; i < numPessoas; i++) {
            adjacencias.add(new ArrayList<>());
        }
    }

    public void adicionarAresta(int pessoa1, int pessoa2) {
        adjacencias.get(pessoa1).add(pessoa2);
        adjacencias.get(pessoa2).add(pessoa1);
    }

    public void imprimirGrafo() {
        for (int i = 0; i < numPessoas; i++) {
            System.out.print("Pessoa " + i + " é amiga de: ");
            for (Integer amigo : adjacencias.get(i)) {
                System.out.print(amigo + " ");
            }
            System.out.println();
        }
    }
}


