using ChatIFSP.Controllers;
using ChatIFSP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatIFSP.Views
{
    public partial class frmEditarPerfil : Form
    {
        bool trocaFoto = false;
        bool trocaSenha = false;
        public frmEditarPerfil(int idUsuarioLogado)
        {
            InitializeComponent();
            //Ação ao fechar.
            this.FormClosing += frmEditarPerfil_FormClosing;
            Usuarios dadosUsuario = new Usuarios();
            dadosUsuario = UsuariosController.CarregadadosUsuario(idUsuarioLogado);

            txtBoxNome.Text = dadosUsuario.nome;
            txtBoxApelido.Text = dadosUsuario.apelido;
            txtBoxEmail.Text = dadosUsuario.email;

            //Carregando a foto
            byte[] imagemBytes = Convert.FromBase64String(dadosUsuario.foto); //Esta enviando vazio ()

            using (MemoryStream ms = new MemoryStream(imagemBytes))
            {
                pbFoto.Image = Image.FromStream(ms);
            }


        }

        private bool ValidaCampos()
        {
            bool retorno = false;

            // Expressão regular para validar o formato do email
            string regEmail = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            //NOME
            if (txtBoxNome.Text == "")
            {
                retorno = true;
                errorProviderEditarPerfil.SetIconPadding(txtBoxNome, 3);
                errorProviderEditarPerfil.SetError(txtBoxNome, "Nome não pode ser vazio!");
                txtBoxNome.BackColor = Color.FromArgb(220, 100, 100);
            }
            else
            {
                errorProviderEditarPerfil.Clear();
                txtBoxNome.BackColor = Color.White;
            }

            //E-MAIL
            if (txtBoxEmail.Text == "")
            {
                retorno = true;
                errorProviderEditarPerfil.SetIconPadding(txtBoxNome, 3);
                errorProviderEditarPerfil.SetError(txtBoxNome, "Email não pode ser vazio!");
                txtBoxEmail.BackColor = Color.FromArgb(220, 100, 100);
            }
            else
            {
                errorProviderEditarPerfil.Clear();
                txtBoxEmail.BackColor = Color.White;
            }

            //E-MAIL FORMATO
            if (Regex.IsMatch(txtBoxEmail.Text, regEmail) == false)
            {
                errorProviderEditarPerfil.SetIconPadding(txtBoxEmail, 3);
                errorProviderEditarPerfil.SetError(txtBoxEmail, "Email precisa estar no formato correto!");
                txtBoxEmail.BackColor = Color.FromArgb(220, 100, 100);
                toolTipEditarPerfil.ToolTipIcon = ToolTipIcon.Error;
                toolTipEditarPerfil.Show("Email precisa estar no formato correto!", txtBoxEmail);
                retorno = true;
            }
            else
            {
                errorProviderEditarPerfil.Clear();
                txtBoxEmail.BackColor = Color.White;
            }

            //APELIDO
            if (txtBoxApelido.Text == "")
            {
                retorno = true;
                errorProviderEditarPerfil.SetIconPadding(txtBoxApelido, 3);
                errorProviderEditarPerfil.SetError(txtBoxApelido, "Apelido não pode ser vazio!");
                txtBoxApelido.BackColor = Color.FromArgb(220, 100, 100);
            }
            else
            {
                errorProviderEditarPerfil.Clear();
                txtBoxApelido.BackColor = Color.White;
            }

            //VALIDAÇÃO CASO ESTIVER MARCADO O TROCAR SENHA
            if (ckBoxTrocarSenha.Checked)
            {
                //NOVA SENHA 
                if (txtBoxNovaSenha.Text == "")
                {
                    //errorProviderCadastro.SetIconPadding(txtBoxSenha, 3);
                    //errorProviderCadastro.SetError(txtBoxSenha, "Você precisa digitar uma senha!");
                    txtBoxNovaSenha.BackColor = Color.FromArgb(220, 100, 100);
                    retorno = true;
                }
                else
                {
                    errorProviderEditarPerfil.Clear();
                    txtBoxNovaSenha.BackColor = Color.White;
                }

                //TAMANHO NOVA SENHA
                if (txtBoxNovaSenha.Text.Length < 6)
                {
                    errorProviderEditarPerfil.SetIconPadding(txtBoxConfirmarSenha, 3);
                    errorProviderEditarPerfil.SetError(txtBoxConfirmarSenha, "A senha tem que ter no mínimo 6 dígitos!");
                    txtBoxSenhaAtual.BackColor = Color.FromArgb(220, 100, 100);
                    retorno = true;
                }
                else
                {
                    errorProviderEditarPerfil.Clear();
                    txtBoxNovaSenha.BackColor = Color.White;
                }


                //CONFIRMA SENHA
                if (txtBoxConfirmarSenha.Text == "")
                {
                    errorProviderEditarPerfil.SetIconPadding(txtBoxConfirmarSenha, 3);
                    errorProviderEditarPerfil.SetError(txtBoxConfirmarSenha, "Você precisa digitar uma senha!");
                    txtBoxConfirmarSenha.BackColor = Color.FromArgb(220, 100, 100);
                    retorno = true;
                }
                else
                {
                    errorProviderEditarPerfil.Clear();
                    txtBoxConfirmarSenha.BackColor = Color.White;
                }


                //SENHA E CONFIRMAR SENHA IGUAIS
                if (txtBoxNovaSenha.Text != txtBoxConfirmarSenha.Text)
                {
                    errorProviderEditarPerfil.SetIconPadding(txtBoxConfirmarSenha, 3);
                    errorProviderEditarPerfil.SetError(txtBoxConfirmarSenha, "Confirmação de senha diferente de senha!");
                    txtBoxConfirmarSenha.BackColor = Color.FromArgb(220, 100, 100);

                    MessageBox.Show("Senha e confirmar senha não são iguais! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    retorno = true;
                }
                else
                {
                    errorProviderEditarPerfil.Clear();
                    txtBoxConfirmarSenha.BackColor = Color.White;
                }
            }

            return retorno;
        }

        private void btnAtualizaDados_Click(object sender, EventArgs e)
        {
            MostraAnimacao();
            if (ValidaCampos() == false)
            {

                Usuarios dadosUsuario = new Usuarios();
                dadosUsuario.nome = txtBoxNome.Text;
                dadosUsuario.email = txtBoxEmail.Text;
                dadosUsuario.apelido = txtBoxApelido.Text;

                dadosUsuario.senha = ckBoxTrocarSenha.Checked ? txtBoxNovaSenha.Text : null;
                if (trocaFoto == true)
                {
                    dadosUsuario.foto = DefaultController.ConverteImagemBase64(pbFoto);
                }


                int retorno = UsuariosController.AtualizaDados(dadosUsuario, txtBoxSenhaAtual.Text);

                //MENSAGENS DE RETORNO
                switch (retorno)
                {
                    case 0:
                        MessageBox.Show("Erro ao atualizar!");
                        break;
                    case 1:
                        MessageBox.Show("Senha atual errada!");
                        break;
                    case 2:
                        MessageBox.Show("Dados atualizados!");
                        break;
                }


            }
            EscondeAnimacao();

        }

        private void btnTrocarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagem = new OpenFileDialog();
            imagem.Filter = "Imagem JPG | *.jpg";
            DialogResult respota = imagem.ShowDialog();

            //Valida se carregou corretamente
            if (respota == DialogResult.OK)
            {
                pbFoto.ImageLocation = imagem.FileName;
                trocaFoto = true;

            }
        }

        private void ckBoxTrocarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxTrocarSenha.Checked)
            {
                trocaSenha = true;
                lbNovaSenha.Visible = true;
                txtBoxNovaSenha.Visible = true;
                lbConfirmarSenha.Visible = true;
                txtBoxConfirmarSenha.Visible = true;
                lbDgitos.Visible = true;
                gpBoxSenha.Size = new System.Drawing.Size(520, 112);

            }
            else
            {
                trocaSenha = false;
                lbNovaSenha.Visible = false;
                txtBoxNovaSenha.Visible = false;
                lbConfirmarSenha.Visible = false;
                txtBoxConfirmarSenha.Visible = false;
                lbDgitos.Visible = false;
                gpBoxSenha.Size = new System.Drawing.Size(520, 39);
            }
        }
        private void MostraAnimacao()
        {
            pbAnimacaoAtualizacao.Visible = true;
            txtBoxNovaSenha.Enabled = false;
            txtBoxConfirmarSenha.Enabled = false;
            txtBoxApelido.Enabled = false;
            txtBoxEmail.Enabled = false;
            txtBoxNome.Enabled = false;
            pbFoto.Enabled = false;
            btnAtualizaDados.Text = "ATUALIZANDO...";
            btnAtualizaDados.Enabled = false;

        }

        private void EscondeAnimacao()
        {
            txtBoxNovaSenha.Enabled = true;
            txtBoxConfirmarSenha.Enabled = true;
            txtBoxApelido.Enabled = true;
            txtBoxEmail.Enabled = true;
            txtBoxNome.Enabled = true;
            pbFoto.Enabled = true;
            btnAtualizaDados.Text = "ATUALIZAR DADOS";
            btnAtualizaDados.Enabled = true;
            pbAnimacaoAtualizacao.Visible = false;
        }

        private void frmEditarPerfil_FormClosing(object sender, EventArgs e)
        {
            MessageBox.Show("fechando");
        }
    }
}
