namespace ChatIFSP
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtBoxEmail = new TextBox();
            txtBoxSenha = new TextBox();
            lbSenha = new Label();
            lbAindaNaoConta = new Label();
            linkLabelInscreva = new LinkLabel();
            btnEntrar = new Button();
            errorProviderLogin = new ErrorProvider(components);
            progressBarLogin = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(49, 253);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 1;
            label1.Text = "E-mail";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(49, 279);
            txtBoxEmail.MaximumSize = new Size(230, 25);
            txtBoxEmail.MinimumSize = new Size(230, 25);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(230, 25);
            txtBoxEmail.TabIndex = 0;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Location = new Point(49, 339);
            txtBoxSenha.MaximumSize = new Size(230, 25);
            txtBoxSenha.MinimumSize = new Size(230, 25);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(230, 25);
            txtBoxSenha.TabIndex = 1;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSenha.ForeColor = SystemColors.ButtonFace;
            lbSenha.Location = new Point(49, 313);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(57, 23);
            lbSenha.TabIndex = 3;
            lbSenha.Text = "Senha";
            // 
            // lbAindaNaoConta
            // 
            lbAindaNaoConta.AutoSize = true;
            lbAindaNaoConta.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbAindaNaoConta.ForeColor = SystemColors.ButtonFace;
            lbAindaNaoConta.Location = new Point(63, 460);
            lbAindaNaoConta.Name = "lbAindaNaoConta";
            lbAindaNaoConta.Size = new Size(215, 23);
            lbAindaNaoConta.TabIndex = 4;
            lbAindaNaoConta.Text = "Ainda não tem uma conta?";
            // 
            // linkLabelInscreva
            // 
            linkLabelInscreva.AutoSize = true;
            linkLabelInscreva.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelInscreva.LinkColor = Color.Cyan;
            linkLabelInscreva.Location = new Point(111, 483);
            linkLabelInscreva.Name = "linkLabelInscreva";
            linkLabelInscreva.Size = new Size(99, 23);
            linkLabelInscreva.TabIndex = 3;
            linkLabelInscreva.TabStop = true;
            linkLabelInscreva.Text = "Inscreva-se";
            linkLabelInscreva.LinkClicked += linkLabelInscreva_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(141, 199, 63);
            btnEntrar.FlatAppearance.BorderSize = 2;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.ImageAlign = ContentAlignment.TopRight;
            btnEntrar.Location = new Point(111, 382);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(102, 33);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // errorProviderLogin
            // 
            errorProviderLogin.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProviderLogin.ContainerControl = this;
            // 
            // progressBarLogin
            // 
            progressBarLogin.Location = new Point(88, 421);
            progressBarLogin.Name = "progressBarLogin";
            progressBarLogin.Size = new Size(137, 23);
            progressBarLogin.Style = ProgressBarStyle.Marquee;
            progressBarLogin.TabIndex = 8;
            progressBarLogin.Visible = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 101, 25);
            ClientSize = new Size(320, 578);
            Controls.Add(progressBarLogin);
            Controls.Add(btnEntrar);
            Controls.Add(linkLabelInscreva);
            Controls.Add(lbAindaNaoConta);
            Controls.Add(txtBoxSenha);
            Controls.Add(lbSenha);
            Controls.Add(txtBoxEmail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtBoxEmail;
        private TextBox txtBoxSenha;
        private Label lbSenha;
        private Label lbAindaNaoConta;
        private LinkLabel linkLabelInscreva;
        private Button btnEntrar;
        private ErrorProvider errorProviderLogin;
        private ProgressBar progressBarLogin;
    }
}