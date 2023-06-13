using ChatIFSP.Controllers;
using ChatIFSP.Models;
using ChatIFSP.Views;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Threading;
namespace ChatIFSP
{
    public partial class frmLogin : Form
    {
        Thread ThLogin;//Colocando em outra Thread para fechar essa janela sem problemas
        private int idUsuarioLogado;
        //Testes
        private BackgroundWorker loginWorker;
        public frmLogin()
        {

            InitializeComponent();

            KeyPreview = true;
            KeyDown += frmLogin_KeyDown;

            // Configura o BackgroundWorker (server para criar o processo de login em uma Tread separada , para ocorrer a animação)
            loginWorker = new BackgroundWorker();
            loginWorker.WorkerReportsProgress = true;
            loginWorker.DoWork += LoginWorker_DoWork;
            loginWorker.RunWorkerCompleted += LoginWorker_RunWorkerCompleted;


        }

        // Função que verifica se a tecla Enter foi pressionada
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
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
                MostraLoading();

                // Iniciar o processamento de login em uma thread separada
                loginWorker.RunWorkerAsync(usuarios);

            }

        }

        //Metodo responsavel por fazer a solicitaçao de login ao controller
        private void LoginWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Usuarios usuarios = (Usuarios)e.Argument;

            //Processa o login.
            int idUsuario = UsuariosController.Login(usuarios.email, usuarios.senha);

            e.Result = idUsuario;
        }

        //Metodo que lida com a resposta do processo de login
        private void LoginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Ocultar a animação de loading
            EscondeLoading();

            if (e.Error != null)
            {
                // Lidar com o erro
                MessageBox.Show("Ocorreu um erro durante o login.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idUsuario = (int)e.Result;

            if (idUsuario != 0)
            {
                idUsuarioLogado = idUsuario;
                this.Close();

                // Trecho responsável para abrir uma nova janela e fechar a anterior sem que ela fique na memória
                // Criamos uma Thread para lidar com isso
                ThLogin = new Thread(AbrirJanelaContatos);
                ThLogin.SetApartmentState(ApartmentState.STA); // Configura o estado antes dele ser iniciado (Single)
                ThLogin.Start();
                // ---------------------------------------------//
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelInscreva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro novoCadastro = new frmCadastro();
            novoCadastro.ShowDialog();

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
            btnEntrar.Enabled = false;
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
            btnEntrar.Enabled = true;

            //Loading bar
            progressBarLogin.Visible = false;
        }

        private void AbrirJanelaContatos(object obj)
        {
            Application.Run(new frmContatos(idUsuarioLogado));
        }
    }

}