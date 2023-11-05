using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YourPett.Models
{
    public class RegistroAnimal
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public string fechadenacimiento { get; set; }
        public string raza { get; set; }
        public string especie { get; set; }
        public string sexo { get; set; }
    }
}
