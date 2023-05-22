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
    public partial class userControlContatos : UserControl
    {
        //public bool estaOnline { get; set; }
        private int idUsuario { get; set; } 
        public userControlContatos(Usuarios contatoUsuario)
        {
            InitializeComponent();
            lbNomeContato.Text = contatoUsuario.nome;
            idUsuario = contatoUsuario.idUsuario;
        }

        private void userControlContatos_Load(object sender, EventArgs e)
        {

        }

        private void userControlContatos_Click(object sender, EventArgs e)
        {
            int idConversa = ParticipantesController.RetornaIdConversaParticipantes(idUsuario);

            ConversaController.AbrirConversa(idConversa);
        

        }
    }
}
