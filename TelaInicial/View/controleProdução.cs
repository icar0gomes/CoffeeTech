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
    public partial class controleProdução : Form
    {
        private Timer progressTimer; // Timer para animação
        private int currentProgress; // Progresso atual
        private CircularProgressBar progressBar; // Armazena a instância da barra de progresso

        public controleProdução()
        {
            InitializeComponent();
            CarregarGrafico();

            // Inicializa o Timer
            progressTimer = new Timer();
            progressTimer.Interval = 100; // Intervalo em milissegundos (100 ms)
            progressTimer.Tick += ProgressTimer_Tick; // Adiciona o evento Tick


        }

        private void CarregarGrafico()
        {
            // Configurações do gráfico
            chart1.Size = new Size(355, 350); // Define o tamanho do gráfico
            chart1.Location = new Point(this.ClientSize.Width - chart1.Width - 10, 70); // Alinha à direita e ajusta a posição
            chart1.Series.Clear(); // Limpa qualquer série existente

            // Cria uma nova série para cada semana
            Series semana1Series = new Series("Semana 1")
            {
                ChartType = SeriesChartType.StackedBar, // Tipo de gráfico empilhado
                Color = Color.Peru // Cor para a Semana 1
            };

            Series semana2Series = new Series("Semana 2")
            {
                ChartType = SeriesChartType.StackedBar, // Tipo de gráfico empilhado
                Color = Color.Brown // Cor para a Semana 2
            };

            Series semana3Series = new Series("Semana 3")
            {
                ChartType = SeriesChartType.StackedBar, // Tipo de gráfico empilhado
                Color = Color.SandyBrown // Cor para a Semana 3
            };

            // Adiciona os dados da porcentagem para cada tipo de café em cada semana
            // Semana 1
            semana1Series.Points.AddXY("Arábica", 25); // Exemplo de dados
            semana1Series.Points.AddXY("Acaia", 30);
            semana1Series.Points.AddXY("Bourbon", 45);

            // Semana 2
            semana2Series.Points.AddXY("Arábica", 35);
            semana2Series.Points.AddXY("Acaia", 40);
            semana2Series.Points.AddXY("Bourbon", 30);

            // Semana 3
            semana3Series.Points.AddXY("Arábica", 20);
            semana3Series.Points.AddXY("Acaia", 25);
            semana3Series.Points.AddXY("Bourbon", 55);

            // Adiciona as séries ao gráfico
            chart1.Series.Add(semana1Series);
            chart1.Series.Add(semana2Series);
            chart1.Series.Add(semana3Series);

            // Configura o eixo X e Y
            chart1.ChartAreas[0].AxisX.Title = "Tipos de Café";
            chart1.ChartAreas[0].AxisY.Title = "Porcentagem (%)";
            chart1.Legends.Clear(); // Remove a legenda se não for necessária

            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Gothic", 8 , FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Gothic", 8, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 8, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 8, FontStyle.Bold);
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void controleProdução_Load(object sender, EventArgs e)
        {
            // Configura o DateTimePicker de início para a data de hoje, 08:40
            dtpInicio.Value = DateTime.Today.AddHours(8).AddMinutes(40);

            // Configura o DateTimePicker de fim para a data de hoje, 09:00
            dtpFim.Value = DateTime.Today.AddHours(9);

            // Cria e adiciona a barra de progresso
            progressBar = new CircularProgressBar
            {
                Progresso = 0, // Começa com 0%
                Location = new Point(400, 250), // Posição no formulário
                Name = "progressBar" // Define um nome para a barra de progresso
            };
            this.Controls.Add(progressBar);

            currentProgress = 8; // Inicializa o progresso atual
            progressTimer.Start(); // Inicia o Timer
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (currentProgress < 30)
            {
                currentProgress += 2; // Incrementa o progresso (ajuste o valor conforme necessário)
                progressBar.Progresso = currentProgress; // Atualiza a barra de progresso
            }
            else
            {
                progressTimer.Stop(); // Para o Timer ao atingir 100%
            }
        }

        public class CircularProgressBar : Control
        {
            private int _progresso;
            public int Progresso
            {
                get { return _progresso; }
                set
                {
                    _progresso = value;
                    Invalidate(); // Redesenha o controle quando o valor muda
                }
            }

            public CircularProgressBar()
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                BackColor = Color.Transparent; // Define o fundo como transparente
                DoubleBuffered = true; // Para evitar flickering (tremulação)
                this.Size = new Size(200, 195); // Tamanho padrão do controle
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Graphics g = e.Graphics;

                // Configurações para suavizar as bordas
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Define os tamanhos e ângulos
                float startAngle = -90; // Começa o arco no topo
                float sweepAngle = 360f * _progresso / 100; // Calcula o ângulo com base na porcentagem

                // Desenho do fundo do círculo
                using (Pen penBackground = new Pen(Color.LightGray, 15))
                {
                    g.DrawArc(penBackground, 10, 30, Width - 20, Height - 60, 0, 360); // Ajusta o Y para baixo
                }

                // Desenho da barra de progresso
                using (Pen penProgresso = new Pen(Color.Brown, 15))
                {
                    g.DrawArc(penProgresso, 10, 30, Width - 20, Height - 60, startAngle, sweepAngle); // Ajusta o Y para baixo
                }

                // Desenho do texto no centro inferior da barra
                string texto = $"{_progresso}%";
                Font font = new Font("Century Gothic", 20, FontStyle.Bold);
                SizeF textSize = g.MeasureString(texto, font);
                g.DrawString(texto, font, Brushes.Brown,
                             (Width - textSize.Width) / 2,
                             Height / 2); // Posiciona o texto mais centralizado na parte inferior
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaInicial cad = new telaInicial();
            cad.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

