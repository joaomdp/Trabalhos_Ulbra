namespace Aula02_basic
{
    public class Garrafa
    {
        //caracteristicas
            public int Codigo{get; protected set;}
            public string Cor { get; set; }

            public int AnoFabricacao { get; protected set; }

            public string Identificacao { get; protected set; }      

            public int Volume { get;}


            public Garrafa(int codigo, string cor, int anoFabricacao, string identificacao)
            {
                this.Codigo=codigo;
                this.Cor=cor;
                this.AnoFabricacao=anoFabricacao;
                this.Identificacao=identificacao;
            }

           
            

        //estados
            //velocidade atual        

        //comportamentos
         //desligar
         //ligar
         //parar
         //marchas


    }
}