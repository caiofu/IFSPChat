using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Models
{
    public class Participantes
    {
        [Key] public int idParticipante { get; set; }
        public int idUsuario { get; set; }
        public int idConversa { get; set; }


        [ForeignKey("idUsuario")]
        public Usuarios Usuarios { get; set; }//Propriedade de navegação (para acessar os dados do objeto da outra tabela)


        [ForeignKey("idConversa")]
        public Conversas Conversas{ get; set; }//Propriedade de navegação (para acessar os dados do objeto da outra tabela)

    }
}
