using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class Autorizacion
    {
        private Dictionary<int, HashSet<string>> pantallasPorRoles = new Dictionary<int, HashSet<string>>();

        public void SetearPantallasPorRoles(List<PantallasPorRolesViewModel> paroList) {
            try
            {
                foreach (var item in paroList)
                {
                    if (!pantallasPorRoles.ContainsKey(item.Rol_Id))
                    {
                        pantallasPorRoles[item.Rol_Id] = new HashSet<string>();
                    }

                    pantallasPorRoles[item.Rol_Id].Add(item.Pant_Descripcion);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool Autorizar(int Rol_Id, string ControllerName) {
            try
            {
                if (Rol_Id != 0)
                {
                    return pantallasPorRoles[Rol_Id].Contains(ControllerName);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return false;
        }
    }
}
