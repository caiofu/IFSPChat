namespace ChatIFSP.Views
{
	partial class frmCadastro
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
			imageList1 = new ImageList(components);
			imageList2 = new ImageList(components);
			lbNome = new Label();
			txtBoxNome = new TextBox();
			lbEmail = new Label();
			txtBoxEmail = new TextBox();
			lbSenha = new Label();
			txtBoxSenha = new TextBox();
			picBoxFotoCadastro = new PictureBox();
			btnCadastrar = new Button();
			lbComfirmarSenha = new Label();
			txtBoxConfirmarSenha = new TextBox();
			groupBox1 = new GroupBox();
			label2 = new Label();
			btnFoto = new Button();
			label1 = new Label();
			txtBoxApelido = new TextBox();
			pictureBoxAguardando = new PictureBox();
			errorProviderCadastro = new ErrorProvider(components);
			toolTipEmail = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)picBoxFotoCadastro).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxAguardando).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProviderCadastro).BeginInit();
			SuspendLayout();
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth8Bit;
			imageList1.ImageSize = new Size(16, 16);
			imageList1.TransparentColor = Color.Transparent;
			// 
			// imageList2
			// 
			imageList2.ColorDepth = ColorDepth.Depth8Bit;
			imageList2.ImageSize = new Size(16, 16);
			imageList2.TransparentColor = Color.Transparent;
			// 
			// lbNome
			// 
			lbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbNome.AutoSize = true;
			lbNome.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lbNome.ForeColor = Color.White;
			lbNome.Location = new Point(196, 22);
			lbNome.Name = "lbNome";
			lbNome.Size = new Size(58, 23);
			lbNome.TabIndex = 0;
			lbNome.Text = "Nome";
			// 
			// txtBoxNome
			// 
			txtBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxNome.Location = new Point(196, 48);
			txtBoxNome.Name = "txtBoxNome";
			txtBoxNome.Size = new Size(423, 29);
			txtBoxNome.TabIndex = 1;
			// 
			// lbEmail
			// 
			lbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbEmail.AutoSize = true;
			lbEmail.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lbEmail.ForeColor = Color.White;
			lbEmail.Location = new Point(197, 155);
			lbEmail.Name = "lbEmail";
			lbEmail.Size = new Size(53, 23);
			lbEmail.TabIndex = 9;
			lbEmail.Text = "Email";
			// 
			// txtBoxEmail
			// 
			txtBoxEmail.BackColor = SystemColors.Window;
			txtBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxEmail.Location = new Point(197, 181);
			txtBoxEmail.Name = "txtBoxEmail";
			txtBoxEmail.Size = new Size(422, 29);
			txtBoxEmail.TabIndex = 3;
			// 
			// lbSenha
			// 
			lbSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbSenha.AutoSize = true;
			lbSenha.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lbSenha.ForeColor = Color.White;
			lbSenha.Location = new Point(197, 225);
			lbSenha.Name = "lbSenha";
			lbSenha.Size = new Size(58, 23);
			lbSenha.TabIndex = 11;
			lbSenha.Text = "Senha";
			// 
			// txtBoxSenha
			// 
			txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxSenha.Location = new Point(197, 251);
			txtBoxSenha.Name = "txtBoxSenha";
			txtBoxSenha.PasswordChar = '*';
			txtBoxSenha.Size = new Size(207, 29);
			txtBoxSenha.TabIndex = 4;
			txtBoxSenha.UseSystemPasswordChar = true;
			// 
			// picBoxFotoCadastro
			// 
			picBoxFotoCadastro.Image = Properties.Resources.mystery;
			picBoxFotoCadastro.Location = new Point(12, 22);
			picBoxFotoCadastro.Name = "picBoxFotoCadastro";
			picBoxFotoCadastro.Size = new Size(171, 160);
			picBoxFotoCadastro.SizeMode = PictureBoxSizeMode.Zoom;
			picBoxFotoCadastro.TabIndex = 8;
			picBoxFotoCadastro.TabStop = false;
			// 
			// btnCadastrar
			// 
			btnCadastrar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnCadastrar.Location = new Point(495, 315);
			btnCadastrar.Name = "btnCadastrar";
			btnCadastrar.Size = new Size(124, 56);
			btnCadastrar.TabIndex = 6;
			btnCadastrar.Text = "CADASTRAR";
			btnCadastrar.UseVisualStyleBackColor = true;
			btnCadastrar.Click += btnEnviar_Click;
			// 
			// lbComfirmarSenha
			// 
			lbComfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbComfirmarSenha.AutoSize = true;
			lbComfirmarSenha.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lbComfirmarSenha.ForeColor = Color.White;
			lbComfirmarSenha.Location = new Point(410, 225);
			lbComfirmarSenha.Name = "lbComfirmarSenha";
			lbComfirmarSenha.Size = new Size(141, 23);
			lbComfirmarSenha.TabIndex = 11;
			lbComfirmarSenha.Text = "Confirmar Senha";
			// 
			// txtBoxConfirmarSenha
			// 
			txtBoxConfirmarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxConfirmarSenha.Location = new Point(410, 251);
			txtBoxConfirmarSenha.Name = "txtBoxConfirmarSenha";
			txtBoxConfirmarSenha.PasswordChar = '*';
			txtBoxConfirmarSenha.Size = new Size(209, 29);
			txtBoxConfirmarSenha.TabIndex = 5;
			txtBoxConfirmarSenha.UseSystemPasswordChar = true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(btnFoto);
			groupBox1.Controls.Add(btnCadastrar);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(txtBoxApelido);
			groupBox1.Controls.Add(txtBoxNome);
			groupBox1.Controls.Add(txtBoxConfirmarSenha);
			groupBox1.Controls.Add(picBoxFotoCadastro);
			groupBox1.Controls.Add(lbNome);
			groupBox1.Controls.Add(lbComfirmarSenha);
			groupBox1.Controls.Add(lbEmail);
			groupBox1.Controls.Add(txtBoxEmail);
			groupBox1.Controls.Add(lbSenha);
			groupBox1.Controls.Add(txtBoxSenha);
			groupBox1.Controls.Add(pictureBoxAguardando);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(642, 411);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.LightCoral;
			label2.Location = new Point(197, 284);
			label2.Name = "label2";
			label2.Size = new Size(210, 15);
			label2.TabIndex = 0;
			label2.Text = "* Senha deve ter no mínimo 6 dígitos";
			// 
			// btnFoto
			// 
			btnFoto.Location = new Point(35, 206);
			btnFoto.Name = "btnFoto";
			btnFoto.Size = new Size(121, 30);
			btnFoto.TabIndex = 7;
			btnFoto.Text = "Upload de Foto";
			btnFoto.UseVisualStyleBackColor = true;
			btnFoto.Click += btnFoto_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(196, 90);
			label1.Name = "label1";
			label1.Size = new Size(72, 23);
			label1.TabIndex = 8;
			label1.Text = "Apelido";
			// 
			// txtBoxApelido
			// 
			txtBoxApelido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtBoxApelido.Location = new Point(197, 116);
			txtBoxApelido.MaxLength = 10;
			txtBoxApelido.Name = "txtBoxApelido";
			txtBoxApelido.Size = new Size(422, 29);
			txtBoxApelido.TabIndex = 2;
			// 
			// pictureBoxAguardando
			// 
			pictureBoxAguardando.BackColor = Color.Transparent;
			pictureBoxAguardando.Image = Properties.Resources.cadastroAnimG1;
			pictureBoxAguardando.Location = new Point(92, 297);
			pictureBoxAguardando.Name = "pictureBoxAguardando";
			pictureBoxAguardando.Size = new Size(504, 108);
			pictureBoxAguardando.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxAguardando.TabIndex = 16;
			pictureBoxAguardando.TabStop = false;
			pictureBoxAguardando.Visible = false;
			// 
			// errorProviderCadastro
			// 
			errorProviderCadastro.BlinkStyle = ErrorBlinkStyle.NeverBlink;
			errorProviderCadastro.ContainerControl = this;
			// 
			// frmCadastro
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(8, 101, 25);
			ClientSize = new Size(668, 435);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "frmCadastro";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cadastro de Usuário";
			((System.ComponentModel.ISupportInitialize)picBoxFotoCadastro).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxAguardando).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProviderCadastro).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private ImageList imageList1;
		private ImageList imageList2;
		private Label lbNome;
		private TextBox txtBoxNome;
		private Label lbEmail;
		private TextBox txtBoxEmail;
		private Label lbSenha;
		public TextBox txtBoxSenha;
		private PictureBox picBoxFotoCadastro;
		private Button btnCadastrar;
		private Label lbComfirmarSenha;
		public TextBox txtBoxConfirmarSenha;
		private GroupBox groupBox1;
		private Button btnFoto;
		private Label label1;
		private TextBox txtBoxApelido;
		private ErrorProvider errorProviderCadastro;
		private PictureBox pictureBoxAguardando;
		private Label label2;
		private ToolTip toolTipEmail;
	}
}