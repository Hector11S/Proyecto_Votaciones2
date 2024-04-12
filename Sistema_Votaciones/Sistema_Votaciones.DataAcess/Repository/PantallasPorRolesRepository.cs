using Dapper;
using Microsoft.Data.SqlClient;
using Sistema_Votaciones.BusinessLogic;
using Sistema_Votaciones.DataAcces;
using Sistema_Votaciones.Entities.Entities;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.DataAcess.Repository
{
    public partial class PantallasPorRolesRepository : IRepository<tbPantallasPorRoles>
    {
        public RequestStatus Delete(int? Rol_Id, int? Pant_Id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Rol_Id", Rol_Id);
                parameter.Add("Pant_Id", Pant_Id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Paro_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbPantallasPorRoles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPantallasPorRoles item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Rol_Id", item.Rol_Id);
                parameter.Add("Pant_Id", item.Pant_Id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Paro_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbPantallasPorRoles> List()
        {

            List<tbPantallasPorRoles> result = new List<tbPantallasPorRoles>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbPantallasPorRoles>(ScriptsBaseDeDatos.Paro_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbPantallasPorRoles item)
        {
            throw new NotImplementedException();
        }
    }
}
