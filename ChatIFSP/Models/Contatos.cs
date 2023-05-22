using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Models
{
    public class Contatos
    {
        [Key] public int idContato { get; set; }
        public int idUsuario { get; set; }
        public int idUsuarioContato { get; set; }


        [ForeignKey("idUsuario")]
        public Usuarios Usuarios { get; set; }//Propriedade de navegação (para acessar os dados do objeto da outra tabela)
    }
}
