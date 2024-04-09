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
    public partial class SedesRepository : IRepository<tbSedes>
    {
        public RequestStatus Delete(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Sede_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Sede_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbSedes Find(int? id)
        {
            tbSedes result = new tbSedes();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Sede_Id", id);
                result = db.QueryFirst<tbSedes>(ScriptsBaseDeDatos.Sede_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbSedes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Sede_Descripcion", item.Sede_Descripcion);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Sede_UsuarioCreacion", item.Sede_UsuarioCreacion);
                parameter.Add("Sede_FechaCreacion", item.Sede_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Sede_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbSedes> List()
        {

            List<tbSedes> result = new List<tbSedes>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbSedes>(ScriptsBaseDeDatos.Sede_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbSedes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Sede_Id", item.Sede_Id);
                parameter.Add("Sede_Descripcion", item.Sede_Descripcion);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Sede_UsuarioModifica", item.Sede_UsuarioModifica);
                parameter.Add("Sede_FechaModifica", item.Sede_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Sede_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
