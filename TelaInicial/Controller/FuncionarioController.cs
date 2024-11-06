using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaInicial.Model;

namespace TelaInicial.Controller
{
    public class FuncionarioController
    {
        private FuncionarioRepository _repository;

        public FuncionarioController()
        {
            _repository = new FuncionarioRepository();
        }

        public void CadastrarFuncionario(string nome, string senha, string email, string setor, string cargo, DateTime dataNascimento)
        {
            Funcionario funcionario = new Funcionario
            {
                Nome = nome,
                Senha = senha,
                Email = email,
                Setor = setor,
                Cargo = cargo,
                DataNascimento = dataNascimento
            };

            _repository.AdicionarFuncionario(funcionario);
        }

        public Funcionario Login(string email, string senha)
        {
            return _repository.AutenticarFuncionario(email, senha);
        }
    }

}
