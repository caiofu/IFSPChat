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
            rtbConversa.Text =  MensagemController.BuscaMensagens(conversaAtual);
        }
    }
}