using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatIFSP.Models;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Asn1.Cmp;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using ChatIFSP.Controllers;

namespace ChatIFSP.Views
{
	public partial class frmCadastro : Form
	{

		public frmCadastro()
		{
			InitializeComponent();
		}

		//private Usuarios inicializaDados()
		//{
		//    Usuarios CadastroUsuario = new Usuarios();
		//    CadastroUsuario.nome = txtNome.Text;
		//    CadastroUsuario.email = txtEmail.Text;
		//    CadastroUsuario.senha = txtSenha.Text;

		//    using (Image image = Image.FromFile("caminho/para/minha/imagem.jpg")) //Endereço ainda a ser setado...
		//    {
		//        using (MemoryStream ms = new MemoryStream())
		//        {
		//            image.Save(ms, ImageFormat.Jpeg); // ou outro formato de imagem
		//            byte[] imageBytes = ms.ToArray();
		//            CadastroUsuario.foto = Convert.ToBase64String(imageBytes);
		//        }
		//    }

		//    return CadastroUsuario;
		//}

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			OperacaoDeCadastroTask();
			//try
			//{
			//    //Valida se campos foram preenchidos
			//    if (ValidaCampos() == false)
			//    {
			//        Usuarios novoUsuario = new Usuarios();
			//        novoUsuario.nome = txtBoxNome.Text;
			//        novoUsuario.email = txtBoxEmail.Text;
			//        novoUsuario.apelido = txtBoxApelido.Text;
			//        novoUsuario.senha = txtBoxSenha.Text;

			//        //Foto
			//        String stringFoto = ConverteImagemBase64(picBoxFotoCadastro);
			//        if (stringFoto != null)
			//        {
			//            novoUsuario.foto = stringFoto;
			//        }

			//        //Verifica se usuario existe (esta retornando objeto pq foi aproveitado o metodo de adição de contato
			//        if(UsuariosController.VerficaUsuarioJaCadastrado(txtBoxEmail.Text) == false) //Não esta funcionando essa validaçao
			//        {
			//            //Verifica se foi salvo e fecha a janela
			//            if (UsuariosController.CadastraUsuario(novoUsuario))
			//            {
			//                MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//                this.Close();
			//            }
			//        }
			//        else
			//        {
			//            MessageBox.Show("Já existe um usuario com este E-mail!", "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Information);
			//        }


			//    }
			//}
			//catch (Exception ex) { }
		}


		private void SalvaFoto()
		{

		}

		private void btnFoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog imagem = new OpenFileDialog();
			imagem.Filter = "Imagem JPG | *.jpg";
			DialogResult respota = imagem.ShowDialog();

