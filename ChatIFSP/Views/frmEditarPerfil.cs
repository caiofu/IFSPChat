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
	public partial class frmEditarPerfil : Form
	{
		public frmEditarPerfil(int idUsuarioLogado)
		{
			InitializeComponent();

			Usuarios dadosUsuario = new Usuarios();
			dadosUsuario = UsuariosController.CarregadadosUsuario(idUsuarioLogado);

			txtBoxNome.Text = dadosUsuario.nome;
			txtBoxApelido.Text = dadosUsuario.apelido;
			txtBoxEmail.Text = dadosUsuario.email;

			//Carregando a foto
			byte[] imagemBytes = Convert.FromBase64String(dadosUsuario.foto);

			using (MemoryStream ms = new MemoryStream(imagemBytes))
			{
				pbFoto.Image = Image.FromStream(ms);
			}

		}
	}
}
