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

namespace ChatIFSP.Views
{
    public partial class frmCadastro : Form
    {

        public frmCadastro()
        {
            InitializeComponent();
        }

        private Usuarios inicializaDados()
        {
            Usuarios CadastroUsuario = new Usuarios();
            CadastroUsuario.nome = txtNome.Text;
            CadastroUsuario.email = txtEmail.Text;
            CadastroUsuario.senha = txtSenha.Text;

            using (Image image = Image.FromFile("caminho/para/minha/imagem.jpg")) //Endereço ainda a ser setado...
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Jpeg); // ou outro formato de imagem
                    byte[] imageBytes = ms.ToArray();
                    CadastroUsuario.foto = Convert.ToBase64String(imageBytes);
                }
            }

            return CadastroUsuario;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            inicializaDados();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string campoTexto = "";
            try
            {
                if (campoTexto == "" || !Regex.IsMatch(campoTexto, @"^[a-zA-ZÀ-ú]+([ ]?[a-zA-ZÀ-ú]+)*$"))
                {
                    throw new Exception("Entrada Inválida!!!");
                }

                campoTexto = txtNome.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                campoTexto = "";
            }
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            string Senha = "";
            string ConfirmaSenha = "";

            try
            {
                if (Senha != ConfirmaSenha)
                {
                    throw new Exception("Digite a mesma senha em ambos os campos!");
                }

                    Senha = txtSenha.Text;
                    ConfirmaSenha = txtConfirmarSenha.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Senha = "";
                ConfirmaSenha = "";
            }
        }

        private void SalvaFoto()
        {

        }
    }


}
