using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaInicial.View;

namespace TelaInicial.Apresentacao
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void telaIncial_Load(object sender, EventArgs e)
        {

        }

        private void btnGerenciaFornecedor_Click(object sender, EventArgs e)
        {
            telaGerenciamentoFornecedores cad = new telaGerenciamentoFornecedores();
            cad.Show();
            this.Hide();
        }

        private void btnCadastroFornecedor_Click(object sender, EventArgs e)
        {
            controleDeFornecedores cad = new controleDeFornecedores();
            cad.Show();
            this.Hide();
        }

        private void btnControleEstoque_Click(object sender, EventArgs e)
        {
            controleEstoque cad = new controleEstoque();
            cad.Show();
            this.Hide();
        }

        private void btnConsultaPedido_Click(object sender, EventArgs e)
        {
            consultaDePedido cad = new consultaDePedido();
            cad.Show();
            this.Hide();
        }

        private void btnControleProdução_Click(object sender, EventArgs e)
        {
            controleProdução cad = new controleProdução();
            cad.Show();
            this.Hide();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            telaCadastreSe cad = new telaCadastreSe();
            cad.Show();
            this.Hide();
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telacadastroFornecedor telaCadastro = new telacadastroFornecedor();
            telaCadastro.ShowDialog();
            this.Hide();
        }

        private void gerenciamentoDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaGerenciamentoFornecedores cad = new telaGerenciamentoFornecedores();
            cad.Show();
            this.Hide();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleEstoque cad = new controleEstoque();
            cad.Show();
            this.Hide();
        }

        private void consultaDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaDePedido cad = new consultaDePedido();
            cad.Show();
            this.Hide();
        }

        private void controleDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleProdução cad = new controleProdução();
            cad.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            relatorioVendas cad = new relatorioVendas();
            cad.Show();
            this.Hide();
        }
    }
}
