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
using TelaInicial.Apresentacao;
using TelaInicial.Controller;
using TelaInicial.Model;


namespace TelaInicial
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
             telaCadastreSe cad = new telaCadastreSe();
             cad.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
                FuncionarioController controller = new FuncionarioController();
                Funcionario funcionario = controller.Login(txtLogin.Text, txtSenha.Text);

                if (funcionario != null)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    // Aqui pode redirecionar para a próxima tela
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos.");
                }

            telaInicial cad = new telaInicial();
            cad.Show();
            this.Hide();
        }

        }

    }


