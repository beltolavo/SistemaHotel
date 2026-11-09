using SistemaHotel.Models;
using SistemaHotel.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHotel.Controllers
{
    public class ClienteController
    {
        private readonly DataBaseService _database = new DataBaseService();

        public int Inserir(Cliente cliente)
        {
            const string sql =
                "INSERT INTO Clientes (Nome, CPF, DataNascimento, Telefone, Email, Endereco, Cidade) " +
                "VALUES (@Nome, @CPF, @DataNascimento, @Telefone, @Email, @Endereco, @Cidade)";

            using (SqlCommand command = new SqlCommand(sql))
            {
                AdicionarParametros(command, cliente);
                return _database.ExecuteSql(command);
            }
        }

        public int Alterar(Cliente cliente)
        {
            const string sql =
                "UPDATE Clientes SET Nome = @Nome, CPF = @CPF, DataNascimento = @DataNascimento, Telefone = @Telefone, " +
                "Email = @Email, Endereco = @Endereco, Cidade = @Cidade " +
                "WHERE IdCliente = @IdCliente";

            using (SqlCommand command = new SqlCommand(sql))
            {
                AdicionarParametros(command, cliente);
                command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = cliente.IdCliente;
                return _database.ExecuteSql(command);
            }
        }

        public int Excluir(int idCliente)
        {
            const string sql = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
                return _database.ExecuteSql(command);
            }
        }

        public Cliente GetById(int idCliente)
        {
            const string sql = "SELECT * FROM Clientes WHERE IdCliente = @IdCliente";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
                using (DataTable tabela = _database.GetDataTable(command))
                {
                    return tabela.Rows.Count == 0 ? null : Mapear(tabela.Rows[0]);
                }
            }
        }

        public ClienteCollection GetAll()
        {
            const string sql = "SELECT * FROM Clientes ORDER BY Nome";
            using (SqlCommand command = new SqlCommand(sql))
            {
                return ConsultarColecao(command);
            }
        }

        public ClienteCollection GetByName(string value)
        {
            const string sql = "SELECT * FROM Clientes WHERE Nome LIKE @Nome ORDER BY Nome";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = "%" + value + "%";
                return ConsultarColecao(command);
            }
        }

        private static void AdicionarParametros(SqlCommand command, Cliente cliente)
        {
            command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = cliente.Nome;
            command.Parameters.Add("@CPF", SqlDbType.VarChar).Value = cliente.CPF;
            command.Parameters.Add("@DataNascimento", SqlDbType.Date).Value = cliente.DataNascimento;
            command.Parameters.Add("@Telefone", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(cliente.Telefone) ? DBNull.Value : (object)cliente.Telefone;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(cliente.Email) ? DBNull.Value : (object)cliente.Email;
            command.Parameters.Add("@Endereco", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(cliente.Endereco) ? DBNull.Value : (object)cliente.Endereco;
            command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(cliente.Cidade) ? DBNull.Value : (object)cliente.Cidade;
        }

        private ClienteCollection ConsultarColecao(SqlCommand command)
        {
            using (DataTable tabela = _database.GetDataTable(command))
            {
                ClienteCollection registros = new ClienteCollection();
                foreach (DataRow row in tabela.Rows)
                {
                    registros.Add(Mapear(row));
                }
                return registros;
            }
        }

        private static Cliente Mapear(DataRow row)
        {
            return new Cliente
            {
                IdCliente = (int)row["IdCliente"],
                Nome = (string)row["Nome"],
                CPF = (string)row["CPF"],
                DataNascimento = (DateTime)row["DataNascimento"],
                Telefone = row.IsNull("Telefone") ? null : (string)row["Telefone"],
                Email = row.IsNull("Email") ? null : (string)row["Email"],
                Endereco = row.IsNull("Endereco") ? null : (string)row["Endereco"],
                Cidade = row.IsNull("Cidade") ? null : (string)row["Cidade"]
            };
        }
    }
}
