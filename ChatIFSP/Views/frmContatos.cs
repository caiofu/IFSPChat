using ChatIFSP.Controllers;
using ChatIFSP.Models;
using ChatIFSP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace ChatIFSP.Views
{
	public partial class frmContatos : Form
	{
		private int idUsuarioLogado { get; set; }
		private int contaOffline = 0;
		private int contaOnline = 0;
		private int contaSolicitacoesMensagens = 0;

		//Essas duas variaveis servem para atualiza a lista de contatos somente quando alguem add
		private int quantidadeContatos = 0;
		private int quatidadeSolicitacoesMensagens = 0;

		//Variavel para lidar com o time (atualizar lista de contatos)
		private System.Windows.Forms.Timer timerVerificarContatos;



		public frmContatos(int idUsuario)
		{
			InitializeComponent();
			BackgroundDegrade();
			ArredondaBordaFoto();
			idUsuarioLogado = idUsuario;

			timerVerificarContatos = new System.Windows.Forms.Timer();
			timerVerificarContatos.Interval = 3000; // 3 segundos
			timerVerificarContatos.Tick += TimerVerificarContatos_Tick; //Associa o metodo ao controlador de eventos
			timerVerificarContatos.Start();
		}
		private void CarregaContatos(int idUsuario)
		{
			var todosContatos = ContatosController.CarregaDadosContatos(idUsuario);
			//quantidadeContatos = todosContatos.Count(); //Nao esta sumindo contatos quando nao é solicitaçao VERIICAR
			//MessageBox.Show(quantidadeContatos.ToString());
			flowLayoutPanelContatosOnline.Controls.Clear();
			flowLayoutPanelContatosOffline.Controls.Clear();

			foreach (var usuarioContato in todosContatos)
			{

				//Verifica se o contato esta online ou não para separar
				if (usuarioContato.status == 1) //Online
				{
					//contatosOnline.Add(usuarioContato);
					flowLayoutPanelContatosOnline.Controls.Add(new userControlContatos(usuarioContato));
					contaOnline++;
				}
				else if (usuarioContato.status == 0)
				{
					flowLayoutPanelContatosOffline.Controls.Add(new userControlContatos(usuarioContato));
					contaOffline++;
				}
			}




			//Para solicitaçoes de mensagens
			var todasSolicitacoes = ContatosController.CarregaDadosSolicitacaoMensagem(idUsuario);
			quatidadeSolicitacoesMensagens = todasSolicitacoes.Count();
			flowLayoutPanelSolicitacoesMensagens.Controls.Clear();
			foreach (var solicitacaoMensagem in todasSolicitacoes)
			{
				flowLayoutPanelSolicitacoesMensagens.Controls.Add(new userControlContatos(solicitacaoMensagem));
				contaSolicitacoesMensagens++;
			}

			//Atualizando as labels
			lbContatosOffline.Text = "Contatos Offilne(" + contaOffline + ")";
			lbContatosOnline.Text = "Contatos Online(" + contaOnline + ")";
			lbSolicitacoesMensagens.Text = "Solicitações de Mensagens(" + contaSolicitacoesMensagens + ")";

			quantidadeContatos = ContatosController.VerificaQuantidadeContatos(idUsuario);
		}
		private void frmContatos_Load(object sender, EventArgs e)
		{
			try
			{
				//Lista de contatos
				CarregaContatos(idUsuarioLogado);

				//Carregando dados do usuario logado
				Usuarios meuUsuario = new Usuarios();
				meuUsuario = UsuariosController.CarregadadosUsuario(idUsuarioLogado);
				lbNomeUsuario.Text = meuUsuario.nome;
				lbApelido.Text = meuUsuario.apelido;

				//Carregando a foto
				byte[] imagemBytes = Convert.FromBase64String(meuUsuario.foto);

				using (MemoryStream ms = new MemoryStream(imagemBytes))
				{
					picBoxUsuario.Image = Image.FromStream(ms);
				}

			}
			catch (Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}

			//Deixando containers de contatos recolhidos
			//Online
			flowLayoutPanelContatosOnline.Height = 0;
			flowLayoutPanelContatosOnline.Visible = false;
			//Offline
			panelContatoOffline.Location = new Point(2, 25);
			flowLayoutPanelContatosOffline.Location = new Point(3, 37);
			flowLayoutPanelContatosOffline.Height = 0;
			flowLayoutPanelContatosOffline.Visible = false;

			//Solicitações de Mensagens
			panelSolicitacoesMensagens.Location = new Point(2, 47);
			flowLayoutPanelSolicitacoesMensagens.Location = new Point(3, 61);
			flowLayoutPanelSolicitacoesMensagens.Visible = false;
			flowLayoutPanelSolicitacoesMensagens.Height = 0;

		}

		private void BackgroundDegrade()
		{
			Color startColor = Color.FromArgb(8, 101, 25);
			Color endColor = Color.FromArgb(180, 230, 180);

			LinearGradientBrush brush = new LinearGradientBrush(
				this.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

			this.BackgroundImage = new Bitmap(this.Width, this.Height);

			using (Graphics g = Graphics.FromImage(this.BackgroundImage))
			{
				g.FillRectangle(brush, this.ClientRectangle);
			}

		}

		private void ArredondaBordaFoto()
		{
			// Defina a região do PictureBox para ser arredondada com um raio de 10 pixels
			GraphicsPath gp = new GraphicsPath();
			int radius = 26;
			gp.AddLine(radius, 0, picBoxUsuario.Width - radius, 0);
			gp.AddArc(picBoxUsuario.Width - radius, 0, radius, radius, 270, 90);
			gp.AddLine(picBoxUsuario.Width, radius, picBoxUsuario.Width, picBoxUsuario.Height - radius);
			gp.AddArc(picBoxUsuario.Width - radius, picBoxUsuario.Height - radius, radius, radius, 0, 90);
			gp.AddLine(picBoxUsuario.Width - radius, picBoxUsuario.Height, radius, picBoxUsuario.Height);
			gp.AddArc(0, picBoxUsuario.Height - radius, radius, radius, 90, 90);
			gp.AddLine(0, picBoxUsuario.Height - radius, 0, radius);
			gp.AddArc(0, 0, radius, radius, 180, 90);
			Region rg = new Region(gp);
			picBoxUsuario.Region = rg;
		}

		private void btnAdicionarContatos_Click(object sender, EventArgs e)
		{
			frmAdicionaContato AdicionarContato = new frmAdicionaContato();
			AdicionarContato.FormClosed += AdicionarContato_FormClosed; // Associa o evento FormClosed
			AdicionarContato.ShowDialog();
		}

		private void llbEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//Abrir janela de edição de perfil
			frmEditarPerfil EditarPerfil = new frmEditarPerfil(UsuariosController.idUsuarioLogado);
			EditarPerfil.ShowDialog();

		}

		private void lbContatosOffline_Click(object sender, EventArgs e)
		{

			MudaPbSeta("Off");


			//Offline
			panelContatoOffline.Location = new Point(2, 25);
			flowLayoutPanelContatosOffline.Location = new Point(3, 37);
			flowLayoutPanelContatosOffline.Height = 395;
			flowLayoutPanelContatosOffline.Visible = true;

			//Online
			flowLayoutPanelContatosOnline.Height = 0;
			flowLayoutPanelContatosOnline.Visible = false;

			//Solicitações de Mensagens

			panelSolicitacoesMensagens.Location = new Point(2, 453);
			flowLayoutPanelSolicitacoesMensagens.Visible = false;
			flowLayoutPanelSolicitacoesMensagens.Height = 0;
		}

		private void lbSolicitacoesMensagens_Click(object sender, EventArgs e)
		{

			MudaPbSeta("SM");


			//Solicitações de Mensagens
			panelSolicitacoesMensagens.Location = new Point(2, 47);
			flowLayoutPanelSolicitacoesMensagens.Location = new Point(3, 61);
			flowLayoutPanelSolicitacoesMensagens.Visible = true;
			flowLayoutPanelSolicitacoesMensagens.Height = 390;

			//Online
			flowLayoutPanelContatosOnline.Height = 0;
			flowLayoutPanelContatosOnline.Visible = false;

			//Offline
			panelContatoOffline.Location = new Point(2, 25);
			flowLayoutPanelContatosOffline.Location = new Point(3, 37);
			flowLayoutPanelContatosOffline.Height = 0;
			flowLayoutPanelContatosOffline.Visible = false;




		}

		private void lbContatosOnline_Click(object sender, EventArgs e)
		{

			MudaPbSeta("On");

			//Online
			flowLayoutPanelContatosOnline.Height = 398;
			flowLayoutPanelContatosOnline.Visible = true;

			//Offline
			panelContatoOffline.Location = new Point(2, 430);
			flowLayoutPanelContatosOffline.Location = new Point(3, 437);
			flowLayoutPanelContatosOffline.Height = 0;
			flowLayoutPanelContatosOffline.Visible = false;

			//Solicitações de Mensagens

			panelSolicitacoesMensagens.Location = new Point(2, 453);
			flowLayoutPanelSolicitacoesMensagens.Visible = false;
			flowLayoutPanelSolicitacoesMensagens.Height = 0;

		}

		private void MudaPbSeta(String campo)
		{

			// On = Online | Off = Offline | SM = Solicitação de mensagem



			// Definir a rotação para o campo específico
			if (campo == "On")
			{
				if (flowLayoutPanelContatosOnline.Height == 0)
				{
					pbSetaContatoOnline.Image = Properties.Resources.seta_baixo;
					//Reseta
					pbSetaContatoOffline.Image = Properties.Resources.seta;
					pbSetaSolicitacoesMensagens.Image = Properties.Resources.seta;
				}
			}
			else if (campo == "Off")
			{
				if (flowLayoutPanelContatosOffline.Height == 0)
				{
					pbSetaContatoOffline.Image = Properties.Resources.seta_baixo;
					//Reseta
					pbSetaSolicitacoesMensagens.Image = Properties.Resources.seta;
					pbSetaContatoOnline.Image = Properties.Resources.seta;

				}

			}
			else if (campo == "SM")
			{
				if (flowLayoutPanelSolicitacoesMensagens.Height == 0)
				{
					pbSetaSolicitacoesMensagens.Image = Properties.Resources.seta_baixo;
					//Reseta
					pbSetaContatoOnline.Image = Properties.Resources.seta;
					pbSetaContatoOffline.Image = Properties.Resources.seta;
				}

			}

			// Atualizar as imagens
			pbSetaContatoOnline.Refresh();
			pbSetaContatoOffline.Refresh();
			pbSetaSolicitacoesMensagens.Refresh();


		}

		private void AdicionarContato_FormClosed(object sender, FormClosedEventArgs e)
		{
			// A janela frmAdicionaContato foi fechada, então atualizamos a lista de contatos
			contaOffline = 0;
			contaOnline = 0;
			contaSolicitacoesMensagens = 0;
			CarregaContatos(idUsuarioLogado);
		}

		//Timer que vai fica fazendo a requisiçao
		private void TimerVerificarContatos_Tick(object sender, EventArgs e)
		{
			//Verificar antes se teve mudança para depois carregar..
			Task.Run(() =>
			{
				contaOffline = 0;
				contaOnline = 0;
				contaSolicitacoesMensagens = 0;
				//A comparaçao esta com diferente por que pode ser que varie em quem vai ser o maior e menor.
				if (ContatosController.VerificaQuantidadeContatos(idUsuarioLogado) != quantidadeContatos)
				{
					Invoke((MethodInvoker)delegate
					{
						CarregaContatos(idUsuarioLogado);
					});

				}
				if (ContatosController.CarregaDadosSolicitacaoMensagem(idUsuarioLogado).Count() != quatidadeSolicitacoesMensagens)
				{
					Invoke((MethodInvoker)delegate
					{
						CarregaContatos(idUsuarioLogado);
					});
				}
				// Acessar o controle userControlContatos de forma segura usando Invoke ou BeginInvoke


			});

		}
	}
}
