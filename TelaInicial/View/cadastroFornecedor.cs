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


namespace TelaInicial.View
{
    public partial class telacadastroFornecedor : Form
    {
        private FornecedorController controller = new FornecedorController();
        private Fornecedor fornecedor;


        public telacadastroFornecedor(Fornecedor fornecedor = null)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;

            // Preencher o ComboBox com as UFs (Unidades Federativas)
            cBoxUF.Items.AddRange(new string[]
            {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA",
                "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            });


            if (fornecedor != null)
            {
                txtNomeFantasia.Text = fornecedor.NomeFantasia;
                txtCNPJ.Text = fornecedor.CNPJ;
                txtRazaoSocial.Text = fornecedor.RazaoSocial;
                txtStatus.Text = fornecedor.Status;
                txtLogradouro.Text = fornecedor.Logradouro;
                txtNumLogradouro.Text = fornecedor.Numero;
                txtBairro.Text = fornecedor.Bairro;
                txtCEP.Text = fornecedor.CEP;
                txtMunicipio.Text = fornecedor.Municipio;
                fornecedor.UF = cBoxUF.SelectedItem?.ToString(); // Pega o estado selecionado no ComboBox
                txtTelefone.Text = fornecedor.Telefone;
                txtEmailFornec.Text = fornecedor.Email;
                txtNomeEmail.Text = fornecedor.NomeResponsavel;
                txtObservacao.Text = fornecedor.Observacoes;
            }
        }

        private void telaCadastroFornecedor(object sender, EventArgs e)
        {
            
        }

        private void lblLinkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaInicial cad = new telaInicial();
            cad.Show();
            this.Hide();
        }

        private void btnEnviarCadastro_Click(object sender, EventArgs e)
        {
            if (fornecedor == null) fornecedor = new Fornecedor();

            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Status = txtStatus.Text;
            fornecedor.Logradouro = txtLogradouro.Text;
            fornecedor.Numero = txtNumLogradouro.Text;
            fornecedor.Bairro = txtBairro.Text;
            fornecedor.CEP = txtCEP.Text;
            fornecedor.Municipio = txtMunicipio.Text;
            fornecedor.UF = cBoxUF.SelectedItem?.ToString(); // Pega o estado selecionado no ComboBox
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Email = txtEmailFornec.Text;
            fornecedor.NomeResponsavel = txtNomeEmail.Text;
            fornecedor.Observacoes = txtObservacao.Text;

            if (fornecedor.ID == 0)
                controller.AdicionarFornecedor(fornecedor);
            else
                controller.AtualizarFornecedor(fornecedor);

            MessageBox.Show("Fornecedor salvo com sucesso!");
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (fornecedor != null && fornecedor.ID != 0)
            {
                controller.DeletarFornecedor(fornecedor.ID);
                MessageBox.Show("Fornecedor excluído com sucesso!");
                this.Close();
            }
        }

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            if (fornecedor == null || fornecedor.ID == 0)
            {
                MessageBox.Show("Selecione um fornecedor para editar.");
                return;
            }

            // Atualizar o objeto fornecedor com os dados do formulário
            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Status = txtStatus.Text;
            fornecedor.Logradouro = txtLogradouro.Text;
            fornecedor.Numero = txtNumLogradouro.Text;
            fornecedor.Bairro = txtBairro.Text;
            fornecedor.CEP = txtCEP.Text;
            fornecedor.Municipio = txtMunicipio.Text;
            fornecedor.UF = cBoxUF.SelectedItem?.ToString();
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Email = txtEmailFornec.Text;
            fornecedor.NomeResponsavel = txtNomeEmail.Text;
            fornecedor.Observacoes = txtObservacao.Text;

            // Chama o controlador para atualizar o fornecedor no banco de dados
            controller.AtualizarFornecedor(fornecedor);

            MessageBox.Show("Fornecedor atualizado com sucesso!");
            this.Close();
        }
    }
    }

