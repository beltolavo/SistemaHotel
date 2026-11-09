using SistemaHotel.Models;
using SistemaHotel.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHotel.Controllers
{
    public class FuncionarioController
    {
        private readonly DataBaseService _database = new DataBaseService();

        public int Inserir(Funcionario funcionario)
        {
            const string sql =
                "INSERT INTO Funcionarios (Nome, CPF, Telefone, Email, Cargo, DataAdmissao, Salario, StatusFuncionario) " +
                "VALUES (@Nome, @CPF, @Telefone, @Email, @Cargo, @DataAdmissao, @Salario, @StatusFuncionario)";

            string status = string.IsNullOrWhiteSpace(funcionario.StatusFuncionario) ? "Ativo" : funcionario.StatusFuncionario;

            using (SqlCommand command = new SqlCommand(sql))
            {
                AdicionarParametros(command, funcionario, status);
                return _database.ExecuteSql(command);
            }
        }

        public int Alterar(Funcionario funcionario)
        {
            const string sql =
                "UPDATE Funcionarios SET Nome = @Nome, CPF = @CPF, Telefone = @Telefone, Email = @Email, " +
                "Cargo = @Cargo, DataAdmissao = @DataAdmissao, Salario = @Salario, StatusFuncionario = @StatusFuncionario " +
                "WHERE IdFuncionario = @IdFuncionario";

            string status = string.IsNullOrWhiteSpace(funcionario.StatusFuncionario) ? "Ativo" : funcionario.StatusFuncionario;

            using (SqlCommand command = new SqlCommand(sql))
            {
                AdicionarParametros(command, funcionario, status);
                command.Parameters.Add("@IdFuncionario", SqlDbType.Int).Value = funcionario.IdFuncionario;
                return _database.ExecuteSql(command);
            }
        }

        public int Excluir(int idFuncionario)
        {
            const string sql = "DELETE FROM Funcionarios WHERE IdFuncionario = @IdFuncionario";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@IdFuncionario", SqlDbType.Int).Value = idFuncionario;
                return _database.ExecuteSql(command);
            }
        }

        public Funcionario GetById(int idFuncionario)
        {
            const string sql = "SELECT * FROM Funcionarios WHERE IdFuncionario = @IdFuncionario";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@IdFuncionario", SqlDbType.Int).Value = idFuncionario;
                using (DataTable tabela = _database.GetDataTable(command))
                {
                    return tabela.Rows.Count == 0 ? null : Mapear(tabela.Rows[0]);
                }
            }
        }

        public FuncionarioCollection GetAll()
        {
            const string sql = "SELECT * FROM Funcionarios ORDER BY Nome";
            using (SqlCommand command = new SqlCommand(sql))
            {
                return ConsultarColecao(command);
            }
        }

        public FuncionarioCollection GetByName(string value)
        {
            const string sql = "SELECT * FROM Funcionarios WHERE Nome LIKE @Nome ORDER BY Nome";
            using (SqlCommand command = new SqlCommand(sql))
            {
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = "%" + value + "%";
                return ConsultarColecao(command);
            }
        }

        private static void AdicionarParametros(SqlCommand command, Funcionario funcionario, string status)
        {
            command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = funcionario.Nome;
            command.Parameters.Add("@CPF", SqlDbType.VarChar).Value = funcionario.CPF;
            command.Parameters.Add("@Telefone", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(funcionario.Telefone) ? DBNull.Value : (object)funcionario.Telefone;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(funcionario.Email) ? DBNull.Value : (object)funcionario.Email;
            command.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = funcionario.Cargo;
            command.Parameters.Add("@DataAdmissao", SqlDbType.Date).Value = funcionario.DataAdmissao;
            command.Parameters.Add("@Salario", SqlDbType.Decimal).Value = funcionario.Salario;
            command.Parameters.Add("@StatusFuncionario", SqlDbType.VarChar).Value = status;
        }

        private FuncionarioCollection ConsultarColecao(SqlCommand command)
        {
            using (DataTable tabela = _database.GetDataTable(command))
            {
                FuncionarioCollection registros = new FuncionarioCollection();
                foreach (DataRow row in tabela.Rows)
                {
                    registros.Add(Mapear(row));
                }
                return registros;
            }
        }

        private static Funcionario Mapear(DataRow row)
        {
            return new Funcionario
            {
                IdFuncionario = (int)row["IdFuncionario"],
                Nome = (string)row["Nome"],
                CPF = (string)row["CPF"],
                Telefone = row.IsNull("Telefone") ? null : (string)row["Telefone"],
                Email = row.IsNull("Email") ? null : (string)row["Email"],
                Cargo = (string)row["Cargo"],
                DataAdmissao = (DateTime)row["DataAdmissao"],
                Salario = (decimal)row["Salario"],
                StatusFuncionario = (string)row["StatusFuncionario"]
            };
        }
    }
}
