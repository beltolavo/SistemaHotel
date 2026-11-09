using System;
using System.Collections.Generic;

namespace SistemaHotel.Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int QuantidadeHospedes { get; set; }
        public decimal ValorTotal { get; set; }
        public string StatusReserva { get; set; }
    }

    public class ReservaCollection : List<Reserva> { }
}
