using ChatIFSP.Data;
using ChatIFSP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChatIFSP.Controllers
{
    public class ContatosController  : DefaultController
    {
        //Criando um novo Context para nao dar erro por conta das Threads (elas nao permitem compartilhar o DataContext em acessos simultaneos
		private static DataContext Context = new DataContext();
		public static bool AdicionaContato(int idContato)
        {
            try
            {
                Contatos novoContato = new Contatos();
                novoContato.idUsuario = UsuariosController.idUsuarioLogado;
                novoContato.idUsuarioContato = idContato;
				//Verifica se o contato ja me tem adicionado para somente adicionar ele como meu contato tambem  e nao criar uma nova conversa
				if(Context.Contatos.Where(c => c.idUsuarioContato == UsuariosController.idUsuarioLogado && c.idUsuario == idContato).FirstOrDefault() == null)
                {
					Context.Contatos.Add(novoContato);
					if (Context.SaveChanges() > 0) //Verificando o numero de linhas afetadas para saber se inseriu o contato.
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
                else
                {
					Context.Contatos.Add(novoContato);
                    if (Context.SaveChanges() <= 0) //Verificando o numero de linhas afetadas para saber se inseriu o contato.
                    {
                        return false;
                    }
                    else { return true; }
				}
			
            }
            catch (Exception ex) 
            {
                return false;
            }
          
        }

        
      
        public static List<Usuarios> CarregaDadosContatos(int idUsuario)
        {
			DataContext dataContext = new DataContext();//Esta sendo criado para cada metodo por conta das Threads concorrentes

		   //Context.Usuarios.Where(u => u.email == email).FirstOrDefault();
		   var dados = from contatos in dataContext.Contatos.AsNoTracking()
                        join usuarios in dataContext.Usuarios.AsNoTracking() on contatos.idUsuarioContato equals usuarios.idUsuario
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

        public static Usuarios CarregaDadosContatoConversa(int idContato)
        {
            Usuarios contato = Context.Usuarios
                 .Where(u => u.idUsuario == idContato)
                 .FirstOrDefault();
            
            
            return contato;
        }

        public static List<Usuarios> CarregaDadosSolicitacaoMensagem(int idUsuario)
        {
			DataContext dbContext = new DataContext();

			var contatosSemRelacao = dbContext.Usuarios
                                   .Where(u => u.idUsuario != idUsuario &&
                                               !dbContext.Contatos.Any(c => c.idUsuario == idUsuario && c.idUsuarioContato == u.idUsuario) &&
                                               dbContext.Participantes.Any(p => p.idUsuario == idUsuario && dbContext.Conversas.Any(c => c.idConversa == p.idConversa && dbContext.Mensagens.Any(m => m.idConversa == c.idConversa && m.idRemetente == u.idUsuario))))
                                   .Select(u => new Usuarios
                                   {
                                       idUsuario = u.idUsuario,
                                       nome = u.nome,
                                       apelido = u.apelido
                                   })
                                   .Distinct()
                                   .ToList();

            return contatosSemRelacao;


        }

        public static bool VerificaPossuiContato(int idUsuario, int idContato)
        {
            bool resposta = true;
			DataContext dbContext = new DataContext();
            if(idUsuario != idContato) //Validando se usuario não esta tentando adicionar ele mesmo
            {
                var resultadoConsulta = dbContext.Contatos.Where(u => u.idUsuario == idUsuario && u.idUsuarioContato == idContato).FirstOrDefault();
                if (resultadoConsulta == null)
                {
                    resposta = false;
                }
            }


			return resposta;
        }

        public static int VerificaQuantidadeContatos(int idUsuario)
        {
            int quantidade =0;
            try
            {
                DataContext dbContext = new DataContext();//Criada um novo data Context para nao dar conflito com as Threads
                 quantidade = dbContext.Contatos
                      .AsNoTracking()
                      .Where(c => c.idUsuario == idUsuario /*|| c.idUsuarioContato == idUsuario*/)
                      .Count();
                return quantidade;
            }
            catch (Exception ex)
            {
                return quantidade;
                MessageBox.Show("Erro ao se conectar com o banco");
            }
        
			
        }

        public static bool VerificaContatoOnline(int qtdOnline, int qtdOffline)
        {
            bool resposta = false;
            DataContext dbContext = new DataContext();
           
            int auxQtdOffline = dbContext.Contatos
                                .Join(dbContext.Usuarios, con => con.idUsuarioContato, us => us.idUsuario, (con, us) => new { con, us })
                                .Where(x => x.con.idUsuario == UsuariosController.idUsuarioLogado && x.us.status == 0)
                                .Count();

            int auxQtdOnline= dbContext.Contatos
                                .Join(dbContext.Usuarios, con => con.idUsuarioContato, us => us.idUsuario, (con, us) => new { con, us })
                                .Where(x => x.con.idUsuario == UsuariosController.idUsuarioLogado && x.us.status == 1)
                                .Count();

            //VERIFICA SE HOUVE MUDANÇA
            if (qtdOnline != auxQtdOnline || qtdOffline != auxQtdOffline)
                {
                    resposta = true;
                }
            return resposta;
        }

    }
}
