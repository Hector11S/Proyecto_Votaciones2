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
    public partial class PresidenteRepository : IRepository<tbPresidentes>
    {
        public RequestStatus Delete(int? Pres_Id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Pres_Id", Pres_Id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Presi_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbPresidentes Find(int? Pres_Id)
        {
            tbPresidentes result = new tbPresidentes();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Pres_Id", Pres_Id);
                result = db.QueryFirst<tbPresidentes>(ScriptsBaseDeDatos.Presi_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbPresidentes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Pres_Id", item.Pres_Id);
                parameter.Add("Pres_Imagen", item.Pres_Imagen);
                parameter.Add("Part_Id", item.Part_Id);
                parameter.Add("Pres_UsuarioCreacion", item.Pres_UsuarioCreacion);
                parameter.Add("Pres_FechaCreacion", item.Pres_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Presi_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbPresidentes> List()
        {

            List<tbPresidentes> result = new List<tbPresidentes>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbPresidentes>(ScriptsBaseDeDatos.Presi_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbPresidentes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Pres_Id", item.Pres_Id);
                parameter.Add("Pres_Imagen", item.Pres_Imagen);
                parameter.Add("Part_Id", item.Part_Id);
                parameter.Add("Pres_UsuarioModifica", item.Pres_UsuarioModifica);
                parameter.Add("Pres_FechaModifica", item.Pres_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Presi_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
