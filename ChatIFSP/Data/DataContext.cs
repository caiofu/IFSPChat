using ChatIFSP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Data
{
	public class DataContext : DbContext //Herdado do Entity
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Configurar a conexão com o banco de dados MySQL
			optionsBuilder.UseMySQL("Server=furegati.com.br;Database=furega76_if_chat;User=furega76_ifsp;Password=ifsp2023123456;");

			
		}

		//Tabelas
		public DbSet<Usuarios> Usuarios { get; set; }
		public DbSet<Conversas> Conversas { get; set; }
		public DbSet<Mensagens> Mensagens { get; set;}
		public DbSet<Participantes> Participantes { get; set; }
		public DbSet<Contatos> Contatos { get; set; }
		
	}
}
