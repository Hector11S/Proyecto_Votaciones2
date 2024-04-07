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
        public RequestStatus Delete(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Paro_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbPantallasPorRoles Find(int? id)
        {
            tbPantallasPorRoles result = new tbPantallasPorRoles();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Paro_Id", id);
                result = db.QueryFirst<tbPantallasPorRoles>(ScriptsBaseDeDatos.Depa_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbPantallasPorRoles item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Paro_Id", item.Paro_Id);
                //parameter.Add("Paro_Descripcion", item.Paro_Descripcion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbPantallasPorRoles> List()
        {

            List<tbPantallasPorRoles> result = new List<tbPantallasPorRoles>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbPantallasPorRoles>(ScriptsBaseDeDatos.Depa_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbPantallasPorRoles item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Paro_Id", item.Paro_Id);
                //parameter.Add("Paro_Descripcion", item.Paro_Descripcion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
