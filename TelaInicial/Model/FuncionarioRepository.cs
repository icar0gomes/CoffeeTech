using System;
using System.Data.SqlClient;
using TelaInicial.Model;

public class FuncionarioRepository
{
    string connectionString = "Server=DESKTOP-AR0OTHOS\\SQLEXPRESS2022,1433;Initial Catalog=CoffeeTech;Integrated Security=True";

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO funcionarios (nome, senha, email, setor, cargo, dataNascimento) VALUES (@Nome, @Senha, @Email, @Setor, @Cargo, @DataNascimento)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            command.Parameters.AddWithValue("@Senha", funcionario.Senha);
            command.Parameters.AddWithValue("@Email", funcionario.Email);
            command.Parameters.AddWithValue("@Setor", funcionario.Setor);
            command.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
            command.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public Funcionario AutenticarFuncionario(string email, string senha)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM funcionarios WHERE email = @Email AND senha = @Senha";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Senha", senha);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Funcionario funcionario = new Funcionario
                {
                    IdFuncionario = (int)reader["idFuncionario"],
                    Nome = reader["nome"].ToString(),
                    Email = reader["email"].ToString(),
                    Setor = reader["setor"].ToString(),
                    Cargo = reader["cargo"].ToString(),
                    DataNascimento = Convert.ToDateTime(reader["dataNascimento"])
                };
                return funcionario;
            }
            else
            {
                return null;
            }
        }
    }
}
