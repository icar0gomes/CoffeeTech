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
using System.Windows.Forms.VisualStyles;
using TelaInicial.Apresentacao;

namespace TelaInicial.View
{
    public partial class consultaDePedido : Form
    {
        // Construtor do formulário
        public consultaDePedido()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
        }

        // Evento que é chamado quando o formulário é carregado
        private void consultaDePedido_Load(object sender, EventArgs e)
        {
            // Configura o ComboBox 'cbStatus' para exibir as opções coloridas
            cbStatus.DrawMode = DrawMode.OwnerDrawFixed; // Define o modo de desenho personalizado para os itens
            cbStatus.Items.AddRange(new string[] { "Processado", "Em Processamento", "Em Aberto" }); // Adiciona as opções ao ComboBox
            cbStatus.DrawItem += new DrawItemEventHandler(cbStatus_DrawItem); // Associa o evento de desenho personalizado
        }

        // Método para desenhar os itens do ComboBox 'cbStatus' com cores
        private void cbStatus_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Define as cores para cada status.
            string status = cbStatus.Items[e.Index].ToString();
            Color color = Color.Black;
            if (status == "Processado") color = Color.Green;
            else if (status == "Em Processamento") color = Color.Yellow;
            else if (status == "Em Aberto") color = Color.Red;

            e.DrawBackground();

            // Define a fonte para "Century Gothic", tamanho 10
            using (Font font = new Font("Century Gothic", 10, FontStyle.Regular))
            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(status, font, brush, e.Bounds); // Usa a nova fonte e a cor específica
            }

            e.DrawFocusRectangle();
        }


        // Evento do botão "Buscar" para filtrar e exibir os dados no DataGridView
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Pega o valor selecionado em 'cbStatus' e 'cbCliente', e os valores dos DateTimePickers
            string status = cbStatus.SelectedItem?.ToString();
            DateTime? dataInicio = dtpDataEmissaoInicial.Value;
            DateTime? dataFim = dtpDataEmissaoInicial.Value;

            // Monta a query SQL com condições que serão adicionadas se os filtros forem usados
            string query = "SELECT * FROM Pedidos WHERE 1=1";

            if (dataInicio.HasValue)
                query += " AND DataEmissao >= @DataInicio"; // Filtra registros com DataEmissao >= dataInicio

            if (dataFim.HasValue)
                query += " AND DataEmissao <= @DataFim"; // Filtra registros com DataEmissao <= dataFim

            if (!string.IsNullOrEmpty(status))
                query += " AND Status = @Status"; // Filtra registros pelo status selecionado

            
            // Conexão com o banco de dados para executar a consulta
            using (SqlConnection conn = new SqlConnection("sua_string_de_conexão"))
            {
                SqlCommand cmd = new SqlCommand(query, conn); // Cria o comando com a consulta

                // Adiciona os parâmetros à consulta, se aplicáveis
                if (dataInicio.HasValue)
                    cmd.Parameters.AddWithValue("@DataInicio", dataInicio.Value);
                if (dataFim.HasValue)
                    cmd.Parameters.AddWithValue("@DataFim", dataFim.Value);
                if (!string.IsNullOrEmpty(status))
                    cmd.Parameters.AddWithValue("@Status", status);
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Prepara para preencher o DataTable com os dados retornados
                DataTable tabela = new DataTable(); // Cria um DataTable para armazenar os dados
                adapter.Fill(tabela); // Preenche o DataTable com os dados da consulta
                dgvPedidos.DataSource = tabela; // Exibe os dados no DataGridView 'dgvPedidos'
            }
        }

        // Evento do botão "Limpar Filtros" para resetar os controles e a exibição de dados
        private void btnLimparfiltros_Click(object sender, EventArgs e)
        {
            dtpDataEmissaoInicial.Value = DateTime.Now; // Reseta a data inicial para a data atual
            dtpDataEmissaoFinal.Value = DateTime.Now; // Reseta a data final para a data atual
            cbStatus.SelectedIndex = -1; // Limpa a seleção do ComboBox 'cbStatus'
             dgvPedidos.DataSource = null; // Limpa os dados exibidos no DataGridView
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblLinkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           telaInicial cad = new telaInicial();
            cad.Show();
            this.Hide();
        }
    }
}
