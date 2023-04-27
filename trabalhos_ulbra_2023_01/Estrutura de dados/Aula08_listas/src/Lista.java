public class Lista {

    Elemento primeiro;
    int tamanho;

    public boolean add(Elemento e){
        if (this.primeiro==null){
            primeiro = e;
            this.tamanho++;
        }else {
            e.proximo = primeiro;
            this.primeiro = e;
            this.tamanho++;
        }
        return  true;
    }

    public boolean addLast(Elemento e){
        if(this.primeiro==null){
            primeiro = e;
        }else{
            Elemento ultimo = this.primeiro;
            while (ultimo.proximo!=null){
                ultimo = ultimo.proximo;
            }
            ultimo.proximo = e;
        }
        this.tamanho++;
        return true;
    }

    public int getTamanho(){
        Elemento e = this.primeiro;
        while (e.proximo!=null){
            this.tamanho++;
            e = e.proximo;
        }
        return tamanho;
    }
}
