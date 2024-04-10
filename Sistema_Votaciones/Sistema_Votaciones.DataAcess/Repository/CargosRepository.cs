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
    public partial class CargosRepository : IRepository<tbCargos>
    {

        public RequestStatus Delete(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Carg_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Carg_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbCargos Find(int? id)
        {
            tbCargos result = new tbCargos();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Carg_Id", id);
                result = db.QueryFirst<tbCargos>(ScriptsBaseDeDatos.Carg_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbCargos item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Carg_Descripcion", item.Carg_Descripcion);
                parameter.Add("Carg_UsuarioCreacion", item.Carg_UsuarioCreacion);
                parameter.Add("Carg_FechaCreacion", item.Carg_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Carg_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbCargos> List()
        {

            List<tbCargos> result = new List<tbCargos>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbCargos>(ScriptsBaseDeDatos.Carg_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbCargos item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Carg_Id", item.Carg_Id);
                parameter.Add("Carg_Descripcion", item.Carg_Descripcion);
                parameter.Add("Carg_UsuarioModifica", item.Carg_UsuarioModifica);
                parameter.Add("Carg_FechaModifica", item.Carg_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Carg_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
