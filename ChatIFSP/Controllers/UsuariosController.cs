using ChatIFSP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using ChatIFSP.Models;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChatIFSP.Controllers
{
	public class UsuariosController : DefaultController
	{
		public static int idUsuarioLogado { get; set; }

		public static int Login(String email, String senha)
		{
            String senhaHash = CriptografarSenha(senha);
			int retorno = 0;
			var usuario = Context.Usuarios.Where(u => u.email == email && u.senha == senhaHash).FirstOrDefault();

            if (usuario != null)
			{
                usuario.status = 1; //Defini o status para online
                Context.Usuarios.Update(usuario);
                Context.SaveChanges();

                idUsuarioLogado = usuario.idUsuario;
                retorno = usuario.idUsuario;
			}
            return retorno;
        }

        public static bool Logout()
        {
            bool retorno = false;
            var usuario = Context.Usuarios.Where(u => u.idUsuario ==  idUsuarioLogado ).FirstOrDefault();
            if (usuario != null)
            {
                //Definindo o status para offline
                usuario.status = 0;
                Context.Update(usuario);
                Context.SaveChanges();
                retorno = true;
            }
                return retorno;
        }

        public static Usuarios VerficaUsuarioExiste(String email)
        {
            Usuarios usuario = new Usuarios();
            var dadosUsuario = Context.Usuarios.Where(u => u.email == email).FirstOrDefault();

            if (dadosUsuario != null)
            {
                usuario.idUsuario = dadosUsuario.idUsuario;
                usuario.email = dadosUsuario.email;
                usuario.nome = dadosUsuario.nome;
                usuario.apelido = dadosUsuario.apelido;
                usuario.foto = dadosUsuario.foto;
                
            }
            return usuario;
        }

        public static bool VerficaUsuarioJaCadastrado(String email)
        {
           bool retorno = false;
            var dadosUsuario = Context.Usuarios.Where(u => u.email == email).FirstOrDefault();

            if (dadosUsuario != null)
            {
               retorno = true;

            }
            return retorno;
        }


        public static Usuarios CarregadadosUsuario(int idUsuario)
        {
			Usuarios meuUsuario = new Usuarios();
			try
            {
				
				var retorno = Context.Usuarios.Where(u => u.idUsuario == idUsuario).FirstOrDefault();
				meuUsuario.idUsuario = retorno.idUsuario;
				meuUsuario.nome = retorno.nome;
				meuUsuario.email = retorno.email;
				meuUsuario.apelido = retorno.apelido;
				meuUsuario.status = retorno.status;
				meuUsuario.foto = retorno.foto;

				return meuUsuario;
			}
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao carregar usuários!");
				return meuUsuario;
			}
        

        }


        public static bool CadastraUsuario(Usuarios dadosUsuario) //Metodo do para o ain ain
        {
            bool retorno = false;
            try
            {
                dadosUsuario.senha = CriptografarSenha(dadosUsuario.senha);
                Context.Usuarios.Add(dadosUsuario);

                //Verifica se foi salvo
                if(Context.SaveChanges() > 0)
                {
                    retorno = true;
                   
                }
                else
                {
                    retorno = false;
                    
                }
            }
            catch(Exception ex) 
            {
                retorno = false;
            }

            return retorno;

            //    //Parte na qual vai lidar com a imagem
            //    string url = "http://www.exemplo.com/upload"; // URL de hospedagem

            //    string arquivoLocal = "caminho/para/imagem.jpg"; // Caminho do arquivo local

            //    string idUsuario = "123"; // ID do usuário

            //    using (WebClient client = new WebClient())
            //    {
            //        try
            //        {
            //            // Cria uma coleção de dados para enviar junto com o arquivo
            //            System.Collections.Specialized.NameValueCollection parametros = new System.Collections.Specialized.NameValueCollection();
            //            parametros.Add("idUsuario", idUsuario);

            //            // Define a coleção de dados como cabeçalho da requisição
            //            client.Headers.Add(parametros);

            //            // Envia o arquivo para a hospedagem
            //            client.UploadFile(url, arquivoLocal);

            //            MessageBox.Show("Upload concluído com sucesso.");
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Erro durante o upload: " + ex.Message);
            //        }
            //    }
            //}


        }

        public static String CriptografarSenha(String senha)
        {
            byte[] bytesSenha = Encoding.UTF8.GetBytes(senha); // Converte a senha em bytes
            SHA256 sha256 = SHA256.Create(); // Cria uma instância do algoritmo SHA256
            byte[] hash = sha256.ComputeHash(bytesSenha); // Calcula o hash da senha
            return Convert.ToBase64String(hash); // Retorna o hash como uma string base64
        }

        //public static bool VerificarSenha(String senha, String hash)
        //{
        //    String hashSenha = CriptografarSenha(senha); // Calcula o hash da senha fornecida
        //    return hashSenha == hash; // Compara o hash calculado com o hash armazenado
        //}

    }

    
}
