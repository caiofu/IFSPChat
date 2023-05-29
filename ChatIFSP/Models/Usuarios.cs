using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Models
{
	public class Usuarios
	{

		[Key] public int idUsuario { get; set; }
		[MaxLength(100)] public string nome  { get; set; }
        [MaxLength(10)] public string apelido { get; set; }
        [MaxLength(100)] public string email { get; set; }
        [MaxLength(100)] public string senha { get; set; }
		public string foto { get; set; }
		public int status { get; set; }

	}
}
