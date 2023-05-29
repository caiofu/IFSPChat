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
			label1 = new Label();
			label2 = new Label();
			gpBoxBorda = new GroupBox();
			btnAdicionarContato = new Button();
			((System.ComponentModel.ISupportInitialize)pbFotoContato).BeginInit();
			gpBoxBorda.SuspendLayout();
			SuspendLayout();
			// 
			// pbFotoContato
			// 
			pbFotoContato.Image = Properties.Resources.mystery;
			pbFotoContato.Location = new Point(7, 19);
			pbFotoContato.Name = "pbFotoContato";
			pbFotoContato.Size = new Size(107, 81);
			pbFotoContato.SizeMode = PictureBoxSizeMode.Zoom;
			pbFotoContato.TabIndex = 0;
			pbFotoContato.TabStop = false;
			// 
			// lbNomeUsuario
			// 
			lbNomeUsuario.AutoSize = true;
			lbNomeUsuario.Font = new Font("DejaVu Sans Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lbNomeUsuario.ForeColor = SystemColors.ButtonHighlight;
			lbNomeUsuario.Location = new Point(175, 33);
			lbNomeUsuario.Name = "lbNomeUsuario";
			lbNomeUsuario.Size = new Size(123, 18);
			lbNomeUsuario.TabIndex = 1;
			lbNomeUsuario.Text = "Nome do usuario";
			// 
			// lbApelido
			// 
			lbApelido.AutoSize = true;
			lbApelido.Font = new Font("DejaVu Sans Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lbApelido.ForeColor = SystemColors.ButtonHighlight;
			lbApelido.Location = new Point(192, 63);
			lbApelido.Name = "lbApelido";
			lbApelido.Size = new Size(59, 18);
			lbApelido.TabIndex = 2;
			lbApelido.Text = "Apelido";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("DejaVu Sans Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(120, 63);
			label1.Name = "label1";
			label1.Size = new Size(69, 15);
			label1.TabIndex = 4;
			label1.Text = "APELIDO:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("DejaVu Sans Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(120, 33);
			label2.Name = "label2";
			label2.Size = new Size(52, 15);
			label2.TabIndex = 5;
			label2.Text = "NOME:";
			// 
			// gpBoxBorda
			// 
			gpBoxBorda.Controls.Add(btnAdicionarContato);
			gpBoxBorda.Controls.Add(label2);
			gpBoxBorda.Controls.Add(pbFotoContato);
			gpBoxBorda.Controls.Add(label1);
			gpBoxBorda.Controls.Add(lbNomeUsuario);
			gpBoxBorda.Controls.Add(lbApelido);
			gpBoxBorda.ForeColor = SystemColors.ButtonHighlight;
			gpBoxBorda.Location = new Point(3, -3);
			gpBoxBorda.Name = "gpBoxBorda";
			gpBoxBorda.Size = new Size(477, 111);
			gpBoxBorda.TabIndex = 6;
			gpBoxBorda.TabStop = false;
			// 
			// btnAdicionarContato
			// 
			btnAdicionarContato.AutoSize = true;
			btnAdicionarContato.ForeColor = SystemColors.ActiveCaptionText;
			btnAdicionarContato.Location = new Point(356, 33);
			btnAdicionarContato.Name = "btnAdicionarContato";
			btnAdicionarContato.Size = new Size(102, 49);
			btnAdicionarContato.TabIndex = 3;
			btnAdicionarContato.Text = "ADICIONAR";
			btnAdicionarContato.UseVisualStyleBackColor = true;
			btnAdicionarContato.Click += btnAdicionarContato_Click;
			// 
			// UserControlAdicionarContato
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			Controls.Add(gpBoxBorda);
			Name = "UserControlAdicionarContato";
			Size = new Size(488, 114);
			((System.ComponentModel.ISupportInitialize)pbFotoContato).EndInit();
			gpBoxBorda.ResumeLayout(false);
			gpBoxBorda.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pbFotoContato;
		private Label lbNomeUsuario;
		private Label lbApelido;
		private Label label1;
		private Label label2;
		private GroupBox gpBoxBorda;
		private Button btnAdicionarContato;
	}
}
