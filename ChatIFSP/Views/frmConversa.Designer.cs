namespace ChatIFSP.Views
{
    partial class frmConversa
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
            this.components = new System.ComponentModel.Container();
            this.rtbConversa = new System.Windows.Forms.RichTextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pcbContato = new System.Windows.Forms.PictureBox();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.tmrConversa = new System.Windows.Forms.Timer(this.components);
            this.btnAdicionaSolicitacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbConversa
            // 
            this.rtbConversa.Location = new System.Drawing.Point(12, 58);
            this.rtbConversa.Name = "rtbConversa";
            this.rtbConversa.ReadOnly = true;
            this.rtbConversa.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbConversa.Size = new System.Drawing.Size(415, 287);
            this.rtbConversa.TabIndex = 2;
            this.rtbConversa.Text = "";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 351);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(346, 60);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMensagem_KeyUp);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(364, 351);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(63, 60);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            this.btnEnviar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMensagem_KeyUp);
            // 
            // pcbContato
            // 
            this.pcbContato.Image = global::ChatIFSP.Properties.Resources.mystery;
            this.pcbContato.Location = new System.Drawing.Point(433, 58);
            this.pcbContato.Name = "pcbContato";
            this.pcbContato.Size = new System.Drawing.Size(159, 159);
            this.pcbContato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbContato.TabIndex = 3;
            this.pcbContato.TabStop = false;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Image = global::ChatIFSP.Properties.Resources.mystery;
            this.pcbUsuario.Location = new System.Drawing.Point(433, 254);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(159, 157);
            this.pcbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUsuario.TabIndex = 4;
            this.pcbUsuario.TabStop = false;
            // 
            // tmrConversa
            // 
            this.tmrConversa.Enabled = true;
            this.tmrConversa.Interval = 500;
            this.tmrConversa.Tick += new System.EventHandler(this.tmrConversa_Tick);
            // 
            // btnAdicionaSolicitacao
            // 
            this.btnAdicionaSolicitacao.Enabled = false;
            this.btnAdicionaSolicitacao.Location = new System.Drawing.Point(12, 30);
            this.btnAdicionaSolicitacao.Name = "btnAdicionaSolicitacao";
            this.btnAdicionaSolicitacao.Size = new System.Drawing.Size(415, 22);
            this.btnAdicionaSolicitacao.TabIndex = 5;
            this.btnAdicionaSolicitacao.Text = "+ Aceitar solicitação de amizade";
            this.btnAdicionaSolicitacao.UseVisualStyleBackColor = true;
            this.btnAdicionaSolicitacao.Visible = false;
            this.btnAdicionaSolicitacao.Click += new System.EventHandler(this.btnAdicionaSolicitacao_Click);
            // 
            // frmConversa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(101)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(600, 423);
            this.Controls.Add(this.btnAdicionaSolicitacao);
            this.Controls.Add(this.pcbUsuario);
            this.Controls.Add(this.pcbContato);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.rtbConversa);
            this.Name = "frmConversa";
            this.Text = "Conversa";
            this.Load += new System.EventHandler(this.frmConversa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtMensagem;
        private Button btnEnviar;
        private PictureBox pcbContato;
        private PictureBox pcbUsuario;
        public RichTextBox rtbConversa;
        private System.Windows.Forms.Timer tmrConversa;
        private Button btnAdicionaSolicitacao;
    }
}