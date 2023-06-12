using ChatIFSP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Controllers
{
    public class DefaultController
    {
        //Para lidar com o banco
        public static DataContext Context = new DataContext();

        //Metodo para converter uma imagem para base654
        public static String ConverteImagemBase64(PictureBox foto)
        {
            String stringFoto = "";
            try
            {
                if (foto.Image != null)
                {
                    System.Drawing.Image imagem = foto.Image;
                    byte[] imagemBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        imagem.Save(ms, imagem.RawFormat);
                        imagemBytes = ms.ToArray();
                    }
                    // Converta a matriz de bytes em uma representação Base64
                    stringFoto = Convert.ToBase64String(imagemBytes);
                }
                else
                {
                    //Pegando foto padrão caso usuario nao escolha uma
                    string assemblyPath = Assembly.GetExecutingAssembly().Location;
                    string resourceFolderPath = Path.GetDirectoryName(assemblyPath);

                    //Pegando o caminho da pasta Resources
                    string resourceFilePath = Path.Combine(resourceFolderPath, "mystery.jpg");
                    byte[] fileBytes = File.ReadAllBytes(resourceFilePath);
                    stringFoto = Convert.ToBase64String(fileBytes);
                }

                return stringFoto;
            }
            catch (Exception ex)
            {
                return stringFoto = "err";
            }

        }

    }
}
