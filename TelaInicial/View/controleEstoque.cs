using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TelaInicial.Apresentacao;

namespace TelaInicial.View
{
    public partial class controleEstoque : Form
    {
        public controleEstoque()
        {
            InitializeComponent();
            CriarGrafico();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaInicial cad = new telaInicial();
            cad.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void CriarGrafico()
        {

            graficoEstoque.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Regular);
            graficoEstoque.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Regular);

            // Configurando as séries do gráfico
            graficoEstoque.Series.Clear();

            // Série do estoque mínimo
            Series estoqueMinimo = new Series("Estoque mínimo");
            estoqueMinimo.ChartType = SeriesChartType.StackedColumn;
            estoqueMinimo.Points.AddXY("Arábica", 3000);
            estoqueMinimo.Points.AddXY("Acaiá", 4000);
            estoqueMinimo.Points.AddXY("Bourbon", 3500);
            estoqueMinimo.Points.AddXY("Catuaí", 5000);
            estoqueMinimo.Points.AddXY("Geisha", 2000);
            estoqueMinimo.Points.AddXY("Kona", 4000);
            estoqueMinimo.Points.AddXY("Robusta", 3500);

            // Série do estoque médio
            Series estoqueMedio = new Series("Estoque médio");
            estoqueMedio.ChartType = SeriesChartType.StackedColumn;
            estoqueMedio.Points.AddXY("Arábica", 7000);
            estoqueMedio.Points.AddXY("Acaiá", 6000);
            estoqueMedio.Points.AddXY("Bourbon", 8000);
            estoqueMedio.Points.AddXY("Catuaí", 7000);
            estoqueMedio.Points.AddXY("Geisha", 6000);
            estoqueMedio.Points.AddXY("Kona", 8000);
            estoqueMedio.Points.AddXY("Robusta", 7000);

            // Série do estoque máximo
            Series estoqueMaximo = new Series("Estoque máximo");
            estoqueMaximo.ChartType = SeriesChartType.StackedColumn;
            estoqueMaximo.Points.AddXY("Arábica", 10000);
            estoqueMaximo.Points.AddXY("Acaiá", 9000);
            estoqueMaximo.Points.AddXY("Bourbon", 12000);
            estoqueMaximo.Points.AddXY("Catuaí", 10000);
            estoqueMaximo.Points.AddXY("Geisha", 9000);
            estoqueMaximo.Points.AddXY("Kona", 11000);
            estoqueMaximo.Points.AddXY("Robusta", 10000);

            // Adicionando as séries ao gráfico
            graficoEstoque.Series.Add(estoqueMinimo);
            graficoEstoque.Series.Add(estoqueMedio);
            graficoEstoque.Series.Add(estoqueMaximo);

            // Definir as cores das barras (opcional)
            estoqueMinimo.Color = System.Drawing.Color.Brown;
            estoqueMedio.Color = System.Drawing.Color.Peru;
            estoqueMaximo.Color = System.Drawing.Color.Tan;

           


        }
    }
}
