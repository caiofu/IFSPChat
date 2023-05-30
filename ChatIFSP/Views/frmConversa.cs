using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatIFSP.Controllers;

namespace ChatIFSP.Views
{
    public partial class frmConversa : Form
    {
        static int conversaAtual;
        private CancellationTokenSource cancellationTokenSource;
        public frmConversa(int idConversa)
        {
            conversaAtual = idConversa;
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!txtMensagem.Text.Trim().Equals(""))
            {
                var mensagem = MensagemController.EnviaMensagem(txtMensagem.Text.Trim(), UsuariosController.idUsuarioLogado, conversaAtual);
                if (mensagem != null)
                {
                    if (rtbConversa.Text.Equals(""))
                    {
                        rtbConversa.Text = ConversaController.AtualizaConversa(mensagem);
                    }
                    else
                    {
                        rtbConversa.AppendText(ConversaController.AtualizaConversa(mensagem));
                    }
                    //ConversaController.AtualizaConversa(mensagem);
                    txtMensagem.Text = "";

                }
                else MessageBox.Show("Erro no envio da mensagem");
            }
        }


        private void frmConversa_Load(object sender, EventArgs e)
        {
            rtbConversa.Text = ConversaController.CarregaConversa(conversaAtual);
            //criar função para dar update na tabela de mensagem, para alterar status das mensagens do outro participante
            MensagemController.SetarVisualizacaoMensagens(conversaAtual);
        }

        private void tmrConversa_Tick(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task.Run(() =>
            {
                String conversa = null;
                while (!cancellationToken.IsCancellationRequested)
                {
                    conversa = MensagemController.BuscaMensagens(conversaAtual);
                    if (conversa != null)
                    {
                        rtbConversa.Invoke((MethodInvoker)delegate
                        {
                            rtbConversa.Text = conversa;
                        });
                    }

                    // Verificar o cancelamento antes de aguardar o próximo intervalo do timer
                    if (!cancellationToken.IsCancellationRequested)
                    {
                        // Aguardar o próximo intervalo do timer (3 segundos)
                        Thread.Sleep(3000);
                    }
                }
            }, cancellationToken);
        }

        private void rtbConversa_TextChanged(object sender, EventArgs e)
        {
            rtbConversa.SelectionStart = rtbConversa.Text.Length;
            rtbConversa.ScrollToCaret();
        }

        private void frmConversa_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource?.Cancel(); // cancelamento do timer para evitar processos simultâneos durante fechamento do formulário

        }
    }
}