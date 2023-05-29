using ChatIFSP.Controllers;
using ChatIFSP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatIFSP.Views
{
	public partial class frmAdicionaContato : Form
	{
		public frmAdicionaContato()
		{
			InitializeComponent();
		}

		private async void btnBuscar_Click(object sender, EventArgs e)
		{
			// Limpar o painel de resultados
			flowLayoutPanelResultadoContatos.Controls.Clear();
			//Pesquisar se usuario existe
			if (Validacoes() == false)
			{
				AnimacaoBuscandoContatos(true);
				Usuarios usuario = new Usuarios();
				usuario = UsuariosController.VerficaUsuarioExiste(txtBoxEmail.Text);
				if (usuario.idUsuario > 0)
				{
					await Task.Delay(2000); //Definindo um atraso de 2 segundos para animação rolar antes de mostrar o resultado.
					//flowLayoutPanelResultadoContatos.Controls.Clear();
					flowLayoutPanelResultadoContatos.Controls.Add(new UserControlAdicionarContato(usuario));

				}
				else
				{
					// Adicionar o Label informando que não existem resultados
					Label lbMensagem = new Label();
					lbMensagem.Text = "Não existem resultados";
					lbMensagem.ForeColor = Color.White;
					lbMensagem.AutoSize = true;  // Define o tamanho do Label para se ajustar ao texto
					lbMensagem.TextAlign = ContentAlignment.MiddleCenter;  // Centraliza o texto no Label
					lbMensagem.Font = new Font("DejaVu Sans", 13, FontStyle.Bold);

					//flowLayoutPanelResultadoContatos.Controls.Clear();
					flowLayoutPanelResultadoContatos.Controls.Add(lbMensagem);
				}
				AnimacaoBuscandoContatos(false);
			}


		}

		private bool Validacoes()
		{
			bool erros = false;
			// Expressão regular para validar o formato do email
			string regEmail = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

			//Campo vazio
			if (txtBoxEmail.Text == "")
			{
				toolTipEmail.ToolTipIcon = ToolTipIcon.Warning;
				toolTipEmail.Show("Campo não pode ser vazio!", txtBoxEmail);
				erros = true;
			}
			//Se o campo é email
			else if (Regex.IsMatch(txtBoxEmail.Text, regEmail) == false)
			{
				toolTipEmail.ToolTipIcon = ToolTipIcon.Warning;
				toolTipEmail.Show("Email precisa estar no formato correto exemplo@texto.com!", txtBoxEmail);
				erros = true;
			}
			return erros;
		}



		private void AnimacaoBuscandoContatos(bool ativado)
		{

		
			if (ativado)
			{
				txtBoxEmail.Enabled = false;
				btnBuscar.Enabled = false;
				picBoxAnimacaoBusca.Visible = true;
				flowLayoutPanelResultadoContatos.Controls.Add(picBoxAnimacaoBusca);
			}
			else
			{
				txtBoxEmail.Enabled = true;
				btnBuscar.Enabled = true;
				picBoxAnimacaoBusca.Visible = false;
				flowLayoutPanelResultadoContatos.Controls.Remove(picBoxAnimacaoBusca);
			}

		}
	}
}
