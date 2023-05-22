using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Models
{
    public class Mensagens
    {
        [Key] public int idMensagem { get; set; }
        public int idConversa { get; set; }
        public int idRemetente { get; set; }

        [MaxLength(3500)] public string mensagem { get; set; }
        public int statusMensagem { get; set; }
        public DateTime dataMensagem { get; set; }


        [ForeignKey("idConversa")]
        public Conversas Conversa { get; set; }//Propriedade de navegação (para acessar os dados do objeto da outra tabela)

        [ForeignKey("idRemetente")]
        public virtual Usuarios Usuario { get; set; }
    }
}
