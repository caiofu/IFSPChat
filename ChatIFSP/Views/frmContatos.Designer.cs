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
            llbEditarPerfil = new LinkLabel();
            lbApelido = new Label();
            btnAdicionarContatos = new Button();
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
            groupBox1.Controls.Add(llbEditarPerfil);
            groupBox1.Controls.Add(lbApelido);
            groupBox1.Controls.Add(btnAdicionarContatos);
            groupBox1.Controls.Add(lbNomeUsuario);
            groupBox1.Controls.Add(picBoxUsuario);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
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
            lbApelido.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbApelido.Location = new Point(159, 64);
            lbApelido.Name = "lbApelido";
            lbApelido.Size = new Size(48, 15);
            lbApelido.TabIndex = 3;
            lbApelido.Text = "Apelido";
            // 
            // btnAdicionarContatos
            // 
            btnAdicionarContatos.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdicionarContatos.CausesValidation = false;
            btnAdicionarContatos.Location = new Point(151, 111);
            btnAdicionarContatos.Name = "btnAdicionarContatos";
            btnAdicionarContatos.Size = new Size(133, 23);
            btnAdicionarContatos.TabIndex = 2;
            btnAdicionarContatos.Text = "Adicionar Contato";
            btnAdicionarContatos.UseVisualStyleBackColor = true;
            btnAdicionarContatos.Click += btnAdicionarContatos_Click;
            // 
            // lbNomeUsuario
            // 
            lbNomeUsuario.AutoSize = true;
            lbNomeUsuario.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeUsuario.Location = new Point(147, 40);
            lbNomeUsuario.Name = "lbNomeUsuario";
            lbNomeUsuario.Size = new Size(40, 15);
            lbNomeUsuario.TabIndex = 1;
            lbNomeUsuario.Text = "Nome";
            // 
            // picBoxUsuario
            // 
            picBoxUsuario.Image = (Image)resources.GetObject("picBoxUsuario.Image");
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
            panelContatoOffline.Size = new Size(140, 17);
            panelContatoOffline.TabIndex = 3;
            // 
            // lbContatosOffline
            // 
            lbContatosOffline.AutoSize = true;
            lbContatosOffline.Cursor = Cursors.Hand;
            lbContatosOffline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbContatosOffline.Location = new Point(15, 0);
            lbContatosOffline.Name = "lbContatosOffline";
            lbContatosOffline.Size = new Size(116, 15);
            lbContatosOffline.TabIndex = 0;
            lbContatosOffline.Text = "Contatos Offline (0)";
            lbContatosOffline.Click += lbContatosOffline_Click;
            // 
            // pbSetaContatoOffline
            // 
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
            panelSolicitacoesMensagens.Size = new Size(203, 15);
            panelSolicitacoesMensagens.TabIndex = 4;
            // 
            // lbSolicitacoesMensagens
            // 
            lbSolicitacoesMensagens.AutoSize = true;
            lbSolicitacoesMensagens.Cursor = Cursors.Hand;
            lbSolicitacoesMensagens.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSolicitacoesMensagens.Location = new Point(15, 0);
            lbSolicitacoesMensagens.Name = "lbSolicitacoesMensagens";
            lbSolicitacoesMensagens.Size = new Size(172, 15);
            lbSolicitacoesMensagens.TabIndex = 0;
            lbSolicitacoesMensagens.Text = "Solicitações de Mensagens (0)";
            lbSolicitacoesMensagens.Click += lbSolicitacoesMensagens_Click;
            // 
            // pbSetaSolicitacoesMensagens
            // 
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
            panelContatosOnline.Size = new Size(140, 17);
            panelContatosOnline.TabIndex = 4;
            // 
            // lbContatosOnline
            // 
            lbContatosOnline.AutoSize = true;
            lbContatosOnline.Cursor = Cursors.Hand;
            lbContatosOnline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbContatosOnline.Location = new Point(15, 0);
            lbContatosOnline.Name = "lbContatosOnline";
            lbContatosOnline.Size = new Size(113, 15);
            lbContatosOnline.TabIndex = 0;
            lbContatosOnline.Text = "Contatos Online (0)";
            lbContatosOnline.Click += lbContatosOnline_Click;
            // 
            // pbSetaContatoOnline
            // 
            pbSetaContatoOnline.Image = Properties.Resources.seta_baixo;
            pbSetaContatoOnline.Location = new Point(0, 0);
            pbSetaContatoOnline.Name = "pbSetaContatoOnline";
            pbSetaContatoOnline.Size = new Size(15, 15);
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
            MaximumSize = new Size(500, 750);
            MinimumSize = new Size(500, 700);
            Name = "frmContatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IF Chat | Contatos";
            Load += frmContatos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnAdicionarContatos;
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
    }
}