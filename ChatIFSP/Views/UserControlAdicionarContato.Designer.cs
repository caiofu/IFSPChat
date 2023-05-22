namespace ChatIFSP.Views
{
    partial class UserControlAdicionarContato
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
            pbFotoContato = new PictureBox();
            lbNomeUsuario = new Label();
            lbApelido = new Label();
            btnAdicionarContato = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFotoContato).BeginInit();
            SuspendLayout();
            // 
            // pbFotoContato
            // 
            pbFotoContato.Image = Properties.Resources.mystery;
            pbFotoContato.Location = new Point(3, 3);
            pbFotoContato.Name = "pbFotoContato";
            pbFotoContato.Size = new Size(107, 81);
            pbFotoContato.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoContato.TabIndex = 0;
            pbFotoContato.TabStop = false;
            // 
            // lbNomeUsuario
            // 
            lbNomeUsuario.AutoSize = true;
            lbNomeUsuario.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomeUsuario.Location = new Point(171, 17);
            lbNomeUsuario.Name = "lbNomeUsuario";
            lbNomeUsuario.Size = new Size(119, 19);
            lbNomeUsuario.TabIndex = 1;
            lbNomeUsuario.Text = "Nome do usuario";
            // 
            // lbApelido
            // 
            lbApelido.AutoSize = true;
            lbApelido.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbApelido.Location = new Point(188, 47);
            lbApelido.Name = "lbApelido";
            lbApelido.Size = new Size(58, 19);
            lbApelido.TabIndex = 2;
            lbApelido.Text = "Apelido";
            // 
            // btnAdicionarContato
            // 
            btnAdicionarContato.AutoSize = true;
            btnAdicionarContato.Location = new Point(352, 17);
            btnAdicionarContato.Name = "btnAdicionarContato";
            btnAdicionarContato.Size = new Size(102, 49);
            btnAdicionarContato.TabIndex = 3;
            btnAdicionarContato.Text = "ADICIONAR";
            btnAdicionarContato.UseVisualStyleBackColor = true;
            btnAdicionarContato.Click += btnAdicionarContato_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 47);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 4;
            label1.Text = "APELIDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 17);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 5;
            label2.Text = "NOME:";
            // 
            // UserControlAdicionarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdicionarContato);
            Controls.Add(lbApelido);
            Controls.Add(lbNomeUsuario);
            Controls.Add(pbFotoContato);
            Name = "UserControlAdicionarContato";
            Size = new Size(493, 87);
            ((System.ComponentModel.ISupportInitialize)pbFotoContato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFotoContato;
        private Label lbNomeUsuario;
        private Label lbApelido;
        private Button btnAdicionarContato;
        private Label label1;
        private Label label2;
    }
}
