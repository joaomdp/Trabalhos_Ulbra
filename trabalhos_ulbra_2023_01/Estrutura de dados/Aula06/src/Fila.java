public class Fila
{
    String [] vetor = new String[10];
    int fim = -1;

    public static void main(String[] args) {
        Fila fila = new Fila();
        fila.add("Joao1");
        fila.add("Joao2");
        fila.add("Joao3");
        fila.list();
        fila.remove();
        fila.list();
    }

    public boolean add(String value)
    {
        if(!isFull())
        {
            fim++;
            vetor[fim] = value;
            System.out.println("Adicionando valores...");
            return true;
        }
        return false;
    }

    public boolean remove()
    {
        if(!isEmpty())
        {
            for (int i=0;i<fim;i++)
            {
                vetor[i] = vetor[i+1];
            }
            fim--;
            System.out.println("Descartando itens...");
            return true;
        }
        return false;
    }

    public boolean list()
    {
        if(!isEmpty())
        {
            for (int i=0;i<fim;i++)
            {
                System.out.println(vetor[i]);
            }
            System.out.println("Mostrando itens...");
            return true;
        }
       return false;
    }

    private boolean isEmpty()
    {
        if (fim == -1)
        {
            return true;
        }
        return false;
    }

    private boolean isFull()
    {
        if (fim == vetor.length)
        {
            return true;
        }
        return false;
    }
}
