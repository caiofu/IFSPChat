using ChatIFSP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChatIFSP.Controllers
{
    public class ContatosController : DefaultController
    {
        public static bool AdicionaContato(int idContato)
        {
            try
            {
                Contatos novoContato = new Contatos();
                novoContato.idUsuario = UsuariosController.idUsuarioLogado;
                novoContato.idUsuarioContato = idContato;

                Context.Contatos.Add(novoContato);
                if(Context.SaveChanges() > 0) //Verificando o numero de linhas afetadas para saber se inseriu o contato.
                {
                    //Criando a conversa
                    ConversaController.CriaConversa(idContato);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) 
            {
                return false;
            }
          
        }

        
      
        public static List<Usuarios> CarregaDadosContatos(int idUsuario)
        {
            //Context.Usuarios.Where(u => u.email == email).FirstOrDefault();
            var dados = from contatos in Context.Contatos
                        join usuarios in Context.Usuarios on contatos.idUsuarioContato equals usuarios.idUsuario
                        where contatos.idUsuario == idUsuario
                        select new Usuarios
                        {

                            apelido = usuarios.apelido,
                            nome = usuarios.nome,
                            idUsuario = usuarios.idUsuario,
                            status = usuarios.status
                        };
            //select new Usuarios server para que o tipo do retorno seja do modelo da classe usuario
            return dados.ToList();

        }

        public static List<Usuarios> CarregaDadosSolicitacaoMensagem(int idUsuario)
        {
            var contatosSemRelacao = (
             from u in Context.Usuarios
             join m in Context.Mensagens on u.idUsuario equals m.idRemetente
             where !Context.Contatos.Any(c =>
                 c.idUsuarioContato == u.idUsuario &&
                 c.idUsuario == idUsuario
             )
             select u
         ).Distinct().ToList();

            return contatosSemRelacao;
        }

        public static bool VerificaPossuiContato(int idUsuario, int idContato)
        {
            bool resposta = false;
            var resultadoConsulta = Context.Contatos.Where(u => u.idUsuario == idUsuario && u.idUsuarioContato == idContato).FirstOrDefault();
            if(resultadoConsulta != null) 
            {
                resposta = true;
            }
            return resposta;
        }

    }
}
