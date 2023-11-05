using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourPett.Models;


namespace YourPett.Services
{
    public interface IRegistroAnimalService
    {
        Task<List<RegistroAnimal>> ObtenerRegistro();

        Task<RegistroAnimal> CrearRegistro(RegistroAnimal nuevaRegistroAnimal);

    }
}
