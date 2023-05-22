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
    public partial class frmAdicionaContato : Form
    {
        public frmAdicionaContato()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Pesquisar se usuario existe
            if (txtBoxEmail.Text != "")
            {
                Usuarios usuario = new Usuarios();
                usuario = UsuariosController.VerficaUsuarioExiste(txtBoxEmail.Text);
                if (usuario.idUsuario > 0)
                {
                    flowLayoutPanelResultadoContatos.Controls.Add(new UserControlAdicionarContato(usuario));
                }
            }


        }
    }
}
