using System.Collections.Generic;

namespace Aula07_ap1
{
    public class EstacionamentoRepository
    {
        private List<Estacionamento> estacionamentos = new List<Estacionamento>();

        public void Add(Estacionamento estacionamento)
        {
            estacionamentos.Add(estacionamento);
        }

        public void Remove(Estacionamento estacionamento)
        {
            estacionamentos.Remove(estacionamento);
        }

        public Estacionamento GetById(int id)
        {
            return estacionamentos.FirstOrDefault(e => e.Id == id);
        }

        public Estacionamento BuscarPorPlaca(string placa)
        {
            var estacionamentoEncontrado = estacionamentos.FirstOrDefault(e => e.Veiculo.Placa == placa);
            return estacionamentoEncontrado;
        }


        public List<Estacionamento> GetAll()
        {
            return estacionamentos;
        }
    }

}
