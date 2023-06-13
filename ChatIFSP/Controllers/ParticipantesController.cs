using ChatIFSP.Data;
using ChatIFSP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Controllers
{
    public class ParticipantesController : DefaultController
    {
        public static void CriaParticipantes(int idUsuario, int idContato, int idConversa)
        {
            try
            {
                Participantes participanteUsuario = new Participantes();
                Participantes participanteContato = new Participantes();
                participanteUsuario.idUsuario = idUsuario;
                participanteUsuario.idConversa = idConversa;

                participanteContato.idUsuario = idContato;
                participanteContato.idConversa = idConversa;
                Context.Participantes.Add(participanteUsuario);
                Context.Participantes.Add(participanteContato);
                
                Context.SaveChanges();
            }
            catch(Exception ex) 
            { 
            }
        }

        public static int RetornaIdContato(int idConversa)
        {
            int idContato=0;
            try
            {
                idContato = Context.Participantes
                    .Where(p => p.idConversa == idConversa && p.idUsuario != UsuariosController.idUsuarioLogado)
                    .FirstOrDefault().idUsuario!;
                return idContato;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return idContato;
            }
        }
        
        public static int RetornaIdConversaParticipantes(int idUsuarioContato)
        {
            try
            {
				var query = from p in Context.Participantes
							where p.idUsuario == idUsuarioContato
								&& Context.Participantes
									.Any(p2 => p2.idUsuario == UsuariosController.idUsuarioLogado && p2.idConversa == p.idConversa)
							select p.idConversa;

				return query.FirstOrDefault();
			}
            catch (Exception ex) 
            {
                return 0;
            }
			
		}

        //public static List<int> RetornaListaContatos()
        //{
        //    DataContext dataContext = new DataContext();//Esta sendo criado para cada metodo por conta das Threads concorrentes
        //    List<int> result = dataContext.Participantes
        //        .Where(m => m.idUsuario == UsuariosController.idUsuarioLogado)
        //        .Select(m=> m.idConversa)
        //        .ToList();
        //    return result;
        //}
    }
}
