using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaInicial.Apresentacao;

namespace TelaInicial.View
{
    public partial class relatorioVendas : Form
    {
        public relatorioVendas()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaInicial cad = new telaInicial();
            cad.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public class CircularProgressBar : Control
        {
            private int _progresso;
            private Color _corProgresso;

            public int Progresso
            {
                get { return _progresso; }
                set
                {
                    _progresso = value;
                    Invalidate(); // Redesenha o controle quando o valor muda
                }
            }

            public Color CorProgresso
            {
                get { return _corProgresso; }
                set
                {
                    _corProgresso = value;
                    Invalidate();
                }
            }

            public CircularProgressBar()
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                BackColor = Color.Transparent;
                DoubleBuffered = true;
                Size = new Size(200, 200);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Define ângulos e tamanhos
                float startAngle = -90;
                float sweepAngle = 360f * _progresso / 100;

                // Desenha o fundo do círculo
                using (Pen penBackground = new Pen(Color.LightGray, 15))
                {
                    g.DrawArc(penBackground, 10, 10, Width - 20, Height - 20, 0, 360);
                }

                // Desenha a barra de progresso
                using (Pen penProgresso = new Pen(_corProgresso, 15))
                {
                    g.DrawArc(penProgresso, 10, 10, Width - 20, Height - 20, startAngle, sweepAngle);
                }

                // Desenha o texto no centro
                string texto = $"{_progresso}%";
                Font font = new Font("Century Gothic", 20, FontStyle.Bold);
                SizeF textSize = g.MeasureString(texto, font);
                g.DrawString(texto, font, Brushes.Brown, (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
            }
        }


        private void relatorioVendas_Load(object sender, EventArgs e)
        {
            // Configura a barra de progresso para vendas físicas (28%)
            CircularProgressBar progressBarFisicas = new CircularProgressBar
            {
                Progresso = 28, // Percentual de vendas físicas
                CorProgresso = Color.SaddleBrown,
                Location = new Point(100, 100),
                Name = "progressBarFisicas"
            };
            this.Controls.Add(progressBarFisicas);

            // Configura a barra de progresso para vendas on-line (72%)
            CircularProgressBar progressBarOnline = new CircularProgressBar
            {
                Progresso = 72, // Percentual de vendas on-line
                CorProgresso = Color.Chocolate,
                Location = new Point(400, 50),
                Name = "progressBarOnline"
            };
            this.Controls.Add(progressBarOnline);

            // Adiciona as legendas para as vendas físicas e on-line
            Label lblVendasFisicas = new Label
            {
                Text = "● Vendas físicas = 28%",
                Location = new Point(100,50), // Ajuste a posição conforme necessário
                ForeColor = Color.SaddleBrown,
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                AutoSize = true
            };
            this.Controls.Add(lblVendasFisicas);

            Label lblVendasOnline = new Label
            {
                Text = "● Vendas on-line = 72%",
                Location = new Point(400, 300), // Ajuste a posição conforme necessário
                ForeColor = Color.Chocolate,
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                AutoSize = true
            };
            this.Controls.Add(lblVendasOnline);
        }

    }
}
