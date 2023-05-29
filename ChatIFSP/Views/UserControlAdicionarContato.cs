using ChatIFSP.Controllers;
using ChatIFSP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatIFSP.Views
{
	public partial class UserControlAdicionarContato : UserControl
	{
		private int idContato;
		PictureBox picBoxAnimacao = new PictureBox();


		public UserControlAdicionarContato(Usuarios usuario)
		{
			InitializeComponent();

			lbNomeUsuario.Text = usuario.nome;
			lbApelido.Text = usuario.apelido;
			idContato = usuario.idUsuario;



			//Carregando a foto
			byte[] imagemBytes = Convert.FromBase64String(usuario.foto);

			using (MemoryStream ms = new MemoryStream(imagemBytes))
			{
				pbFotoContato.Image = Image.FromStream(ms);
			}

			///Verifica se o contato ja esta adicionado para desabilitar o botao de adicionar 
			if (ContatosController.VerificaPossuiContato(UsuariosController.idUsuarioLogado, usuario.idUsuario))
			{
				Label lbMensagem = new Label();
				lbMensagem.Text = "Já adicionado";
				lbMensagem.ForeColor = Color.Red;
				//lbMensagem.Font = new Font(lbMensagem.Font, FontStyle.Bold);
				lbMensagem.Font = new Font("DejaVu Sans", 9, FontStyle.Bold);
				lbMensagem.AutoSize = true;


				lbMensagem.Location = btnAdicionarContato.Location;
				gpBoxBorda.Controls.Remove(btnAdicionarContato);
				gpBoxBorda.Controls.Add(lbMensagem);
			}

		}

		private void btnAdicionarContato_Click(object sender, EventArgs e)
		{

			AnimacaoAdicionandoCad(true);
			Task.Run(() =>
			{

				if (ContatosController.AdicionaContato(idContato))
				{
					//MessageBox.Show("Contato adicionado com sucesso");
					//Invoke para garantir que que seja alterado na Thread correta
					this.Invoke((MethodInvoker)(() =>
					{
						AnimacaoAdicionandoCad(false);
						Label lbSucesso = new Label();
						lbSucesso.Text = "Adicionado com sucesso";
						lbSucesso.ForeColor = Color.White;
						lbSucesso.Font = new Font("DejaVu Sans", 13, FontStyle.Bold);
						lbSucesso.AutoSize = true;
					//	int xPos = (gpBoxBorda.Width - lbSucesso.Width) / 2;
						//int yPos = (gpBoxBorda.Height - lbSucesso.Height) / 2;
						//lbSucesso.Location = new Point(xPos, yPos);
						gpBoxBorda.Parent.Controls.Add(lbSucesso);
						gpBoxBorda.Parent.Controls.Remove(gpBoxBorda);
					}));
					
				}
				else
				{
					this.Invoke((MethodInvoker)(() =>
					{
						AnimacaoAdicionandoCad(false);
						MessageBox.Show("Não foi possível adicionar o contato");

					}));
				}
			});
			//AnimacaoAdicionandoCad(false);

		}

		private void AnimacaoAdicionandoCad(bool ativando)
		{
			
			//Label lbMensagem = new Label();
			if (ativando)
			{
				
				// Configurar o PictureBox
				picBoxAnimacao.Size = gpBoxBorda.Size;
				picBoxAnimacao.Location = gpBoxBorda.Location;
				picBoxAnimacao.SizeMode = PictureBoxSizeMode.Zoom;
				picBoxAnimacao.Image = Properties.Resources.animaAdd;
				btnAdicionarContato.Enabled = false;
				gpBoxBorda.Visible = false;
				this.Controls.Add(picBoxAnimacao);
			}
			else
			{
				picBoxAnimacao.Visible = false;
				gpBoxBorda.Visible = true;
			}

		}



	}
}
