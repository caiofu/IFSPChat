using ChatIFSP.Controllers;
using ChatIFSP.Models;
using ChatIFSP.Views;
using System.Drawing.Drawing2D;
using System.Threading;
namespace ChatIFSP
{
	public partial class frmLogin : Form
	{
		Thread ThLogin;//Colocando em outra Thread para fechar essa janela sem problemas
		private int idUsuarioLogado;
		public frmLogin()
		{

			InitializeComponent();


		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			
			//Validações
			Usuarios usuarios = new Usuarios();

			usuarios.email = txtBoxEmail.Text;
			usuarios.senha = txtBoxSenha.Text;

			errorProviderLogin.Clear();


			bool erros = false;

			if (usuarios.email == "")
			{
				errorProviderLogin.SetError(txtBoxEmail, "Você precisa digitar um email!");
				erros = true;
			}

			if (usuarios.senha == "")
			{
				errorProviderLogin.SetError(txtBoxSenha, "Você precisa digitar uma senha!");
				erros = true;
			}

			if (erros == false)
			{
				try
				{
					int idUsuario = UsuariosController.Login(usuarios.email, usuarios.senha);
					if (idUsuario != 0)
					{
                        MostraLoading();
                        idUsuarioLogado = idUsuario;
						this.Close();
						//Trecho responsavel para abrir uma nova janela e fechar a anterior sem que ela fique na memoria
						//Criamos uma Thread para lidar com isso
						ThLogin = new Thread(AbrirJanelaContatos);
						ThLogin.SetApartmentState(ApartmentState.STA); //Configura o estado antes dele ser iniciado (Single)
						ThLogin.Start();
						// ---------------------------------------------//

						//frmContatos frmContatosNovo = new frmContatos();
						// frmContatosNovo.Show();

						//progressBarLogin.Visible = false;
						EscondeLoading();
					}
					else
					{
						MessageBox.Show("Usuario não existe");
						//progressBarLogin.Visible = false;
						EscondeLoading();
					}

				}
				catch (Exception ex)
				{
					System.Console.WriteLine(ex);
				}
			}

		}

		private void linkLabelInscreva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void MostraLoading()
		{
			//Desabilita elementos
			txtBoxEmail.Enabled = false;
			txtBoxSenha.Enabled = false;

			//Esconde campos
			lbAindaNaoConta.Visible = false;
			linkLabelInscreva.Visible = false;

			//Texto botao
			btnEntrar.Text = "Entrando...";
			//Loading bar
			progressBarLogin.Visible = true;
		}
		private void EscondeLoading()
		{
			//HAbilita elementos
			txtBoxEmail.Enabled = true;
			txtBoxSenha.Enabled = true;

			//Mostra campos
			lbAindaNaoConta.Visible = true;
			linkLabelInscreva.Visible = true;

			//Texto botao
			btnEntrar.Text = "Entrar";

			//Loading bar
			progressBarLogin.Visible = false;
		}

		private void AbrirJanelaContatos(object obj)
		{
			Application.Run(new frmContatos(idUsuarioLogado));

		}
	}
}