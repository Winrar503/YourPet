using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourPett.Models
{
	public class Usuarios
	{
        public int id { get; set; }
        public string nombre { get; set; }
        public string gmail { get; set; }
        public string password { get; set; }
   

    }
    internal class ErrorMensaje
    {
        public string message { get; set; }
    }

}
