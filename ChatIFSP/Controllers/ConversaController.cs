﻿using ChatIFSP.Models;
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
                .AsNoTracking() //coment     
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