using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaInicial.Controller;


namespace TelaInicial.Apresentacao
{
    public partial class telaCadastreSe : Form
    {
        public telaCadastreSe()
        {
            InitializeComponent();
        }

        private void lblLinkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaLogin cad = new telaLogin();
            cad.Show();
            this.Hide();
        }

        private void btnEnviarCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmaSenha.Text)
            {
                FuncionarioController controller = new FuncionarioController();
                controller.CadastrarFuncionario(txtNome.Text, txtSenha.Text, txtEmail.Text, cBoxSetor.Text, cBoxCargo.Text, dateTimeNascimento.Value);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("As senhas não coincidem.");
            }
        }
        private void telaCadastreSe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
