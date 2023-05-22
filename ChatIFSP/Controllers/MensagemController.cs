using ChatIFSP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Controllers
{
    internal class MensagemController : DefaultController
    {
        public static String VerificaStatusMensagem(Mensagens msg) //meu mensagemStatus está String, alterar para padrão BD Caio
        {
            String status;
            if (msg.statusMensagem == 1) status = "\U0001F4E4";
            else if (msg.statusMensagem == 2) status = "\U0001F4E8";
            else status = "👁🗨";

            return status;
        }
    }
}
