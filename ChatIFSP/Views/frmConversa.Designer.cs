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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversa));
            rtbConversa = new RichTextBox();
            txtMensagem = new TextBox();
            btnEnviar = new Button();
            pcbContato = new PictureBox();
            pictureBox2 = new PictureBox();
            tmrConversa = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pcbContato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // rtbConversa
            // 
            rtbConversa.Location = new Point(12, 58);
            rtbConversa.Name = "rtbConversa";
            rtbConversa.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbConversa.Size = new Size(415, 287);
            rtbConversa.TabIndex = 2;
            rtbConversa.Text = "";
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(12, 351);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(346, 60);
            txtMensagem.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(364, 351);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(63, 60);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // pcbContato
            // 
            pcbContato.Image = (Image)resources.GetObject("pcbContato.Image");
            pcbContato.Location = new Point(433, 58);
            pcbContato.Name = "pcbContato";
            pcbContato.Size = new Size(159, 159);
            pcbContato.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContato.TabIndex = 3;
            pcbContato.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(433, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // tmrConversa
            // 
            tmrConversa.Enabled = true;
            tmrConversa.Interval = 3000;
            tmrConversa.Tick += tmrConversa_Tick;
            // 
            // frmConversa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 423);
            Controls.Add(pictureBox2);
            Controls.Add(pcbContato);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensagem);
            Controls.Add(rtbConversa);
            Name = "frmConversa";
            Text = "Conversa";
            Load += frmConversa_Load;
            ((System.ComponentModel.ISupportInitialize)pcbContato).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMensagem;
        private Button btnEnviar;
        private PictureBox pcbContato;
        private PictureBox pictureBox2;
        public RichTextBox rtbConversa;
        private System.Windows.Forms.Timer tmrConversa;
    }
}