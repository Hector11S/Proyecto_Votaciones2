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
    public partial class EstadosCivilesRepository : IRepository<tbEstadosCiviles>
    {
        public RequestStatus Delete(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Esta_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Esta_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbEstadosCiviles Find(int? id)
        {
            tbEstadosCiviles result = new tbEstadosCiviles();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Esta_Id", id);
                result = db.QueryFirst<tbEstadosCiviles>(ScriptsBaseDeDatos.Esta_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbEstadosCiviles item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Esta_Id", item.Esta_Id);
                parameter.Add("Esta_Descripcion", item.Esta_Descripcion);
                parameter.Add("Esta_UsuarioCreacion", item.Esta_UsuarioCreacion);
                parameter.Add("Esta_FechaCreacion", item.Esta_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Esta_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbEstadosCiviles> List()
        {

            List<tbEstadosCiviles> result = new List<tbEstadosCiviles>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbEstadosCiviles>(ScriptsBaseDeDatos.Esta_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbEstadosCiviles item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Esta_Id", item.Esta_Id);
                parameter.Add("Esta_Descripcion", item.Esta_Descripcion);
                parameter.Add("Esta_UsuarioModifica", item.Esta_UsuarioModifica);
                parameter.Add("Esta_FechaModifica", item.Esta_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Esta_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
