using Dapper;
using Microsoft.Data.SqlClient;
using Sistema_Votaciones.BusinessLogic;
using Sistema_Votaciones.DataAcces;
using Sistema_Votaciones.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.DataAcess.Repository
{
    public partial class UsuariosRepository : IRepository<tbUsuarios>
    {

        public RequestStatus Update(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Usua_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Usua_ActivarDesactivar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbUsuarios Find(int? id)
        {
            tbUsuarios result = new tbUsuarios();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Usua_Id", id);
                result = db.QueryFirst<tbUsuarios>(ScriptsBaseDeDatos.Usua_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbUsuarios item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Usua_Id", item.Usua_Id);
                parameter.Add("Usua_Usuario", item.Usua_Usuario);
                parameter.Add("Usua_Contra", item.Usua_Contra);
                parameter.Add("Usua_Admin", item.Usua_Admin);
                parameter.Add("Empl_Id", item.Empl_Id);
                parameter.Add("Rol_Id", item.Rol_Id);
                parameter.Add("Usua_UsuarioCreacion", item.Usua_UsuarioCreacion);
                parameter.Add("Usua_FechaCreacion", item.Usua_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Usua_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbUsuarios> List()
        {

            List<tbUsuarios> result = new List<tbUsuarios>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbUsuarios>(ScriptsBaseDeDatos.Usua_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbUsuarios item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Usua_Id", item.Usua_Id);
                parameter.Add("Usua_Usuario", item.Usua_Usuario);
                parameter.Add("Usua_Contra", item.Usua_Contra);
                parameter.Add("Usua_Admin", item.Usua_Admin);
                parameter.Add("Empl_Id", item.Empl_Id);
                parameter.Add("Rol_Id", item.Rol_Id);
                parameter.Add("Usua_UsuarioModifica", item.Usua_UsuarioModifica);
                parameter.Add("Usua_FechaModifica", item.Usua_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Usua_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
