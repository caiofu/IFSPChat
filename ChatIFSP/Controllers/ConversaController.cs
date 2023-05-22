using ChatIFSP.Models;
using ChatIFSP.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatIFSP.Controllers
{
    public class ConversaController : DefaultController
    {
        //public static int usuarioAtual = 1;
        public static Mensagens EnviaMensagem(String msg, int remetente, int conversa)
        {
            if (!msg.Trim().Equals(""))
            {
                //var conversaAtual = Context.Conversas.Find(msg.idConversa);
                //conversaAtual.qtdMensagens += 1;
                //Context.Conversas.Update(conversaAtual);
                var mensagem = new Mensagens();
                mensagem.idRemetente = remetente;
                //mensagem.destinatarioId = destinatario;
                mensagem.idConversa = conversa;
                mensagem.statusMensagem = 1;
                mensagem.dataMensagem = DateTime.Now;
                mensagem.mensagem = msg;

                Context.Mensagens.Add(mensagem);
                Context.SaveChanges();

                return mensagem;
            }
            else return null;
        }

        public static String AtualizaConversa(Mensagens msg)
        {
            String status = "\U0001F4E4"; //envio
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine(status + "[" + msg.dataMensagem.ToString("HH:mm") + "] - " + msg.Usuario.apelido + ":");
            mensagem.AppendLine(msg.mensagem + "\n");

            return mensagem.ToString();
        }

        public static String CarregaConversa(int idConversa)
        {
            StringBuilder conversa = new StringBuilder();

            List<Mensagens> mensagens = Context.Mensagens //obtem lista de mensagens da conversa, incluindo dados do participante para ter acesso ao usuario e seus campos
                .Include(p => p.Usuario)
                .Where(m => m.idConversa == idConversa)
                .ToList();

            foreach (var msg in mensagens) //formatação das mensagem para exibição em tela
            {                              //necessário validação do outro participante para definir melhor o status
                String status = UsuariosController.idUsuarioLogado == msg.idRemetente ? MensagemController.VerificaStatusMensagem(msg) : ""; //if ternário para definir status da mensagem

                conversa.AppendLine(status + "[" + msg.dataMensagem.ToString("HH:mm") + "] - " + msg.Usuario.apelido + ":");
                conversa.AppendLine(msg.mensagem + "\n");
                // conversa.AppendLine(msg.);
            }
            return conversa.ToString();
        }

        public static void SetarVisualizacaoMensagens(int conversa)
        {
            //chamar controller mensagem para setar 1 por 1 retorno de uma lista de mensagens da conversa
            //selecionar as mensagens do outro participante com status != visualizado
            List<Mensagens> mensagens = Context.Mensagens
                .Where(m => m.idConversa == conversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem != 3)
                .ToList();

            foreach(Mensagens msg in mensagens)
            {
                msg.statusMensagem = 3;
            }

            Context.SaveChanges();
        }

        public static void SetarRecebimentoMensagens(int conversa)
        {
            List<Mensagens> mensagens = Context.Mensagens
                .Where(m => m.idConversa == conversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem == 1)
                .ToList();

            foreach (Mensagens msg in mensagens)
            {
                msg.statusMensagem = 2;
            }

            Context.SaveChanges();
        }

        public static void CriaConversa(int idContato)
        {
            try
            {

                Conversas novaConversa = new Conversas();
                novaConversa.dataCriacao = DateTime.Now;
                Context.Conversas.Add(novaConversa);
                

                if(Context.SaveChanges() > 0)
                {
                    //Inserindo participantes
                    ParticipantesController.CriaParticipantes(UsuariosController.idUsuarioLogado, idContato, novaConversa.idConversa);
                }
            }
            catch(Exception ex)
            { 
            
            }
         

        }

        public static void AbrirConversa(int idConversa)
        {
            frmConversa AbrirConversa = new frmConversa(idConversa);
			
			AbrirConversa.ShowDialog();
		}
    }
}