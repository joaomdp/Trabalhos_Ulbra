public class Main {
    public static void main(String[] args) {
        LinkedList list = new LinkedList();

        // Insere elementos no início, meio e fim da lista
        list.inserirNoInicio(9);
        list.inserirNoInicio(3);
        list.inserirDepois(3, 4);
        list.inserirDepois(9, 6);
        list.inserirNoFim(8);

        // Imprime os elementos da lista
        System.out.println("Elementos da lista:");
        list.printList();

        // Ordena os elementos em ordem crescente
        list.algoritmoA();

        // Imprime os elementos novamente para verificar se estão ordenados corretamente
        System.out.println("Elementos ordenados em ordem crescente:");
        list.printList();

        // Ordena os elementos em ordem decrescente
        list.algoritmoB();

        // Imprime os elementos novamente para verificar se estão ordenados corretamente
        System.out.println("Elementos ordenados em ordem decrescente:");
        list.printList();
    }
}