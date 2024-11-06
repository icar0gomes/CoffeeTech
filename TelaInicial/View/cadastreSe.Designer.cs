namespace TelaInicial.Apresentacao
{
    partial class telaCadastreSe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCadastreSe));
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkVoltar = new System.Windows.Forms.LinkLabel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEnviarCadastro = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.cBoxCargo = new System.Windows.Forms.ComboBox();
            this.cBoxSetor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sua tela de cadastro! ";
            // 
            // lblLinkVoltar
            // 
            this.lblLinkVoltar.AutoSize = true;
            this.lblLinkVoltar.BackColor = System.Drawing.Color.Transparent;
            this.lblLinkVoltar.LinkColor = System.Drawing.Color.White;
            this.lblLinkVoltar.Location = new System.Drawing.Point(651, 37);
            this.lblLinkVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinkVoltar.Name = "lblLinkVoltar";
            this.lblLinkVoltar.Size = new System.Drawing.Size(40, 16);
            this.lblLinkVoltar.TabIndex = 1;
            this.lblLinkVoltar.TabStop = true;
            this.lblLinkVoltar.Text = "voltar";
            this.lblLinkVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkVoltar_LinkClicked);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(62, 129);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(138, 19);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome Complete";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(35, 167);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(168, 19);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(142, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.BackColor = System.Drawing.Color.Transparent;
            this.lblSetor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(154, 287);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(46, 19);
            this.lblSetor.TabIndex = 5;
            this.lblSetor.Text = "Setor";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimeNascimento.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimeNascimento.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimeNascimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNascimento.Location = new System.Drawing.Point(217, 161);
            this.dateTimeNascimento.MaxDate = new System.DateTime(2006, 12, 1, 0, 0, 0, 0);
            this.dateTimeNascimento.MinDate = new System.DateTime(1970, 12, 1, 0, 0, 0, 0);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(148, 27);
            this.dateTimeNascimento.TabIndex = 6;
            this.dateTimeNascimento.Value = new System.DateTime(2005, 12, 1, 0, 0, 0, 0);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(142, 242);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(58, 19);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Cargo";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(217, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 27);
            this.txtNome.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(217, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(217, 374);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(315, 27);
            this.txtConfirmaSenha.TabIndex = 13;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaSenha.Location = new System.Drawing.Point(15, 378);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(190, 19);
            this.lblConfirmaSenha.TabIndex = 12;
            this.lblConfirmaSenha.Text = "Confirmação de Senha";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(142, 333);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 19);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(217, 329);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(315, 27);
            this.txtSenha.TabIndex = 13;
            // 
            // btnEnviarCadastro
            // 
            this.btnEnviarCadastro.BackColor = System.Drawing.Color.Sienna;
            this.btnEnviarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviarCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviarCadastro.Location = new System.Drawing.Point(333, 438);
            this.btnEnviarCadastro.Name = "btnEnviarCadastro";
            this.btnEnviarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarCadastro.TabIndex = 14;
            this.btnEnviarCadastro.Text = "Enviar";
            this.btnEnviarCadastro.UseVisualStyleBackColor = false;
            this.btnEnviarCadastro.Click += new System.EventHandler(this.btnEnviarCadastro_Click);
            // 
            // btnEditarCadastro
            // 
            this.btnEditarCadastro.BackColor = System.Drawing.Color.Sienna;
            this.btnEditarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarCadastro.Location = new System.Drawing.Point(457, 438);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCadastro.TabIndex = 15;
            this.btnEditarCadastro.Text = "Editar";
            this.btnEditarCadastro.UseVisualStyleBackColor = false;
            // 
            // cBoxCargo
            // 
            this.cBoxCargo.FormattingEnabled = true;
            this.cBoxCargo.Items.AddRange(new object[] {
            "Auxiliar",
            "Coodernador",
            "Diretor"});
            this.cBoxCargo.Location = new System.Drawing.Point(217, 242);
            this.cBoxCargo.Name = "cBoxCargo";
            this.cBoxCargo.Size = new System.Drawing.Size(183, 24);
            this.cBoxCargo.TabIndex = 16;
            // 
            // cBoxSetor
            // 
            this.cBoxSetor.FormattingEnabled = true;
            this.cBoxSetor.Items.AddRange(new object[] {
            "TI",
            "Vendas e Marketing",
            "Logística",
            "Recursos Humanos",
            "Operações",
            "Financeiro",
            "Produção",
            "Colheita",
            "Pós-Colheita",
            "Manutenção",
            "Qualidade",
            "Agrícolas",
            "Adminsitrativo"});
            this.cBoxSetor.Location = new System.Drawing.Point(217, 282);
            this.cBoxSetor.Name = "cBoxSetor";
            this.cBoxSetor.Size = new System.Drawing.Size(183, 24);
            this.cBoxSetor.TabIndex = 17;
            // 
            // telaCadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 512);
            this.Controls.Add(this.cBoxSetor);
            this.Controls.Add(this.cBoxCargo);
            this.Controls.Add(this.btnEditarCadastro);
            this.Controls.Add(this.btnEnviarCadastro);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.dateTimeNascimento);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblLinkVoltar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "telaCadastreSe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre_se";
            this.Load += new System.EventHandler(this.telaCadastreSe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLinkVoltar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEnviarCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.ComboBox cBoxCargo;
        private System.Windows.Forms.ComboBox cBoxSetor;
    }
}