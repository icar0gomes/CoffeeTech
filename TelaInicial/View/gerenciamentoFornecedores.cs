using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaInicial.Apresentacao
{
    public partial class telaGerenciamentoFornecedores : Form
    {
        
        public telaGerenciamentoFornecedores()
        {
            InitializeComponent();
           
        }

        public void telaGerenciamentoFornecedores_Load(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaInicial cad = new telaInicial();
            cad.Show();
            this.Hide();
        }


        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
