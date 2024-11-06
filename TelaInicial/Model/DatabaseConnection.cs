using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaInicial.Model
{
    public class DatabaseConnection
    {
        private string connectionString = "sua_string_de_conexao"; // Colocar minha string de conexão com o banco

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

}
