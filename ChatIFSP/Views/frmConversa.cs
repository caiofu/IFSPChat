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
using ChatIFSP.Data;

namespace ChatIFSP.Views
{
    public partial class frmConversa : Form
    {
        static int conversaAtual;
        static DataContext Context;
        //private CancellationTokenSource cancellationTokenSource;
        public frmConversa(int idConversa, DataContext ContextConversa)
        {
            Context = ContextConversa;
            conversaAtual = idConversa;
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!txtMensagem.Text.Trim().Equals(""))
            {
                var mensagem = MensagemController.EnviaMensagem(txtMensagem.Text.Trim(), UsuariosController.idUsuarioLogado, conversaAtual, Context);
                if (mensagem != null)
                {
                    if (rtbConversa.Text.Equals(""))
                    {
                        rtbConversa.Text = ConversaController.AtualizaConversa(mensagem, Context);
                    }
                    else
                    {
                        rtbConversa.AppendText(ConversaController.AtualizaConversa(mensagem, Context));
                    }
                    //ConversaController.AtualizaConversa(mensagem);
                    txtMensagem.Text = "";

                }
                else MessageBox.Show("Erro no envio da mensagem");
            }
        }


        private void frmConversa_Load(object sender, EventArgs e)
        {
            rtbConversa.Text = ConversaController.CarregaConversa(conversaAtual, Context);
            //criar função para dar update na tabela de mensagem, para alterar status das mensagens do outro participante
            MensagemController.SetarVisualizacaoMensagens(conversaAtual, Context);
        }

        private void tmrConversa_Tick(object sender, EventArgs e)
        {
            //cancellationTokenSource = new CancellationTokenSource();
            //CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task.Run(async () => //a busca de novas mensagens é realizada de forma assíncrona em uma tarefa separada da execução principal do programa
            {
                String? conversa = null;
                conversa = await MensagemController.BuscaMensagens(conversaAtual);
                if (conversa != null)
                {
                    if (rtbConversa.InvokeRequired)
                    {
                        rtbConversa.Invoke((MethodInvoker)delegate
                        {
                            rtbConversa.Text = conversa;
                        });
                    }
                    else
                    {
                        rtbConversa.Text = conversa;
                    }

                }
                /*while (!cancellationToken.IsCancellationRequested)
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
                }*/
            }/*, cancellationToken*/);
        }

        private void rtbConversa_TextChanged(object sender, EventArgs e)
        {
            rtbConversa.SelectionStart = rtbConversa.Text.Length;
            rtbConversa.ScrollToCaret();
        }

        private void frmConversa_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cancellationTokenSource?.Cancel(); // cancelamento do timer para evitar processos simultâneos durante fechamento do formulário
            Context.Dispose();
        }
    }
}