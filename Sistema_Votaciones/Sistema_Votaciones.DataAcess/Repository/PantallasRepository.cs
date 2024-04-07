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
    public partial class PantallasRepository : IRepository<tbPantallas>
    {
        public RequestStatus Delete(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Pant_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbPantallas Find(int? id)
        {
            tbPantallas result = new tbPantallas();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Pant_Id", id);
                result = db.QueryFirst<tbPantallas>(ScriptsBaseDeDatos.Depa_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbPantallas item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Pant_Id", item.Pant_Id);
                //parameter.Add("Pant_Descripcion", item.Pant_Descripcion);
                parameter.Add("Pant_UsuarioCreacion", item.Pant_UsuarioCreacion);
                parameter.Add("Pant_FechaCreacion", item.Pant_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbPantallas> List()
        {

            List<tbPantallas> result = new List<tbPantallas>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbPantallas>(ScriptsBaseDeDatos.Depa_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbPantallas item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Pant_Id", item.Pant_Id);
                //parameter.Add("Pant_Descripcion", item.Pant_Descripcion);
                parameter.Add("Pant_UsuarioModifica", item.Pant_UsuarioModifica);
                parameter.Add("Pant_FechaModifica", item.Pant_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
