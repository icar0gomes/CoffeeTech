using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaInicial.Model
{
    public class FornecedorService
    {
       private DatabaseConnection db = new DatabaseConnection();

        public void InserirFornecedor(Fornecedor fornecedor)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"INSERT INTO Fornecedores 
                                (NomeFantasia, CNPJ, RazaoSocial, Status, Logradouro, Numero, Bairro, CEP, Municipio, UF, Telefone, Email, NomeResponsavel, Observacoes) 
                                VALUES 
                                (@NomeFantasia, @CNPJ, @RazaoSocial, @Status, @Logradouro, @Numero, @Bairro, @CEP, @Municipio, @UF, @Telefone, @Email, @NomeResponsavel, @Observacoes)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@RazaoSocial", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@Status", fornecedor.Status);
                cmd.Parameters.AddWithValue("@Logradouro", fornecedor.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", fornecedor.Numero);
                cmd.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@CEP", fornecedor.CEP);
                cmd.Parameters.AddWithValue("@Municipio", fornecedor.Municipio);
                cmd.Parameters.AddWithValue("@UF", fornecedor.UF);
                cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@NomeResponsavel", fornecedor.NomeResponsavel);
                cmd.Parameters.AddWithValue("@Observacoes", fornecedor.Observacoes);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"UPDATE Fornecedores SET 
                                NomeFantasia = @NomeFantasia, CNPJ = @CNPJ, RazaoSocial = @RazaoSocial, Status = @Status, 
                                Logradouro = @Logradouro, Numero = @Numero, Bairro = @Bairro, CEP = @CEP, 
                                Municipio = @Municipio, UF = @UF, Telefone = @Telefone, Email = @Email, 
                                NomeResponsavel = @NomeResponsavel, Observacoes = @Observacoes 
                                WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", fornecedor.ID);
                cmd.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@RazaoSocial", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@Status", fornecedor.Status);
                cmd.Parameters.AddWithValue("@Logradouro", fornecedor.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", fornecedor.Numero);
                cmd.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@CEP", fornecedor.CEP);
                cmd.Parameters.AddWithValue("@Municipio", fornecedor.Municipio);
                cmd.Parameters.AddWithValue("@UF", fornecedor.UF);
                cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@NomeResponsavel", fornecedor.NomeResponsavel);
                cmd.Parameters.AddWithValue("@Observacoes", fornecedor.Observacoes);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirFornecedor(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "DELETE FROM Fornecedores WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Fornecedor> ListarFornecedores()
        {
            List<Fornecedor> lista = new List<Fornecedor>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM Fornecedores";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor
                    {
                        ID = reader.GetInt32(0),
                        NomeFantasia = reader.GetString(1),
                        CNPJ = reader.GetString(2),
                        RazaoSocial = reader.GetString(3),
                        Status = reader.GetString(4),
                        Logradouro = reader.GetString(5),
                        Numero = reader.GetString(6),
                        Bairro = reader.GetString(7),
                        CEP = reader.GetString(8),
                        Municipio = reader.GetString(9),
                        UF = reader.GetString(10),
                        Telefone = reader.GetString(11),
                        Email = reader.GetString(12),
                        NomeResponsavel = reader.GetString(13),
                        Observacoes = reader.GetString(14)
                    };
                    lista.Add(fornecedor);
                }
            }
            return lista;
        }
    }
}
