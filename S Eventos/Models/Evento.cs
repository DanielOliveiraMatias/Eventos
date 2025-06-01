namespace S_Eventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int Participantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public int DuracaoEmDias => (DataTermino - DataInicio).Days + 1;
        public double CustoTotal => Participantes * CustoPorParticipante;
    }
}
