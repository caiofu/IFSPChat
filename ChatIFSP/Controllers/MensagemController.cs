using ChatIFSP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using ChatIFSP.Data;

namespace ChatIFSP.Controllers
{
    internal class MensagemController : DefaultController
    {
        
        public static Mensagens EnviaMensagem(String msg, int remetente, int conversa)
        {
            DataContext dbContext = new DataContext();
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

        public static void SetarVisualizacaoMensagens(int conversa)
        {
            //DataContext dbContext = new DataContext();
            //chamar controller mensagem para setar 1 por 1 retorno de uma lista de mensagens da conversa
            //selecionar as mensagens do outro participante com status != visualizado

            using (DataContext dc = new())
            {
                List<Mensagens> lista = Context.Mensagens.Where(m => m.idConversa == conversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem != 3).ToList();
                lista.ForEach(p => p.statusMensagem = 3);
                lista.ForEach(p => dc.Mensagens.Update(p));
                dc.SaveChanges();
                dc.Dispose();
            }

            return;


            List<Mensagens> mensagens = Context.Mensagens
                .Where(m => m.idConversa == conversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem != 3)
                //.AsNoTracking()
                .ToList();

            foreach (Mensagens msg in mensagens)
            {
                msg.statusMensagem = 3;
            }

            Context.SaveChanges();
        }

        public static void SetarRecebimentoMensagens(int conversa)
        {
            DataContext dbContext = new DataContext();
            List<Mensagens> mensagens = dbContext.Mensagens
                .Where(m => m.idConversa == conversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem == 1)
                //.AsNoTracking()
                .ToList();

            foreach (Mensagens msg in mensagens)
            {
                msg.statusMensagem = 2;
            }

            Context.SaveChanges();
        }
        public static String VerificaStatusMensagem(Mensagens msg) //meu mensagemStatus está String, alterar para padrão BD Caio
        {
            String status;
            if (msg.statusMensagem == 1) status = "\U0001F4E4";
            else if (msg.statusMensagem == 2) status = "\U0001F4E8";
            else status = "👁🗨";

            return status;
        }

        public static String BuscaMensagens(int conversa)
        { 
            String _conversa = null;
            DataContext dc = new();
            
 
            List<Mensagens> msgNovas = dc.Mensagens
                .Where(m => m.idConversa == conversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem != 3)
                .AsNoTracking()
                .ToList();
            dc.Dispose();

                if (msgNovas != null && msgNovas.Count > 0)
                {
                    SetarVisualizacaoMensagens(conversa);
                    _conversa = ConversaController.CarregaConversa(conversa);
                }
                else _conversa = ConversaController.CarregaConversa(conversa);
            
            return _conversa;
        }
        
        /*public static bool TemMensagemNova(int idConversa)
        {
            bool msgNova = false;
            
           if(Context.Mensagens.Where(m => m.idConversa == idConversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem != 3)
                .AsNoTracking()
                .FirstOrDefault() != null)
            {
                msgNova = true;
            }
			return msgNova;

		}*/
    }
}
