namespace ChatIFSP.Views
{
    partial class frmAdicionaContato
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
            label1 = new Label();
            txtBoxEmail = new TextBox();
            btnBuscar = new Button();
            flowLayoutPanelResultadoContatos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 37);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "E-mail do Contato";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(70, 55);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(403, 23);
            txtBoxEmail.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(479, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // flowLayoutPanelResultadoContatos
            // 
            flowLayoutPanelResultadoContatos.Location = new Point(70, 94);
            flowLayoutPanelResultadoContatos.Name = "flowLayoutPanelResultadoContatos";
            flowLayoutPanelResultadoContatos.Size = new Size(484, 176);
            flowLayoutPanelResultadoContatos.TabIndex = 3;
            // 
            // frmAdicionaContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 414);
            Controls.Add(flowLayoutPanelResultadoContatos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxEmail);
            Controls.Add(label1);
            Name = "frmAdicionaContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxEmail;
        private Button btnBuscar;
        private FlowLayoutPanel flowLayoutPanelResultadoContatos;
    }
}