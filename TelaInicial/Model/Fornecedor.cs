using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaInicial.Model
{
   
        public class Fornecedor
        {
            public int ID { get; set; }
            public string NomeFantasia { get; set; }
            public string CNPJ { get; set; }
            public string RazaoSocial { get; set; }
            public string Status { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Bairro { get; set; }
            public string CEP { get; set; }
            public string Municipio { get; set; }
            public string UF { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
            public string NomeResponsavel { get; set; }
            public string Observacoes { get; set; }
        }
}


