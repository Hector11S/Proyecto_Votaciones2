using Sistema_Votaciones.DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.BusinessLogic.Services
{
    public class AccesoServices
    {
        private readonly UsuariosRepository usuariosRepository;
        private readonly PantallasRepository pantallasRepository;
        private readonly RolesRepository rolesRepository;
        private readonly PantallasPorRolesRepository pantallasPorRolesRepository;
    }
}
