public class Main {
    public static void main(String[] args) {
        ListaDuplamenteEncadeada lista = new ListaDuplamenteEncadeada();

        lista.inserirInicio(5);
        lista.inserirInicio(8);
        lista.inserirInicio(3);
        lista.inserirInicio(2);
        lista.inserirFim(7);

        lista.removerInicio();

        int valor = lista.obter(2);
        System.out.println("Valor na posição 2: " + valor);

        lista.removerFim();

        System.out.println("Lista completa: ");
        lista.imprimir();

        System.out.println("Lista completa de trás para frente: ");
        lista.imprimirReverso();
    }
}