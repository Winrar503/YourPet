using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourPett.Models;
using System.Xml.Linq;

namespace YourPett.Services
{
	public interface IUsuarioService
	{
        Task<Usuarios> IniciarSesion(Usuarios pUsuarios);
    }
}
