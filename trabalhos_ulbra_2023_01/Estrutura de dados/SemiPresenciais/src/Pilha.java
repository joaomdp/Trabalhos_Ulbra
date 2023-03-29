public class Pilha
{
    private int [] array;
    private int top;

    public Pilha(int tamanhoMaximo)
    {
        array = new int[tamanhoMaximo];
        top = -1;
    }

    public void push(int elemento)
    {
        if (top == array.length -1)
        {
            System.out.println("Pilha cheia!");
        }
        top++;
        array[top] = elemento;
    }

    public int pop()
    {
        if (isEmpty())
        {
            System.out.println("Pilha vazia!");
        }
        int elemento = array[top];
        top--;
        return elemento;
    }

    public boolean isEmpty()
    {
        return top == -1;
    }


    public static void main(String[] args)
    {
        Pilha pilha = new Pilha(5);
        pilha.push(10);
        System.out.println(pilha.pop()); // imprime 10
        System.out.println(pilha.isEmpty()); // imprime true
    }
}
