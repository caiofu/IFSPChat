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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lbNomeContato.Size = new Size(143, 22);
            lbNomeContato.TabIndex = 1;
            lbNomeContato.Text = "Nome do contato";
            lbNomeContato.Click += userControlContatos_Click;
            // 
            // userControlContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbNomeContato);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            Name = "userControlContatos";
            Size = new Size(229, 29);
            Load += userControlContatos_Load;
            Click += userControlContatos_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbNomeContato;
    }
}
