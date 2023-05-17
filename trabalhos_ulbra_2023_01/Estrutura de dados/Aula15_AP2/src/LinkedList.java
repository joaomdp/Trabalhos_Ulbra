public class LinkedList {
    public Node inicio;
    public Node fim;

    public LinkedList(){
        this.inicio = null;
        this.fim = null;
    }

    public void inserirNoInicio(int valor){
        Node newNode = new Node(valor);
        if (inicio == null){
            inicio = newNode;
            fim = newNode;
        }else{
            newNode.setProximo(inicio);
            inicio.setAnterior(newNode);
            inicio = newNode;
        }
    }

    public void inserirDepois(int valorExiste, int valor){
        Node newNode = new Node(valor);
        Node currentNode = inicio;
        while (currentNode != null){
            if (currentNode.getValor() == valorExiste){
                newNode.setAnterior(currentNode);
                newNode.setProximo(currentNode.getProximo());
                if (currentNode.getProximo() != null){
                    currentNode.getProximo().setAnterior(newNode);
                }else{
                    fim = newNode;
                }
                currentNode.setProximo(newNode);
                break;
            }
            currentNode = currentNode.getProximo();
        }
    }

    public void inserirNoFim(int valor){
        Node newNode = new Node(valor);
        if (fim == null){
            inicio = newNode;
            fim = newNode;
        }else {
            newNode.setAnterior(fim);
            fim.setProximo(newNode);
            fim = newNode;
        }
    }

    public void algoritmoA() {
        if (inicio == null || inicio.proximo == null) {
            return;
        }
        boolean trocado;

        do {
            trocado = false;
            Node atual = inicio;
            while (atual.proximo != null) {
                if (atual.valor > atual.proximo.valor) {
                    int valorTemp = atual.valor;
                    atual.valor = atual.proximo.valor;
                    atual.proximo.valor = valorTemp;
                    trocado = true;
                }
                atual = atual.proximo;
            }
        } while (trocado);
    }

    public void algoritmoB() {
        if (inicio == null || inicio.proximo == null) {
            return;
        }

        Node atual = inicio;
        while (atual != null) {
            Node maxNode = atual;
            Node valorTemp = atual.proximo;

            while (valorTemp != null) {
                if (valorTemp.valor > maxNode.valor) {
                    maxNode = valorTemp;
                }
                valorTemp = valorTemp.proximo;
            }

            if (maxNode != atual) {
                int tempData = atual.valor;
                atual.valor = maxNode.valor;
                maxNode.valor = tempData;
            }

            atual = atual.proximo;
        }
    }

    public void printList() {
        Node atual = inicio;
        while (atual != null) {
            System.out.print(atual.valor + " ");
            atual = atual.proximo;
        }
        System.out.println();
    }

}
