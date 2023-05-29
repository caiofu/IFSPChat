namespace ChatIFSP.Views
{
	partial class frmContatos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContatos));
			groupBox1 = new GroupBox();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			llbEditarPerfil = new LinkLabel();
			lbApelido = new Label();
			lbNomeUsuario = new Label();
			picBoxUsuario = new PictureBox();
			flowLayoutPanelContatosOnline = new FlowLayoutPanel();
			panelContatoOffline = new Panel();
			lbContatosOffline = new Label();
			pbSetaContatoOffline = new PictureBox();
			panelPrincipal = new Panel();
			flowLayoutPanelSolicitacoesMensagens = new FlowLayoutPanel();
			panelSolicitacoesMensagens = new Panel();
			lbSolicitacoesMensagens = new Label();
			pbSetaSolicitacoesMensagens = new PictureBox();
			panelContatosOnline = new Panel();
			lbContatosOnline = new Label();
			pbSetaContatoOnline = new PictureBox();
			flowLayoutPanelContatosOffline = new FlowLayoutPanel();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxUsuario).BeginInit();
			panelContatoOffline.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbSetaContatoOffline).BeginInit();
			panelPrincipal.SuspendLayout();
			panelSolicitacoesMensagens.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbSetaSolicitacoesMensagens).BeginInit();
			panelContatosOnline.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbSetaContatoOnline).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(llbEditarPerfil);
			groupBox1.Controls.Add(lbApelido);
			groupBox1.Controls.Add(lbNomeUsuario);
			groupBox1.Controls.Add(picBoxUsuario);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(460, 145);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Cursor = Cursors.Hand;
			pictureBox1.Image = Properties.Resources.add_user;
			pictureBox1.Location = new Point(422, 108);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(32, 25);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			pictureBox1.Click += btnAdicionarContatos_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("DejaVu Sans Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(128, 64);
			label1.Name = "label1";
			label1.Size = new Size(71, 18);
			label1.TabIndex = 5;
			label1.Text = "Apelido:";
			// 
			// llbEditarPerfil
			// 
			llbEditarPerfil.AutoSize = true;
			llbEditarPerfil.Location = new Point(31, 124);
			llbEditarPerfil.Name = "llbEditarPerfil";
			llbEditarPerfil.Size = new Size(67, 15);
			llbEditarPerfil.TabIndex = 4;
			llbEditarPerfil.TabStop = true;
			llbEditarPerfil.Text = "Editar Perfil";
			llbEditarPerfil.LinkClicked += llbEditarPerfil_LinkClicked;
			// 
			// lbApelido
			// 
			lbApelido.AutoSize = true;
			lbApelido.Font = new Font("DejaVu Sans Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lbApelido.ForeColor = SystemColors.ButtonHighlight;
			lbApelido.Location = new Point(205, 64);
			lbApelido.Name = "lbApelido";
			lbApelido.Size = new Size(66, 18);
			lbApelido.TabIndex = 3;
			lbApelido.Text = "Apelido";
			// 
			// lbNomeUsuario
			// 
			lbNomeUsuario.AutoSize = true;
			lbNomeUsuario.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lbNomeUsuario.ForeColor = SystemColors.ControlLightLight;
			lbNomeUsuario.Location = new Point(128, 28);
			lbNomeUsuario.Name = "lbNomeUsuario";
			lbNomeUsuario.Size = new Size(56, 19);
			lbNomeUsuario.TabIndex = 1;
			lbNomeUsuario.Text = "Nome";
			// 
			// picBoxUsuario
			// 
			picBoxUsuario.Image = Properties.Resources.mystery;
			picBoxUsuario.Location = new Point(6, 21);
			picBoxUsuario.Name = "picBoxUsuario";
			picBoxUsuario.Size = new Size(116, 98);
			picBoxUsuario.SizeMode = PictureBoxSizeMode.Zoom;
			picBoxUsuario.TabIndex = 0;
			picBoxUsuario.TabStop = false;
			// 
			// flowLayoutPanelContatosOnline
			// 
			flowLayoutPanelContatosOnline.AutoScroll = true;
			flowLayoutPanelContatosOnline.BackColor = Color.Transparent;
			flowLayoutPanelContatosOnline.Location = new Point(3, 26);
			flowLayoutPanelContatosOnline.Name = "flowLayoutPanelContatosOnline";
			flowLayoutPanelContatosOnline.Size = new Size(451, 398);
			flowLayoutPanelContatosOnline.TabIndex = 1;
			// 
			// panelContatoOffline
			// 
			panelContatoOffline.Controls.Add(lbContatosOffline);
			panelContatoOffline.Controls.Add(pbSetaContatoOffline);
			panelContatoOffline.Location = new Point(2, 430);
			panelContatoOffline.Name = "panelContatoOffline";
			panelContatoOffline.Size = new Size(231, 17);
			panelContatoOffline.TabIndex = 3;
			// 
			// lbContatosOffline
			// 
			lbContatosOffline.AutoSize = true;
			lbContatosOffline.Cursor = Cursors.Hand;
			lbContatosOffline.Font = new Font("DejaVu Sans Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			lbContatosOffline.ForeColor = SystemColors.ButtonHighlight;
			lbContatosOffline.Location = new Point(15, 0);
			lbContatosOffline.Name = "lbContatosOffline";
			lbContatosOffline.Size = new Size(136, 15);
			lbContatosOffline.TabIndex = 0;
			lbContatosOffline.Text = "Contatos Offline (0)";
			lbContatosOffline.Click += lbContatosOffline_Click;
			// 
			// pbSetaContatoOffline
			// 
			pbSetaContatoOffline.Cursor = Cursors.Hand;
			pbSetaContatoOffline.Image = Properties.Resources.seta;
			pbSetaContatoOffline.Location = new Point(0, -1);
			pbSetaContatoOffline.Name = "pbSetaContatoOffline";
			pbSetaContatoOffline.Size = new Size(13, 15);
			pbSetaContatoOffline.SizeMode = PictureBoxSizeMode.Zoom;
			pbSetaContatoOffline.TabIndex = 2;
			pbSetaContatoOffline.TabStop = false;
			pbSetaContatoOffline.Click += lbContatosOffline_Click;
			// 
			// panelPrincipal
			// 
			panelPrincipal.BackColor = Color.Transparent;
			panelPrincipal.BorderStyle = BorderStyle.Fixed3D;
			panelPrincipal.Controls.Add(panelContatoOffline);
			panelPrincipal.Controls.Add(flowLayoutPanelSolicitacoesMensagens);
			panelPrincipal.Controls.Add(panelSolicitacoesMensagens);
			panelPrincipal.Controls.Add(panelContatosOnline);
			panelPrincipal.Controls.Add(flowLayoutPanelContatosOffline);
			panelPrincipal.Controls.Add(flowLayoutPanelContatosOnline);
			panelPrincipal.Location = new Point(12, 165);
			panelPrincipal.Name = "panelPrincipal";
			panelPrincipal.Size = new Size(460, 484);
			panelPrincipal.TabIndex = 4;
			// 
			// flowLayoutPanelSolicitacoesMensagens
			// 
			flowLayoutPanelSolicitacoesMensagens.AutoScroll = true;
			flowLayoutPanelSolicitacoesMensagens.BackColor = Color.Transparent;
			flowLayoutPanelSolicitacoesMensagens.Location = new Point(2, 476);
			flowLayoutPanelSolicitacoesMensagens.Name = "flowLayoutPanelSolicitacoesMensagens";
			flowLayoutPanelSolicitacoesMensagens.Size = new Size(451, 0);
			flowLayoutPanelSolicitacoesMensagens.TabIndex = 3;
			// 
			// panelSolicitacoesMensagens
			// 
			panelSolicitacoesMensagens.Controls.Add(lbSolicitacoesMensagens);
			panelSolicitacoesMensagens.Controls.Add(pbSetaSolicitacoesMensagens);
			panelSolicitacoesMensagens.Location = new Point(2, 453);
			panelSolicitacoesMensagens.Name = "panelSolicitacoesMensagens";
			panelSolicitacoesMensagens.Size = new Size(231, 15);
			panelSolicitacoesMensagens.TabIndex = 4;
			// 
			// lbSolicitacoesMensagens
			// 
			lbSolicitacoesMensagens.AutoSize = true;
			lbSolicitacoesMensagens.Cursor = Cursors.Hand;
			lbSolicitacoesMensagens.Font = new Font("DejaVu Sans Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			lbSolicitacoesMensagens.ForeColor = SystemColors.ButtonHighlight;
			lbSolicitacoesMensagens.Location = new Point(15, 0);
			lbSolicitacoesMensagens.Name = "lbSolicitacoesMensagens";
			lbSolicitacoesMensagens.Size = new Size(206, 15);
			lbSolicitacoesMensagens.TabIndex = 0;
			lbSolicitacoesMensagens.Text = "Solicitações de Mensagens (0)";
			lbSolicitacoesMensagens.Click += lbSolicitacoesMensagens_Click;
			// 
			// pbSetaSolicitacoesMensagens
			// 
			pbSetaSolicitacoesMensagens.Cursor = Cursors.Hand;
			pbSetaSolicitacoesMensagens.Image = Properties.Resources.seta;
			pbSetaSolicitacoesMensagens.Location = new Point(0, 0);
			pbSetaSolicitacoesMensagens.Name = "pbSetaSolicitacoesMensagens";
			pbSetaSolicitacoesMensagens.Size = new Size(13, 15);
			pbSetaSolicitacoesMensagens.SizeMode = PictureBoxSizeMode.Zoom;
			pbSetaSolicitacoesMensagens.TabIndex = 2;
			pbSetaSolicitacoesMensagens.TabStop = false;
			pbSetaSolicitacoesMensagens.Click += lbSolicitacoesMensagens_Click;
			// 
			// panelContatosOnline
			// 
			panelContatosOnline.Controls.Add(lbContatosOnline);
			panelContatosOnline.Controls.Add(pbSetaContatoOnline);
			panelContatosOnline.Location = new Point(2, 3);
			panelContatosOnline.Name = "panelContatosOnline";
			panelContatosOnline.Size = new Size(183, 17);
			panelContatosOnline.TabIndex = 4;
			// 
			// lbContatosOnline
			// 
			lbContatosOnline.AutoSize = true;
			lbContatosOnline.Cursor = Cursors.Hand;
			lbContatosOnline.Font = new Font("DejaVu Sans Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			lbContatosOnline.ForeColor = SystemColors.ControlLightLight;
			lbContatosOnline.Location = new Point(15, 0);
			lbContatosOnline.Name = "lbContatosOnline";
			lbContatosOnline.Size = new Size(135, 15);
			lbContatosOnline.TabIndex = 0;
			lbContatosOnline.Text = "Contatos Online (0)";
			lbContatosOnline.Click += lbContatosOnline_Click;
			// 
			// pbSetaContatoOnline
			// 
			pbSetaContatoOnline.Cursor = Cursors.Hand;
			pbSetaContatoOnline.Image = Properties.Resources.seta1;
			pbSetaContatoOnline.Location = new Point(0, 0);
			pbSetaContatoOnline.Name = "pbSetaContatoOnline";
			pbSetaContatoOnline.Size = new Size(13, 15);
			pbSetaContatoOnline.SizeMode = PictureBoxSizeMode.Zoom;
			pbSetaContatoOnline.TabIndex = 2;
			pbSetaContatoOnline.TabStop = false;
			pbSetaContatoOnline.Click += lbContatosOnline_Click;
			// 
			// flowLayoutPanelContatosOffline
			// 
			flowLayoutPanelContatosOffline.AutoScroll = true;
			flowLayoutPanelContatosOffline.BackColor = Color.Transparent;
			flowLayoutPanelContatosOffline.Location = new Point(2, 446);
			flowLayoutPanelContatosOffline.Name = "flowLayoutPanelContatosOffline";
			flowLayoutPanelContatosOffline.Size = new Size(451, 0);
			flowLayoutPanelContatosOffline.TabIndex = 2;
			// 
			// frmContatos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DimGray;
			ClientSize = new Size(484, 661);
			Controls.Add(panelPrincipal);
			Controls.Add(groupBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(500, 750);
			MinimumSize = new Size(500, 700);
			Name = "frmContatos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "IF Chat | Contatos";
			Load += frmContatos_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxUsuario).EndInit();
			panelContatoOffline.ResumeLayout(false);
			panelContatoOffline.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbSetaContatoOffline).EndInit();
			panelPrincipal.ResumeLayout(false);
			panelSolicitacoesMensagens.ResumeLayout(false);
			panelSolicitacoesMensagens.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbSetaSolicitacoesMensagens).EndInit();
			panelContatosOnline.ResumeLayout(false);
			panelContatosOnline.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbSetaContatoOnline).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private PictureBox picBoxUsuario;
		private Label lbNomeUsuario;
		private FlowLayoutPanel flowLayoutPanelContatosOnline;
		private Label lbApelido;
		private LinkLabel llbEditarPerfil;
		private Label lbContatosOffline;
		private PictureBox pbSetaContatoOffline;
		private Panel panelContatoOffline;
		private Panel panelPrincipal;
		private FlowLayoutPanel flowLayoutPanelContatosOffline;
		private Panel panelContatosOnline;
		private Label lbContatosOnline;
		private PictureBox pbSetaContatoOnline;
		private FlowLayoutPanel flowLayoutPanelSolicitacoesMensagens;
		private Panel panelSolicitacoesMensagens;
		private Label lbSolicitacoesMensagens;
		private PictureBox pbSetaSolicitacoesMensagens;
		private Label label1;
		private PictureBox pictureBox1;
	}
}