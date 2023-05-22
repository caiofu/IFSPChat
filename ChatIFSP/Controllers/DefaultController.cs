using ChatIFSP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatIFSP.Controllers
{
    public class DefaultController
    {
        //Para lidar com o banco
        public static DataContext Context = new DataContext();
    }
}
