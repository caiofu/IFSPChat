namespace ChatIFSP.Views
{
    partial class frmEditarPerfil
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
            components = new System.ComponentModel.Container();
            groupBox2 = new GroupBox();
            txtBoxEmail = new TextBox();
            lbEmail = new Label();
            btnTrocarFoto = new Button();
            txtBoxNome = new TextBox();
            pbFoto = new PictureBox();
            lbNome = new Label();
            txtBoxApelido = new TextBox();
            lbApelido = new Label();
            gpBoxSenha = new GroupBox();
            ckBoxTrocarSenha = new CheckBox();
            lbDgitos = new Label();
            txtBoxConfirmarSenha = new TextBox();
            lbConfirmarSenha = new Label();
            txtBoxNovaSenha = new TextBox();
            lbNovaSenha = new Label();
            txtBoxSenhaAtual = new TextBox();
            lbSenhaAtual = new Label();
            btnAtualizaDados = new Button();
            errorProviderEditarPerfil = new ErrorProvider(components);
            toolTipEditarPerfil = new ToolTip(components);
            pbAnimacaoAtualizacao = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            gpBoxSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderEditarPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnimacaoAtualizacao).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBoxEmail);
            groupBox2.Controls.Add(lbEmail);
            groupBox2.Controls.Add(btnTrocarFoto);
            groupBox2.Controls.Add(txtBoxNome);
            groupBox2.Controls.Add(pbFoto);
            groupBox2.Controls.Add(lbNome);
            groupBox2.Controls.Add(txtBoxApelido);
            groupBox2.Controls.Add(lbApelido);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(519, 197);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(191, 136);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(300, 23);
            txtBoxEmail.TabIndex = 7;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.ForeColor = SystemColors.ButtonHighlight;
            lbEmail.Location = new Point(191, 117);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(51, 16);
            lbEmail.TabIndex = 8;
            lbEmail.Text = "E-mail";
            // 
            // btnTrocarFoto
            // 
            btnTrocarFoto.Location = new Point(25, 152);
            btnTrocarFoto.Name = "btnTrocarFoto";
            btnTrocarFoto.Size = new Size(113, 23);
            btnTrocarFoto.TabIndex = 1;
            btnTrocarFoto.Text = "Trocar Foto";
            btnTrocarFoto.UseVisualStyleBackColor = true;
            btnTrocarFoto.Click += btnTrocarFoto_Click;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(191, 39);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(300, 23);
            txtBoxNome.TabIndex = 2;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(6, 19);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(150, 127);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNome.ForeColor = SystemColors.ButtonHighlight;
            lbNome.Location = new Point(191, 20);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(48, 16);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome";
            // 
            // txtBoxApelido
            // 
            txtBoxApelido.Location = new Point(191, 87);
            txtBoxApelido.Name = "txtBoxApelido";
            txtBoxApelido.Size = new Size(300, 23);
            txtBoxApelido.TabIndex = 4;
            // 
            // lbApelido
            // 
            lbApelido.AutoSize = true;
            lbApelido.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbApelido.ForeColor = SystemColors.ButtonHighlight;
            lbApelido.Location = new Point(191, 68);
            lbApelido.Name = "lbApelido";
            lbApelido.Size = new Size(61, 16);
            lbApelido.TabIndex = 5;
            lbApelido.Text = "Apelido";
            // 
            // gpBoxSenha
            // 
            gpBoxSenha.Controls.Add(ckBoxTrocarSenha);
            gpBoxSenha.Controls.Add(lbDgitos);
            gpBoxSenha.Controls.Add(txtBoxConfirmarSenha);
            gpBoxSenha.Controls.Add(lbConfirmarSenha);
            gpBoxSenha.Controls.Add(txtBoxNovaSenha);
            gpBoxSenha.Controls.Add(lbNovaSenha);
            gpBoxSenha.Location = new Point(12, 215);
            gpBoxSenha.Name = "gpBoxSenha";
            gpBoxSenha.Size = new Size(520, 39);
            gpBoxSenha.TabIndex = 10;
            gpBoxSenha.TabStop = false;
            // 
            // ckBoxTrocarSenha
            // 
            ckBoxTrocarSenha.AutoSize = true;
            ckBoxTrocarSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckBoxTrocarSenha.ForeColor = SystemColors.ButtonHighlight;
            ckBoxTrocarSenha.Location = new Point(9, 13);
            ckBoxTrocarSenha.Name = "ckBoxTrocarSenha";
            ckBoxTrocarSenha.Size = new Size(98, 19);
            ckBoxTrocarSenha.TabIndex = 7;
            ckBoxTrocarSenha.Text = "Trocar Senha";
            ckBoxTrocarSenha.UseVisualStyleBackColor = true;
            ckBoxTrocarSenha.CheckedChanged += ckBoxTrocarSenha_CheckedChanged;
            // 
            // lbDgitos
            // 
            lbDgitos.AutoSize = true;
            lbDgitos.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbDgitos.ForeColor = Color.LightCoral;
            lbDgitos.Location = new Point(9, 86);
            lbDgitos.Name = "lbDgitos";
            lbDgitos.Size = new Size(214, 15);
            lbDgitos.TabIndex = 6;
            lbDgitos.Text = "* Senha deve ter no mínimo 6 dígitos!";
            lbDgitos.Visible = false;
            // 
            // txtBoxConfirmarSenha
            // 
            txtBoxConfirmarSenha.Location = new Point(221, 60);
            txtBoxConfirmarSenha.Name = "txtBoxConfirmarSenha";
            txtBoxConfirmarSenha.PasswordChar = '*';
            txtBoxConfirmarSenha.Size = new Size(193, 23);
            txtBoxConfirmarSenha.TabIndex = 5;
            txtBoxConfirmarSenha.UseSystemPasswordChar = true;
            txtBoxConfirmarSenha.Visible = false;
            // 
            // lbConfirmarSenha
            // 
            lbConfirmarSenha.AutoSize = true;
            lbConfirmarSenha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbConfirmarSenha.ForeColor = SystemColors.ButtonHighlight;
            lbConfirmarSenha.Location = new Point(221, 41);
            lbConfirmarSenha.Name = "lbConfirmarSenha";
            lbConfirmarSenha.Size = new Size(121, 16);
            lbConfirmarSenha.TabIndex = 4;
            lbConfirmarSenha.Text = "Confirmar Senha";
            lbConfirmarSenha.Visible = false;
            // 
            // txtBoxNovaSenha
            // 
            txtBoxNovaSenha.Location = new Point(9, 60);
            txtBoxNovaSenha.Name = "txtBoxNovaSenha";
            txtBoxNovaSenha.PasswordChar = '*';
            txtBoxNovaSenha.Size = new Size(193, 23);
            txtBoxNovaSenha.TabIndex = 3;
            txtBoxNovaSenha.UseSystemPasswordChar = true;
            txtBoxNovaSenha.Visible = false;
            // 
            // lbNovaSenha
            // 
            lbNovaSenha.AutoSize = true;
            lbNovaSenha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNovaSenha.ForeColor = SystemColors.ButtonHighlight;
            lbNovaSenha.Location = new Point(9, 42);
            lbNovaSenha.Name = "lbNovaSenha";
            lbNovaSenha.Size = new Size(92, 16);
            lbNovaSenha.TabIndex = 2;
            lbNovaSenha.Text = "Nova Senha";
            lbNovaSenha.Visible = false;
            // 
            // txtBoxSenhaAtual
            // 
            txtBoxSenhaAtual.Location = new Point(21, 365);
            txtBoxSenhaAtual.Name = "txtBoxSenhaAtual";
            txtBoxSenhaAtual.PasswordChar = '*';
            txtBoxSenhaAtual.Size = new Size(193, 23);
            txtBoxSenhaAtual.TabIndex = 1;
            txtBoxSenhaAtual.UseSystemPasswordChar = true;
            txtBoxSenhaAtual.Visible = false;
            // 
            // lbSenhaAtual
            // 
            lbSenhaAtual.AutoSize = true;
            lbSenhaAtual.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbSenhaAtual.ForeColor = SystemColors.ButtonHighlight;
            lbSenhaAtual.Location = new Point(18, 347);
            lbSenhaAtual.Name = "lbSenhaAtual";
            lbSenhaAtual.Size = new Size(90, 16);
            lbSenhaAtual.TabIndex = 0;
            lbSenhaAtual.Text = "Senha Atual";
            lbSenhaAtual.Visible = false;
            // 
            // btnAtualizaDados
            // 
            btnAtualizaDados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizaDados.Location = new Point(378, 362);
            btnAtualizaDados.Name = "btnAtualizaDados";
            btnAtualizaDados.Size = new Size(154, 65);
            btnAtualizaDados.TabIndex = 11;
            btnAtualizaDados.Text = "ATUALIZAR DADOS";
            btnAtualizaDados.UseVisualStyleBackColor = true;
            btnAtualizaDados.Click += btnAtualizaDados_Click;
            // 
            // errorProviderEditarPerfil
            // 
            errorProviderEditarPerfil.ContainerControl = this;
            // 
            // pbAnimacaoAtualizacao
            // 
            pbAnimacaoAtualizacao.Image = Properties.Resources.atualizaDadosAnim;
            pbAnimacaoAtualizacao.Location = new Point(76, 333);
            pbAnimacaoAtualizacao.Name = "pbAnimacaoAtualizacao";
            pbAnimacaoAtualizacao.Size = new Size(255, 95);
            pbAnimacaoAtualizacao.SizeMode = PictureBoxSizeMode.Zoom;
            pbAnimacaoAtualizacao.TabIndex = 12;
            pbAnimacaoAtualizacao.TabStop = false;
            pbAnimacaoAtualizacao.Visible = false;
            // 
            // frmEditarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 101, 25);
            ClientSize = new Size(544, 440);
            Controls.Add(pbAnimacaoAtualizacao);
            Controls.Add(btnAtualizaDados);
            Controls.Add(gpBoxSenha);
            Controls.Add(groupBox2);
            Controls.Add(txtBoxSenhaAtual);
            Controls.Add(lbSenhaAtual);
            Name = "frmEditarPerfil";
            Text = "Editar Perfil";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            gpBoxSenha.ResumeLayout(false);
            gpBoxSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderEditarPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnimacaoAtualizacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtBoxEmail;
        private Label lbEmail;
        private Button btnTrocarFoto;
        private TextBox txtBoxNome;
        private PictureBox pbFoto;
        private Label lbNome;
        private TextBox txtBoxApelido;
        private Label lbApelido;
        private GroupBox gpBoxSenha;
        private TextBox txtBoxConfirmarSenha;
        private Label lbConfirmarSenha;
        private TextBox txtBoxNovaSenha;
        private Label lbNovaSenha;
        private TextBox txtBoxSenhaAtual;
        private Label lbSenhaAtual;
        private Button btnAtualizaDados;
        private SplitContainer splitContainer1;
        private ErrorProvider errorProviderEditarPerfil;
        private ToolTip toolTipEditarPerfil;
        private Label lbDgitos;
        private CheckBox ckBoxTrocarSenha;
        private PictureBox pbAnimacaoAtualizacao;
    }
}