			//Valida se carregou corretamente
			if (respota == DialogResult.OK)
			{
				picBoxFotoCadastro.ImageLocation = imagem.FileName;

			}
		}

		private bool ValidaCampos()
		{
			bool erros = false;
			// Expressão regular para validar o formato do email
			string regEmail = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

			//NOME
			if (txtBoxNome.Text == "")
			{
				errorProviderCadastro.SetIconPadding(txtBoxNome, 3);
				errorProviderCadastro.SetError(txtBoxNome, "Você precisa digitar um nome!");
				txtBoxNome.BackColor = Color.FromArgb(220, 100, 100);
				erros = true;
			}
			else
			{
				errorProviderCadastro.Clear();
				txtBoxNome.BackColor = Color.White;
			}
			//E-MAIL
			if (txtBoxEmail.Text == "")
			{
				errorProviderCadastro.SetIconPadding(txtBoxEmail, 3);
				errorProviderCadastro.SetError(txtBoxEmail, "Você precisa digitar um email!");
				txtBoxEmail.BackColor = Color.FromArgb(220, 100, 100);


				erros = true;
			}
			//E-MAIL FORMATO
			if (Regex.IsMatch(txtBoxEmail.Text, regEmail) == false)
			{
				errorProviderCadastro.SetIconPadding(txtBoxEmail, 3);
				errorProviderCadastro.SetError(txtBoxEmail, "Email precisa estar no formato correto!");
				txtBoxEmail.BackColor = Color.FromArgb(220, 100, 100);
				toolTipEmail.ToolTipIcon = ToolTipIcon.Error;
				toolTipEmail.Show("Email precisa estar no formato correto!", txtBoxEmail);
				erros = true;
			}
			else
			{
				errorProviderCadastro.Clear();
				txtBoxEmail.BackColor = Color.White;
			}
			//APELIDO
			if (txtBoxApelido.Text == "")
			{
				errorProviderCadastro.SetIconPadding(txtBoxApelido, 3);
				errorProviderCadastro.SetError(txtBoxApelido, "Você precisa digitar um Apelido!");
				txtBoxApelido.BackColor = Color.FromArgb(220, 100, 100);
				erros = true;
			}
			else
			{
				errorProviderCadastro.Clear();
				txtBoxApelido.BackColor = Color.White;
			}
			//SENHA
			if (txtBoxSenha.Text == "")
			{
				//errorProviderCadastro.SetIconPadding(txtBoxSenha, 3);
				//errorProviderCadastro.SetError(txtBoxSenha, "Você precisa digitar uma senha!");
				txtBoxSenha.BackColor = Color.FromArgb(220, 100, 100);
				erros = true;
			}
			else
			{
				errorProviderCadastro.Clear();
				txtBoxSenha.BackColor = Color.White;
			}
			//CONFIRMA SENHA
			if (txtBoxConfirmarSenha.Text == "")
			{
				errorProviderCadastro.SetIconPadding(txtBoxConfirmarSenha, 3);
				errorProviderCadastro.SetError(txtBoxConfirmarSenha, "Você precisa digitar uma senha!");
				txtBoxConfirmarSenha.BackColor = Color.FromArgb(220, 100, 100);
				erros = true;
			}
			else
			{
				errorProviderCadastro.Clear();
				txtBoxConfirmarSenha.BackColor = Color.White;
			}
			//TAMANHO SENHA
			if (txtBoxSenha.Text.Length < 6)
			{
				errorProviderCadastro.SetIconPadding(txtBoxConfirmarSenha, 3);
				errorProviderCadastro.SetError(txtBoxConfirmarSenha, "A senha tem que ter no mínimo 6 dígitos!");
				txtBoxSenha.BackColor = Color.FromArgb(220, 100, 100);
				erros = true;
			}
			else
			{
				errorProviderCadastro.Clear();
				txtBoxSenha.BackColor = Color.White;
			}
			if (txtBoxSenha.Text != txtBoxConfirmarSenha.Text)
			{
				errorProviderCadastro.SetIconPadding(txtBoxConfirmarSenha, 3);
				errorProviderCadastro.SetError(txtBoxConfirmarSenha, "Confirmação de senha diferente de senha!");
				txtBoxConfirmarSenha.BackColor = Color.FromArgb(220, 100, 100);

				MessageBox.Show("Senha e confirmar senha não são iguais! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				erros = true;
			}
			else
			{
				errorProviderCadastro.Clear();
				txtBoxConfirmarSenha.BackColor = Color.White;
			}
			return erros;
		}

		private String ConverteImagemBase64(PictureBox foto)
		{
			String stringFoto = "";
			try
			{
				if (picBoxFotoCadastro.Image != null)
				{
					System.Drawing.Image imagem = picBoxFotoCadastro.Image;
					byte[] imagemBytes;
					using (MemoryStream ms = new MemoryStream())
					{
						imagem.Save(ms, imagem.RawFormat);
						imagemBytes = ms.ToArray();
					}
					// Converta a matriz de bytes em uma representação Base64
					stringFoto = Convert.ToBase64String(imagemBytes);
				}
				else
				{
					//Pegando foto padrão caso usuario nao escolha uma
					string assemblyPath = Assembly.GetExecutingAssembly().Location;
					string resourceFolderPath = Path.GetDirectoryName(assemblyPath);

					//Pegando o caminho da pasta Resources
					string resourceFilePath = Path.Combine(resourceFolderPath, "mystery.jpg");
					byte[] fileBytes = File.ReadAllBytes(resourceFilePath);
					stringFoto = Convert.ToBase64String(fileBytes);
				}

				return stringFoto;
			}
			catch (Exception ex)
			{
				return stringFoto;
			}

		}

		private async void OperacaoDeCadastroTask()
		{

			//Valida se campos foram preenchidos
			if (ValidaCampos() == false)
			{
				// Iniciar animação ou atualização da interface do usuário
				MostraAnimacaoEnviandoCadastro();
				await Task.Run(() =>
				{
					try
					{

						Usuarios novoUsuario = new Usuarios();
						novoUsuario.nome = txtBoxNome.Text;
						novoUsuario.email = txtBoxEmail.Text;
						novoUsuario.apelido = txtBoxApelido.Text;
						novoUsuario.senha = txtBoxSenha.Text;

						//Foto
						String stringFoto = ConverteImagemBase64(picBoxFotoCadastro);
						if (stringFoto != null)
						{
							novoUsuario.foto = stringFoto;
						}

						//Verifica se usuario existe (esta retornando objeto pq foi aproveitado o metodo de adição de contato
						if (UsuariosController.VerficaUsuarioJaCadastrado(txtBoxEmail.Text) == false) //Não esta funcionando essa validaçao
						{
							//Verifica se foi salvo e fecha a janela
							if (UsuariosController.CadastraUsuario(novoUsuario))
							{
								MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

								//Foi usado esse metodo  por conta de que o metodo OperacaoCadastro esta em outra Thread
								//e para fechar a vc tem que executa o this.Close() na Thread da UI
								this.Invoke((MethodInvoker)delegate
								{
									this.Close();
								});
								// EscondeAnimacaoEnviandoCadastro();
							}
						}
						else
						{
							MessageBox.Show("Já existe um usuario com este E-mail!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

						}



					}
					catch (Exception ex) { }
				});
			}
			// Parar animação ou atualização da interface do usuário
			EscondeAnimacaoEnviandoCadastro();
		}

		private void MostraAnimacaoEnviandoCadastro()
		{
			txtBoxNome.Enabled = false;
			txtBoxEmail.Enabled = false;
			txtBoxSenha.Enabled = false;
			txtBoxConfirmarSenha.Enabled = false;
			txtBoxApelido.Enabled = false;
			picBoxFotoCadastro.Enabled = false;
			btnCadastrar.Enabled = false;
			btnCadastrar.Visible = false;
			btnCadastrar.Text = "CADASTRANDO...";
			pictureBoxAguardando.Visible = true;
			pictureBoxAguardando.Enabled = true;

		}

		private void EscondeAnimacaoEnviandoCadastro()
		{
			txtBoxNome.Enabled = true;
			txtBoxEmail.Enabled = true;
			txtBoxSenha.Enabled = true;
			txtBoxConfirmarSenha.Enabled = true;
			txtBoxApelido.Enabled = true;
			picBoxFotoCadastro.Enabled = true;
			pictureBoxAguardando.Visible = false;
			pictureBoxAguardando.Enabled = false;
			btnCadastrar.Enabled = true;
			btnCadastrar.Visible = true;
			btnCadastrar.Text = "CADASTRAR";


		}

		private void txtBoxSenha_TextChanged(object sender, EventArgs e)
		{
			string senha = txtBoxSenha.Text;
			//Salva localização do Cursor antes de alterar a Senha
			int cursorPos = txtBoxSenha.SelectionStart;

			if (senha.Contains(" "))
			{
				// Se a senha contém espaços em branco e feito uma copia e retirado o espaço
				txtBoxSenha.Text = senha.Substring(0, senha.Length-1);

				//Retorna o Cursor para sua posição
				txtBoxSenha.SelectionStart = cursorPos;
				txtBoxSenha.SelectionLength = 0;
			}
		}

        private void txtBoxConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
			string senha = txtBoxConfirmarSenha.Text;
			//Salva localização do Cursor antes de alterar a Senha
			int cursorPos = txtBoxConfirmarSenha.SelectionStart;

			if (senha.Contains(" "))
			{
				// Se a senha contém espaços em branco e feito uma copia e retirado o espaço
				txtBoxConfirmarSenha.Text = senha.Substring(0, senha.Length-1);

				//Retorna o Cursor para sua posição
				txtBoxConfirmarSenha.SelectionStart = cursorPos;
				txtBoxConfirmarSenha.SelectionLength = 0;
			}
		}

 
    }
}
