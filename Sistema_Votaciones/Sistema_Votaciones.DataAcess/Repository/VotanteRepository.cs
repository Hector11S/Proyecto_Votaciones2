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
    public partial class VotanteRepository : IRepository<tbVotantes>
    {
        public tbVotantes Find(string Vota_DNI)
        {
            tbVotantes result = new tbVotantes();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Vota_DNI", Vota_DNI);
                result = db.QueryFirst<tbVotantes>(ScriptsBaseDeDatos.Vota_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();

        }

        public tbVotantes Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbVotantes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Vota_Id", item.Vota_Id);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Vota_UsuarioCreacion", item.Vota_UsuarioCreacion);
                parameter.Add("Vota_FechaCreacion", item.Vota_FechaCreacion);

                var result = db.Execute(ScriptsBaseDeDatos.Vota_Insertar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }

        public IEnumerable<tbVotantes> List()
        {

            List<tbVotantes> result = new List<tbVotantes>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbVotantes>(ScriptsBaseDeDatos.Vota_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbVotantes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Vota_Id", item.Vota_Id);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Vota_UsuarioCreacion", item.Vota_UsuarioCreacion);
                parameter.Add("Vota_FechaCreacion", item.Vota_FechaCreacion);

                var result = db.Execute(ScriptsBaseDeDatos.Vota_Editar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }
    }
}
