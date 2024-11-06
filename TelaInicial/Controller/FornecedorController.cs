using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaInicial.Model;

namespace TelaInicial.Controller
{
    public class FornecedorController
    {
        private FornecedorService fornecedorService = new FornecedorService();

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            fornecedorService.InserirFornecedor(fornecedor);
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            fornecedorService.AtualizarFornecedor(fornecedor);
        }

        public void DeletarFornecedor(int id)
        {
            fornecedorService.ExcluirFornecedor(id);
        }

        public List<Fornecedor> ObterFornecedores()
        {
            return fornecedorService.ListarFornecedores();
        }
    }
}
