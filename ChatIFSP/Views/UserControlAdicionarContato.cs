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
        public UserControlAdicionarContato(Usuarios usuario)
        {
            InitializeComponent();
            lbNomeUsuario.Text = usuario.nome;
            lbApelido.Text = usuario.apelido;
            idContato = usuario.idUsuario;

            //Carregando a foto
            //byte[] imagemBytes = Convert.FromBase64String(usuario.foto);

            //using (MemoryStream ms = new MemoryStream(imagemBytes))
            //{
            //    pbFotoContato.Image = Image.FromStream(ms);kkk
            //}

            ///Verifica se o contato ja esta adicionado para desabilitar o botao de adicionar 
            if (ContatosController.VerificaPossuiContato(UsuariosController.idUsuarioLogado, usuario.idUsuario))
            {
                Label lbMensagem = new Label();
                lbMensagem.Text = "Já adicionado";
                lbMensagem.ForeColor = Color.Red;
                lbMensagem.Font = new Font(lbMensagem.Font, FontStyle.Bold);

                lbMensagem.Location = btnAdicionarContato.Location;
                Controls.Remove(btnAdicionarContato);
                Controls.Add(lbMensagem);
            }

        }

        private void btnAdicionarContato_Click(object sender, EventArgs e)
        {
            if(ContatosController.AdicionaContato(idContato))
            {
                MessageBox.Show("Contato adicionado com sucesso");
                //Agora temos que atualizar la em contatos para o novo contato aparecer
            }
            else
            {
                MessageBox.Show("Não foi possivel adicionar o contato");
            }
        }
    }
}
