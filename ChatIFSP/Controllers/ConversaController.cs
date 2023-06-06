using ChatIFSP.Data;
using ChatIFSP.Models;
using ChatIFSP.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Controllers
{
    //ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class ConversaController : DefaultController
    {
        //public static int usuarioAtual = 1;
        

        public static String AtualizaConversa(Mensagens msg, DataContext Context)
        {
            var entry = Context.Entry(msg);
            entry.Reference(m => m.Usuario).Load();

            String status = "\U0001F4E4"; //envio
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine(status + "[" + msg.dataMensagem.ToString("HH:mm") + "] - " + msg.Usuario.apelido + ":");
            mensagem.AppendLine(msg.mensagem + "\n");

            return mensagem.ToString();
        }

        public static String CarregaConversa(int idConversa, DataContext Context)
        {
            StringBuilder conversa;
            List<Mensagens> mensagens;
            
            conversa = new StringBuilder();

            mensagens = Context.Mensagens //obtem lista de mensagens da conversa, incluindo dados do participante para ter acesso ao usuario e seus campos
                .Include(p => p.Usuario)
                .Where(m => m.idConversa == idConversa)
                .OrderBy(m => m.dataMensagem)
                .AsNoTracking() //coment   
                .ToList();
            

            //dbContext.Dispose();
            foreach (var msg in mensagens) //formatação das mensagem para exibição em tela
            {                              //necessário validação do outro participante para definir melhor o status
                String status = UsuariosController.idUsuarioLogado == msg.idRemetente ? MensagemController.VerificaStatusMensagem(msg) : ""; //if ternário para definir status da mensagem

                conversa.AppendLine(status + "[" + msg.dataMensagem.ToString("HH:mm") + "] - " + msg.Usuario.apelido + ":");
                conversa.AppendLine(msg.mensagem + "\n");
                // conversa.AppendLine(msg.);
            }

            return conversa.ToString();
            //DataContext dbContext = new DataContext();
            /*StringBuilder conversa = new StringBuilder();

            List<Mensagens> mensagens = dbContext.Mensagens //obtem lista de mensagens da conversa, incluindo dados do participante para ter acesso ao usuario e seus campos
                .Include(p => p.Usuario)
                .Where(m => m.idConversa == idConversa)
                .OrderBy(m => m.dataMensagem)
                .AsNoTracking() //coment   
                .ToList();*/
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

        public static void AbrirConversa( int idConversa)
        {
            DataContext ContextConversa = new DataContext(); 
            frmConversa AbrirConversa = new frmConversa(idConversa, ContextConversa);

            AbrirConversa.ShowDialog();
        }
    }
}