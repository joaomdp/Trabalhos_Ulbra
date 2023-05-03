public class NoLista {
    int valor;
    NoLista proximo;
    NoLista anterior;

    public NoLista(int valor){
        this.valor = valor;
    }

    public int getValor(){
        return valor;
    }

    public NoLista getProximo(){
        return proximo;
    }

    public NoLista getAnterior(){
        return anterior;
    }

    public void setProximo(NoLista proximo){
        this.proximo = proximo;
    }

    public void setAnterior(NoLista anterior){
        this.anterior = anterior;
    }
}
