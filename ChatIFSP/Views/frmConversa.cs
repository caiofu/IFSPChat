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
using ChatIFSP.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ChatIFSP.Views
{
    public partial class frmConversa : frmBase
    {
        static int conversaAtual;
        static bool isScrolling = false;
        static DataContext Context;
        static bool possuiContato;
        private int idContato;
        public frmConversa(int idConversa, DataContext ContextConversa)
        {
            Context = ContextConversa;
            conversaAtual = idConversa;
            ConversaController.GeraEstadoConversa(conversaAtual);
            InitializeComponent();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensagem(txtMensagem.Text);
        }

        private void txtMensagem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                EnviarMensagem(txtMensagem.Text);
            }
        }
        private void EnviarMensagem(String msg)
        {
            if (!msg.Trim().Equals(""))
            {
                Task.Run(async () =>
                {
                    if (txtMensagem.InvokeRequired)
                    {
                        txtMensagem.Invoke((MethodInvoker)delegate
                        {
                            txtMensagem.Text = "";
                        });
                    }
                    else txtMensagem.Text = "";
                    var mensagem = MensagemController.SalvaMensagem(msg.Trim(), UsuariosController.idUsuarioLogado, conversaAtual, Context);
                    if (mensagem != null)
                    {
                        if (rtbConversa.Text.Equals(""))
                        {
                            rtbConversa.Text = await ConversaController.AtualizaConversa(mensagem, Context);
                        }
                        else
                        {
                            rtbConversa.AppendText("\n\n" + await ConversaController.AtualizaConversa(mensagem, Context));
                        }
                        ConversaController.estadoConversa = rtbConversa.Text;
                    }
                    else MessageBox.Show("Erro no envio da mensagem");
                });
            }
        }


        private void frmConversa_Load(object sender, EventArgs e)
        {
            //método inicializa conversa, com conteúdo e foto dos participantes
            //Carregando dados do usuario logado
            Usuarios meuUsuario = new Usuarios();
            Usuarios contato = new Usuarios();
            meuUsuario = UsuariosController.CarregadadosUsuario(UsuariosController.idUsuarioLogado);
            idContato = ParticipantesController.RetornaIdContato(conversaAtual);
            contato = ContatosController.CarregaDadosContatoConversa(idContato);


            /*lbNomeUsuario.Text = meuUsuario.nome;
            lbApelido.Text = meuUsuario.apelido;*/

            //Carregando a foto
            byte[] FotoUsuario = Convert.FromBase64String(meuUsuario.foto);
            byte[] FotoContato = Convert.FromBase64String(contato.foto);

            using (MemoryStream ms = new MemoryStream(FotoUsuario))
            {
                pcbUsuario.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(FotoContato))
            {
                pcbContato.Image = Image.FromStream(ms);
            }
            //criar função para dar update na tabela de mensagem, para alterar status das mensagens do outro participante
            MensagemController.SetarVisualizacaoMensagens(conversaAtual, Context);
            rtbConversa.Text = ConversaController.CarregaConversa(conversaAtual, Context);
            rtbConversa.SelectionStart = rtbConversa.Text.Trim().Length;
            rtbConversa.ScrollToCaret();
            possuiContato = ContatosController.VerificaPossuiContato(UsuariosController.idUsuarioLogado, contato.idUsuario);
            if (!possuiContato)
            {
                btnAdicionaSolicitacao.Visible = true;
                btnAdicionaSolicitacao.Enabled = true;
                idContato = contato.idUsuario;
            }
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
                            rtbConversa.SelectionStart = rtbConversa.Text.Trim().Length;
                            rtbConversa.ScrollToCaret();
                        });
                    }
                    else
                    {
                        rtbConversa.Text = conversa;
                        rtbConversa.SelectionStart = rtbConversa.Text.Trim().Length;
                    }

                }
                //else MessageBox.Show("caindo não tem msg");
            });
        }

        /*private void rtbConversa_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(isScrolling.ToString());
            //MessageBox.Show("Tamanho do texto: " + rtbConversa.Text.Trim().Length);
            if (isScrolling)
            {
               // MessageBox.Show("Tamanho do texto: " + rtbConversa.Text.Trim().Length);
                rtbConversa.SelectionStart = rtbConversa.Text.Trim().Length;
                rtbConversa.ScrollToCaret();
            }
            rtbConversa.ScrollToCaret();

        }*/

        private void frmConversa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Context.Dispose();
        }

        private void rtbConversa_VScroll(object sender, EventArgs e)
        {
            isScrolling = true;
        }

        private void btnAdicionaSolicitacao_Click(object sender, EventArgs e)
        {
            if (ContatosController.AdicionaContato(idContato))
            {
                btnAdicionaSolicitacao.Visible = false;
                btnAdicionaSolicitacao.Enabled = false;
                MessageBox.Show("Contato adicionado com sucesso!");
            }
            else MessageBox.Show("Falha em adicionar novo contato");
        }
    }
}