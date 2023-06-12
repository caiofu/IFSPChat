namespace ChatIFSP.Views
{
    partial class userControlContatos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlContatos));
            pictureBox1 = new PictureBox();
            lbNomeContato = new Label();
            picBoxNovaMensagem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNovaMensagem).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += userControlContatos_Click;
            // 
            // lbNomeContato
            // 
            lbNomeContato.AutoSize = true;
            lbNomeContato.Font = new Font("Calibri", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeContato.Location = new Point(44, 4);
            lbNomeContato.Name = "lbNomeContato";
            lbNomeContato.Size = new Size(95, 22);
            lbNomeContato.TabIndex = 1;
            lbNomeContato.Text = "Apelido123";
            lbNomeContato.Click += userControlContatos_Click;
            // 
            // picBoxNovaMensagem
            // 
            picBoxNovaMensagem.Image = Properties.Resources.message;
            picBoxNovaMensagem.Location = new Point(141, 6);
            picBoxNovaMensagem.Name = "picBoxNovaMensagem";
            picBoxNovaMensagem.Size = new Size(13, 17);
            picBoxNovaMensagem.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxNovaMensagem.TabIndex = 2;
            picBoxNovaMensagem.TabStop = false;
            picBoxNovaMensagem.Visible = false;
            // 
            // userControlContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picBoxNovaMensagem);
            Controls.Add(lbNomeContato);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            Name = "userControlContatos";
            Size = new Size(229, 29);
            Load += userControlContatos_Load;
            Click += userControlContatos_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNovaMensagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbNomeContato;
        private PictureBox picBoxNovaMensagem;
    }
}
