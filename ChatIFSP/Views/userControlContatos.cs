using ChatIFSP.Controllers;
using ChatIFSP.Data;
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
    public partial class userControlContatos : UserControl
    {
        //public bool estaOnline { get; set; }
        private int idUsuario { get; set; }
        private int qtdMensagens;
        private int idConversa;
        public userControlContatos(Usuarios contatoUsuario)
        {
            InitializeComponent();
            lbNomeContato.Text = contatoUsuario.apelido; //contatoUsuario.nome;
                                                         // Obtém as dimensões necessárias com base no texto atual do lbNomeContato
            Size textSize = TextRenderer.MeasureText(lbNomeContato.Text, lbNomeContato.Font);
            // Ajusta a largura do lbNomeContato para corresponder ao tamanho do texto
            lbNomeContato.Width = textSize.Width;
            // Define a posição do PictureBox após o lbNomeContato
            picBoxNovaMensagem.Location = new Point(lbNomeContato.Right + 3, lbNomeContato.Top);

            idUsuario = contatoUsuario.idUsuario;

            //Verificar se tem mensagem nova.
            idConversa = ParticipantesController.RetornaIdConversaParticipantes(idUsuario);
            if(MensagemController.TemMensagemNova(idConversa) == true)
            {
                picBoxNovaMensagem.Visible = true;
            }

        }

        private void userControlContatos_Load(object sender, EventArgs e)
        {

        }

        private void userControlContatos_Click(object sender, EventArgs e)
        {
            int idConversa = ParticipantesController.RetornaIdConversaParticipantes(idUsuario);

            //Abrindo em uma nova Thread

            //Task.Run(() => ConversaController.AbrirConversa( idConversa));
            ConversaController.AbrirConversa(idConversa); //Verificar necessidade ou nao de colocar em uma thread

        }
    }
}
