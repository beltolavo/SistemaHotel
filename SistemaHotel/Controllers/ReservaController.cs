using SistemaHotel.Models;
using SistemaHotel.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHotel.Controllers
{
    public class ReservaController
    {
        private readonly DataBaseService _database = new DataBaseService();

        public int Inserir(Reserva reserva)
        {
            const string sql =
                "INSERT INTO Reservas (IdCliente, IdQuarto, DataEntrada, DataSaida, QuantidadeHospedes, ValorTotal, StatusReserva) " +
                "VALUES (@IdCliente, @IdQuarto, @DataEntrada, @DataSaida, @QuantidadeHospedes, @ValorTotal, @StatusReserva)";

            string status = string.IsNullOrWhiteSpace(reserva.StatusReserva) ? "Agendada" : reserva.StatusReserva;

            using (SqlCommand command = new SqlCommand(sql))
            {
                AdicionarParametros(command, reserva, status);
                return _database.ExecuteSql(command);
            }
        }

        public int Alterar(Reserva reserva)
        {
            const string sql =
                "UPDATE Reservas SET IdCliente = @IdCliente, IdQuarto = @IdQuarto, DataEntrada = @DataEntrada, DataSaida = @DataSaida, " +
                "QuantidadeHospedes = @QuantidadeHospedes, ValorTotal = @ValorTotal, StatusReserva = @StatusReserva " +
                "WHERE IdReserva = @IdReserva";

            string status = string.IsNullOrWhiteSpace(reserva.StatusReserva) ? "Agendada" : reserva.StatusReserva;

            using (SqlCommand command = new SqlCommand(sql))
            {
                AdicionarParametros(command, reserva, status);
                command.Parameters.Add("@IdReserva", SqlDbType.Int).Value = reserva.IdReserva;
                return _database.ExecuteSql(command);
            }
        }

        public int Excluir(int idReserva)
        {
            const string sql = "DELETE FROM Reservas WHERE IdReserva = @IdReserva";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@IdReserva", SqlDbType.Int).Value = idReserva;
                return _database.ExecuteSql(command);
            }
        }

        public Reserva GetById(int idReserva)
        {
            const string sql = "SELECT * FROM Reservas WHERE IdReserva = @IdReserva";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@IdReserva", SqlDbType.Int).Value = idReserva;
                using (DataTable tabela = _database.GetDataTable(command))
                {
                    return tabela.Rows.Count == 0 ? null : Mapear(tabela.Rows[0]);
                }
            }
        }

        public ReservaCollection GetAll()
        {
            const string sql = "SELECT * FROM Reservas ORDER BY IdReserva";
            using (SqlCommand command = new SqlCommand(sql))
            {
                using (DataTable tabela = _database.GetDataTable(command))
                {
                    ReservaCollection registros = new ReservaCollection();
                    foreach (DataRow row in tabela.Rows)
                    {
                        registros.Add(Mapear(row));
                    }
                    return registros;
                }
            }
        }

        private static void AdicionarParametros(SqlCommand command, Reserva reserva, string status)
        {
            command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = reserva.IdCliente;
            command.Parameters.Add("@IdQuarto", SqlDbType.Int).Value = reserva.IdQuarto;
            command.Parameters.Add("@DataEntrada", SqlDbType.Date).Value = reserva.DataEntrada;
            command.Parameters.Add("@DataSaida", SqlDbType.Date).Value = reserva.DataSaida;
            command.Parameters.Add("@QuantidadeHospedes", SqlDbType.Int).Value = reserva.QuantidadeHospedes;
            command.Parameters.Add("@ValorTotal", SqlDbType.Decimal).Value = reserva.ValorTotal;
            command.Parameters.Add("@StatusReserva", SqlDbType.VarChar).Value = status;
        }

        private static Reserva Mapear(DataRow row)
        {
            return new Reserva
            {
                IdReserva = (int)row["IdReserva"],
                IdCliente = (int)row["IdCliente"],
                IdQuarto = (int)row["IdQuarto"],
                DataEntrada = (DateTime)row["DataEntrada"],
                DataSaida = (DateTime)row["DataSaida"],
                QuantidadeHospedes = (int)row["QuantidadeHospedes"],
                ValorTotal = (decimal)row["ValorTotal"],
                StatusReserva = (string)row["StatusReserva"]
            };
        }
    }
}
