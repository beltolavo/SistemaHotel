using System.Collections.Generic;

namespace SistemaHotel.Models
{
    public class Quarto
    {
        public int IdQuarto { get; set; }
        public int NumeroQuarto { get; set; }
        public string Tipo { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public string StatusQuarto { get; set; }
        public int? Andar { get; set; }
        public string Descricao { get; set; }
    }

    public class QuartoCollection : List<Quarto> { }
}
