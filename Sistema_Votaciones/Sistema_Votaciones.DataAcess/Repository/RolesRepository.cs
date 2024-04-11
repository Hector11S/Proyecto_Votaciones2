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
    public partial class RolesRepository : IRepository<tbRoles>
    {
        public RequestStatus Delete(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Rol_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Rol_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbRoles Find(int? id)
        {
            tbRoles result = new tbRoles();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Rol_Id", id);
                result = db.QueryFirst<tbRoles>(ScriptsBaseDeDatos.Rol_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbRoles item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Rol_Descripcion", item.Rol_Descripcion);
                parameter.Add("Rol_UsuarioCreacion", item.Rol_UsuarioCreacion);
                parameter.Add("Rol_FechaCreacion", item.Rol_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Rol_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { Id = result.id, CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbRoles> List()
        {

            List<tbRoles> result = new List<tbRoles>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbRoles>(ScriptsBaseDeDatos.Rol_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbRoles item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Rol_Id", item.Rol_Id);
                parameter.Add("Rol_Descripcion", item.Rol_Descripcion);
                parameter.Add("Rol_UsuarioModifica", item.Rol_UsuarioModifica);
                parameter.Add("Rol_FechaModifica", item.Rol_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Rol_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
