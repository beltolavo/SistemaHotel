using SistemaHotel.Models;
using SistemaHotel.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHotel.Controllers
{
    public class QuartoController
    {
        private readonly DataBaseService _database = new DataBaseService();

        public int Inserir(Quarto quarto)
        {
            const string sql =
                "INSERT INTO Quartos (NumeroQuarto, Tipo, Capacidade, ValorDiaria, StatusQuarto, Andar, Descricao) " +
                "VALUES (@NumeroQuarto, @Tipo, @Capacidade, @ValorDiaria, @StatusQuarto, @Andar, @Descricao)";

            string status = string.IsNullOrWhiteSpace(quarto.StatusQuarto) ? "Disponivel" : quarto.StatusQuarto;

            using (SqlCommand command = new SqlCommand(sql))
            {
                AdicionarParametros(command, quarto, status);
                return _database.ExecuteSql(command);
            }
        }

        public int Alterar(Quarto quarto)
        {
            const string sql =
                "UPDATE Quartos SET NumeroQuarto = @NumeroQuarto, Tipo = @Tipo, Capacidade = @Capacidade, ValorDiaria = @ValorDiaria, " +
                "StatusQuarto = @StatusQuarto, Andar = @Andar, Descricao = @Descricao " +
                "WHERE IdQuarto = @IdQuarto";

            string status = string.IsNullOrWhiteSpace(quarto.StatusQuarto) ? "Disponivel" : quarto.StatusQuarto;

            using (SqlCommand command = new SqlCommand(sql))
            {
                AdicionarParametros(command, quarto, status);
                command.Parameters.Add("@IdQuarto", SqlDbType.Int).Value = quarto.IdQuarto;
                return _database.ExecuteSql(command);
            }
        }

        public int Excluir(int idQuarto)
        {
            const string sql = "DELETE FROM Quartos WHERE IdQuarto = @IdQuarto";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@IdQuarto", SqlDbType.Int).Value = idQuarto;
                return _database.ExecuteSql(command);
            }
        }

        public Quarto GetById(int idQuarto)
        {
            const string sql = "SELECT * FROM Quartos WHERE IdQuarto = @IdQuarto";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@IdQuarto", SqlDbType.Int).Value = idQuarto;
                return ConsultarRegistro(command);
            }
        }

        public QuartoCollection GetAll()
        {
            const string sql = "SELECT * FROM Quartos ORDER BY NumeroQuarto";
            using (SqlCommand command = new SqlCommand(sql))
            {
                using (DataTable tabela = _database.GetDataTable(command))
                {
                    QuartoCollection registros = new QuartoCollection();
                    foreach (DataRow row in tabela.Rows)
                    {
                        registros.Add(Mapear(row));
                    }
                    return registros;
                }
            }
        }

        public Quarto GetByNumero(int numeroQuarto)
        {
            const string sql = "SELECT * FROM Quartos WHERE NumeroQuarto = @NumeroQuarto";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@NumeroQuarto", SqlDbType.Int).Value = numeroQuarto;
                return ConsultarRegistro(command);
            }
        }

        private static void AdicionarParametros(SqlCommand command, Quarto quarto, string status)
        {
            command.Parameters.Add("@NumeroQuarto", SqlDbType.Int).Value = quarto.NumeroQuarto;
            command.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = quarto.Tipo;
            command.Parameters.Add("@Capacidade", SqlDbType.Int).Value = quarto.Capacidade;
            command.Parameters.Add("@ValorDiaria", SqlDbType.Decimal).Value = quarto.ValorDiaria;
            command.Parameters.Add("@StatusQuarto", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@Andar", SqlDbType.Int).Value = (object)quarto.Andar ?? DBNull.Value;
            command.Parameters.Add("@Descricao", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(quarto.Descricao) ? DBNull.Value : (object)quarto.Descricao;
        }

        private Quarto ConsultarRegistro(SqlCommand command)
        {
            using (DataTable tabela = _database.GetDataTable(command))
            {
                return tabela.Rows.Count == 0 ? null : Mapear(tabela.Rows[0]);
            }
        }

        private static Quarto Mapear(DataRow row)
        {
            return new Quarto
            {
                IdQuarto = (int)row["IdQuarto"],
                NumeroQuarto = (int)row["NumeroQuarto"],
                Tipo = (string)row["Tipo"],
                Capacidade = (int)row["Capacidade"],
                ValorDiaria = (decimal)row["ValorDiaria"],
                StatusQuarto = (string)row["StatusQuarto"],
                Andar = row.IsNull("Andar") ? (int?)null : (int)row["Andar"],
                Descricao = row.IsNull("Descricao") ? null : (string)row["Descricao"]
            };
        }
    }
}
