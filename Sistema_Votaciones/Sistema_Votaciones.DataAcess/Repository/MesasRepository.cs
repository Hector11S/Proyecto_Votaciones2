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
    public partial class MesasRepository : IRepository<tbMesas>
    {
        public RequestStatus Delete(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Mesa_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Mesa_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbMesas Find(int? id)
        {
            tbMesas result = new tbMesas();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Mesa_Id", id);
                result = db.QueryFirst<tbMesas>(ScriptsBaseDeDatos.Mesa_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbMesas item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Mesa_Numero", item.Mesa_Numero);
                parameter.Add("Mesa_UsuarioCreacion", item.Mesa_UsuarioCreacion);
                parameter.Add("Mesa_FechaCreacion", item.Mesa_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Mesa_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbMesas> List()
        {

            List<tbMesas> result = new List<tbMesas>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbMesas>(ScriptsBaseDeDatos.Mesa_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbMesas item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Mesa_Id", item.Mesa_Id);
                parameter.Add("Mesa_Numero", item.Mesa_Numero);
                parameter.Add("Mesa_UsuarioModifica", item.Mesa_UsuarioModifica);
                parameter.Add("Mesa_FechaModifica", item.Mesa_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Mesa_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
