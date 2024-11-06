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
using TelaInicial.Model;

namespace TelaInicial.View
{
    public partial class controleDeFornecedores : Form
    {
        private FornecedorController controller = new FornecedorController();

        public controleDeFornecedores()
        {
            InitializeComponent();
            AtualizarDataGrid();

        }

        private void AtualizarDataGrid()
        {
            dgvFornecedores.DataSource = controller.ObterFornecedores();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

       


        private void controleDeFornecedores_Load(object sender, EventArgs e)
        {

        }

        

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            telacadastroFornecedor telaCadastro = new telacadastroFornecedor();
            telaCadastro.ShowDialog();
            AtualizarDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvFornecedores.SelectedRows[0].Cells["ID"].Value);
                Fornecedor fornecedor = controller.ObterFornecedores().Find(f => f.ID == id);

                telacadastroFornecedor telaCadastro = new telacadastroFornecedor(); 
                telaCadastro.ShowDialog();
                AtualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.");
            }
        }

        private void lblLinkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}