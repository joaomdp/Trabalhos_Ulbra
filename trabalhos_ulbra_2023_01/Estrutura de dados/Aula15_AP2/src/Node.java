public class Node {
    public int valor;
    public Node anterior;
    public Node proximo;

    public Node (int valor) {
        this.valor = valor;
        this.anterior = null;
        this.proximo = null;
    }

    public int getValor(){
        return valor;
    }

    public Node getAnterior(){
        return anterior;
    }

    public void setAnterior(Node anterior){
        this.anterior = anterior;
    }

    public Node getProximo(){
        return proximo;
    }

    public void setProximo(Node proximo){
        this.proximo = proximo;
    }
}
