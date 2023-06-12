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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ChatIFSP.Controllers
{
    internal class MensagemController : DefaultController
    {
        
        public static Mensagens ?SalvaMensagem(String msg, int remetente, int conversa, DataContext Context)
        {
            if (!msg.Trim().Equals(""))
            {
                var mensagem = new Mensagens();
                mensagem.idRemetente = remetente;
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


        public static void SetarVisualizacaoMensagens(int conversa, DataContext Context)
        {
            List<Mensagens> lista = Context.Mensagens
                .Where(m => m.idConversa == conversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem != 3)
                .ToList();
            lista.ForEach(p => p.statusMensagem = 3);
            lista.ForEach(p => Context.Mensagens.Update(p));
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
        public static String VerificaStatusMensagem(Mensagens msg) 
        {
            /*
                1- Enviada
                2-
                3- Visualizada
             */
            String status;
            if (msg.statusMensagem == 1) status = "\U0001F4E4";
            else if (msg.statusMensagem == 2) status = "\U0001F4E8";
            else status = "👁🗨";

            return status;
        }

        public static async Task<String> ?BuscaMensagens(int conversa)
        { 
            String ?_conversa = null;
            
            using(DataContext dc = new DataContext())
            {
                List<Mensagens> msgNovas = await dc.Mensagens
                    .Where(m => m.idConversa == conversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem != 3)
                    .AsNoTracking()
                    .ToListAsync();

                /*List<Mensagens> msgNaoLidas = await dc.Mensagens
                    .Where(m => m.idConversa == conversa && m.idRemetente == UsuariosController.idUsuarioLogado && m.statusMensagem != 3)
                    .AsNoTracking()
                    .ToListAsync();*/

                if (msgNovas != null && msgNovas.Count > 0 /*|| msgNaoLidas != null && msgNaoLidas.Count > 0*/)
                {
                    SetarVisualizacaoMensagens(conversa, dc);
                    //_conversa = ConversaController.CarregaConversa(conversa, dc);
                }
                _conversa = ConversaController.CarregaConversa(conversa, dc);
                if (ConversaController.estadoConversa.Equals(_conversa))
                {
                    return null;
                }
                ConversaController.estadoConversa = _conversa;
            }
            return _conversa;
        }
        
        public static bool TemMensagemNova(int idConversa)
        {
            bool msgNova = false;
            
           if(Context.Mensagens.Where(m => m.idConversa == idConversa && m.idRemetente != UsuariosController.idUsuarioLogado && m.statusMensagem != 3)
                .AsNoTracking()
                .FirstOrDefault() != null)
            {
                msgNova = true;
            }
			return msgNova;

		}

        public static int ContaQtdMensagensNovas()
        {
            DataContext dataContext = new DataContext();//Esta sendo criado para cada metodo por conta das Threads concorrentes

            int qtdMensagens = 0;
            List<int> idConversasContatos = ParticipantesController.RetornaListaContatos();
            foreach (int idConversa in idConversasContatos)
            {
                qtdMensagens += dataContext.Mensagens
            .Where(m => m.idConversa == idConversa && m.statusMensagem != 3)
            .Count();
            }

            return qtdMensagens;

            
        }
    }
}
