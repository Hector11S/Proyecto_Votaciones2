using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public static class Autorizacion
    {
        private static Dictionary<int, HashSet<PantallasViewModel>> pantallasPorRoles =
            new Dictionary<int, HashSet<PantallasViewModel>>();
        private static Dictionary<int, string> esquemas = new Dictionary<int, string>();
        public static Dictionary<int, HashSet<PantallasViewModel>> SetearPantallasPorRoles(
            List<PantallasPorRolesViewModel> paroList)
        {
            try
            {
                pantallasPorRoles.Clear();
                esquemas.Clear();
                foreach (var item in paroList)
                {
                    if (!pantallasPorRoles.ContainsKey(item.Rol_Id))
                    {
                        pantallasPorRoles[item.Rol_Id] = new HashSet<PantallasViewModel>(
                            new PantallasViewModelComparer());
                    }

                    var pantalla = new PantallasViewModel();
                    pantalla.Pant_Id = item.Pant_Id;
                    pantalla.Pant_Descripcion = item.Pant_Descripcion;
                    pantalla.Pant_IconoBootstrap = item.Pant_IconoBootstrap;
                    pantalla.Pant_Controlador = item.Pant_Controlador;
                    pantalla.Esqu_Id = item.Esqu_Id;

                    pantallasPorRoles[item.Rol_Id].Add(pantalla);
                    esquemas[item.Esqu_Id] = item.Esqu_Descripcion;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            return pantallasPorRoles;
        }
        public static Dictionary<int, string> ObtenerEsquemas() {
            return esquemas;
        }

        public static bool Autorizar(int Rol_Id, string ControllerName) {
            try
            {
                if (Rol_Id != 0)
                {
                    return pantallasPorRoles[Rol_Id].Any(pantalla=>pantalla.Pant_Controlador == ControllerName);
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
            return false;
        }
    }
}
