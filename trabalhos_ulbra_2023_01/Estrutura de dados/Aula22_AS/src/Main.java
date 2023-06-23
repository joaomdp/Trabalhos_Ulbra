public class Main {
    public static void main(String[] args) {
        ArvoreBinaria arvore = new ArvoreBinaria();

        // Adicionar elementos à árvore
        arvore.adicionar(5);
        arvore.adicionar(3);
        arvore.adicionar(7);
        arvore.adicionar(2);
        arvore.adicionar(4);
        arvore.adicionar(6);
        arvore.adicionar(8);

        // Mostrar a árvore
        System.out.println("Árvore Binária:");
        arvore.mostrarArvore();
        System.out.println();

        // Percorrer a árvore em ordem
        System.out.println("Percorrer em Ordem:");
        arvore.percorrerEmOrdem();
        System.out.println();

        // Percorrer a árvore em pré-ordem
        System.out.println("Percorrer em Pré-Ordem:");
        arvore.percorrerPreOrdem();
        System.out.println();

        // Percorrer a árvore em pós-ordem
        System.out.println("Percorrer em Pós-Ordem:");
        arvore.percorrerPosOrdem();
        System.out.println();

        // Remover um elemento da árvore
        arvore.remover(4);

        // Mostrar a árvore atualizada após a remoção
        System.out.println("Árvore Binária após a remoção do elemento 4:");
        arvore.mostrarArvore();
        System.out.println();

        // Adicionar elementos a partir de um vetor em ordem balanceada
        int[] elementos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        arvore.adicionarElementos(elementos);

        // Mostrar a árvore após adicionar elementos em ordem balanceada
        System.out.println("Árvore Binária após adicionar elementos balanceados:");
        arvore.mostrarArvore();
        System.out.println();
    }
}
