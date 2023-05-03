public class ListaDuplamenteEncadeada {
    private NoLista primeiro;
    private NoLista ultimo;

    public ListaDuplamenteEncadeada(){
        primeiro = null;
        ultimo = null;
    }

    public void inserirInicio(int valor){
        NoLista novo = new NoLista(valor);

        if (primeiro == null){
            primeiro = novo;
            ultimo = novo;
        }else {
            novo.proximo = primeiro;
            primeiro.anterior = novo;
            primeiro = novo;
        }
    }

    public void inserirFim(int valor){
        NoLista novo = new NoLista(valor);

        if (ultimo == null){
            primeiro = novo;
            ultimo = novo;
        }else {
            novo.anterior = ultimo;
            ultimo.proximo = novo;
            ultimo = novo;
        }
    }

    public void removerInicio(){
        if(primeiro != null){
            if(primeiro == ultimo){
                primeiro = null;
                ultimo = null;
            }else {
                primeiro = primeiro.proximo;
                primeiro.anterior = null;
            }
        }
    }

    public void removerFim(){
        if(ultimo != null){
            if(primeiro == ultimo){
                primeiro = null;
                ultimo = null;
            }else {
                ultimo = ultimo.anterior;
                ultimo.proximo = null;
            }
        }
    }

    public int obter(int posicao){
        NoLista atual = primeiro;

        for(int i=0; i < posicao; i++){
            if (atual == null){
                return -1;
            }
            atual = atual.proximo;
        }
        if (atual != null){
            return atual.valor;
        }else{
            return -1;
        }
    }

    public void imprimir(){
        NoLista atual = primeiro;

        while (atual != null){
            System.out.print(atual.valor + " ");
            atual = atual.proximo;
        }
        System.out.println();
    }

    public void imprimirReverso(){
        NoLista atual = ultimo;

        while (atual != null){
            System.out.print(atual.valor + " ");
            atual = atual.anterior;
        }

        System.out.println();
    }
}
