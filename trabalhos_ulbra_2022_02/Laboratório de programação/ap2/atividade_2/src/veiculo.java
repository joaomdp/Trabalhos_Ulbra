public class veiculo {
    private boolean ligado;
    public veiculo(boolean ligado){
        this.ligado = ligado;
    }

    public String  ligar(){
        this.ligado = true;
        return "Ligado";
    }
    
    public String  desligar(){
        this.ligado = false;
        return "Desligado";
    }
    
    public boolean ligado(){
        return ligado;
    }

    
   

    
}
