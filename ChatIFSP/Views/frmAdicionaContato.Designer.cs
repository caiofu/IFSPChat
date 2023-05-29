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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionaContato));
			label1 = new Label();
			txtBoxEmail = new TextBox();
			btnBuscar = new Button();
			flowLayoutPanelResultadoContatos = new FlowLayoutPanel();
			picBoxAnimacaoBusca = new PictureBox();
			toolTipEmail = new ToolTip(components);
			flowLayoutPanelResultadoContatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picBoxAnimacaoBusca).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("DejaVu Sans Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(43, 34);
			label1.Name = "label1";
			label1.Size = new Size(125, 15);
			label1.TabIndex = 0;
			label1.Text = "E-mail do Contato";
			// 
			// txtBoxEmail
			// 
			txtBoxEmail.Location = new Point(43, 52);
			txtBoxEmail.Name = "txtBoxEmail";
			txtBoxEmail.Size = new Size(403, 23);
			txtBoxEmail.TabIndex = 1;
			// 
			// btnBuscar
			// 
			btnBuscar.BackColor = SystemColors.ButtonHighlight;
			btnBuscar.Font = new Font("DejaVu Sans Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnBuscar.Location = new Point(452, 52);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(75, 23);
			btnBuscar.TabIndex = 2;
			btnBuscar.Text = "Buscar";
			btnBuscar.UseVisualStyleBackColor = false;
			btnBuscar.Click += btnBuscar_Click;
			// 
			// flowLayoutPanelResultadoContatos
			// 
			flowLayoutPanelResultadoContatos.Controls.Add(picBoxAnimacaoBusca);
			flowLayoutPanelResultadoContatos.Location = new Point(43, 91);
			flowLayoutPanelResultadoContatos.Name = "flowLayoutPanelResultadoContatos";
			flowLayoutPanelResultadoContatos.Size = new Size(484, 176);
			flowLayoutPanelResultadoContatos.TabIndex = 3;
			// 
			// picBoxAnimacaoBusca
			// 
			picBoxAnimacaoBusca.Image = Properties.Resources.animacaoBusca;
			picBoxAnimacaoBusca.Location = new Point(3, 3);
			picBoxAnimacaoBusca.Name = "picBoxAnimacaoBusca";
			picBoxAnimacaoBusca.Size = new Size(481, 173);
			picBoxAnimacaoBusca.SizeMode = PictureBoxSizeMode.Zoom;
			picBoxAnimacaoBusca.TabIndex = 4;
			picBoxAnimacaoBusca.TabStop = false;
			picBoxAnimacaoBusca.Visible = false;
			// 
			// frmAdicionaContato
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(8, 101, 25);
			ClientSize = new Size(578, 365);
			Controls.Add(flowLayoutPanelResultadoContatos);
			Controls.Add(btnBuscar);
			Controls.Add(txtBoxEmail);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmAdicionaContato";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Adicionar Contato";
			flowLayoutPanelResultadoContatos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picBoxAnimacaoBusca).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtBoxEmail;
		private Button btnBuscar;
		private FlowLayoutPanel flowLayoutPanelResultadoContatos;
		private PictureBox picBoxAnimacaoBusca;
		private ToolTip toolTipEmail;
	}
}