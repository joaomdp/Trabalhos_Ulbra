public class ListaDuplamenteEncadeada {
    private NoLista primeiro;
    private NoLista ultimo;
    private int cont;

    public ListaDuplamenteEncadeada(){
        primeiro = null;
        ultimo = null;
        cont = 0;
    }

    public void inserirInicio(int valor){
        NoLista novo = new NoLista(valor);

        if (primeiro == null){
            primeiro = novo;
            ultimo = novo;
        }else {
            novo.setProximo(primeiro);
            primeiro.setAnterior(novo);
            primeiro = novo;
        }
        cont++;
    }

    public void inserirFim(int valor){
        NoLista novo = new NoLista(valor);

        if (ultimo == null){
            primeiro = novo;
            ultimo = novo;
        }else {
            novo.setAnterior(ultimo);
            ultimo.setProximo(novo);
            ultimo = novo;
        }
        cont++;
    }

    public void removerInicio(){
        if(primeiro != null){
            if(primeiro == ultimo){
                primeiro = null;
                ultimo = null;
            }else {
                primeiro = primeiro.getProximo();
                primeiro.setAnterior(null);
            }
            cont--;
        }
    }

    public void removerFim(){
        if(ultimo != null){
            if(primeiro == ultimo){
                primeiro = null;
                ultimo = null;
            }else {
                ultimo = ultimo.getAnterior();
                ultimo.setProximo(null);
            }
            cont--;
        }
    }

    public int obter(int posicao){
        if (posicao < 0 || posicao >= cont){
            throw new IndexOutOfBoundsException();
        }

        NoLista atual = primeiro;

        for (int i=0; i < posicao; i++){
            atual = atual.getProximo();
        }

        return atual.getValor();
    }

    public void imprimir(){
        NoLista atual = primeiro;

        while (atual != null){
            System.out.print(atual.getValor() + " ");
            atual = atual.getProximo();
        }
        System.out.println();
    }

    public void imprimirReverso(){
        NoLista atual = ultimo;

        while (atual != null){
            System.out.print(atual.getValor() + " ");
            atual = atual.getAnterior();
        }

        System.out.println();
    }
}
