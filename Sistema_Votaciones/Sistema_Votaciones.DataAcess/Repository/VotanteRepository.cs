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
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbVotantes Find(int? id)
        {
            throw new NotImplementedException();
        }
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

        public RequestStatus Insert(tbVotantes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Vota_Nombre", item.Vota_Nombre);
                parameter.Add("Vota_Apellidos", item.Vota_Apellidos);
                parameter.Add("Vota_DNI", item.Vota_DNI);
                parameter.Add("Vota_YaVoto", item.Vota_YaVoto);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Esta_Id", item.Esta_Id);
                parameter.Add("Sede_Id", item.Sede_Id);
                parameter.Add("Mesa_Id", item.Mesa_Id);
                parameter.Add("Vota_UsuarioCreacion", item.Vota_UsuarioCreacion);
                parameter.Add("Vota_FechaCreacion", item.Vota_FechaCreacion);
                parameter.Add("Vota_Permitido", item.Vota_Permitido);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Vota_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbVotantes> List()
        {

            List<tbVotantes> result = new List<tbVotantes>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbVotantes>(ScriptsBaseDeDatos.Vota_ListarCandidatos, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbVotantes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Vota_Nombre", item.Vota_Nombre);
                parameter.Add("Vota_Apellidos", item.Vota_Apellidos);
                parameter.Add("Vota_DNI", item.Vota_DNI);
                parameter.Add("Vota_YaVoto", item.Vota_YaVoto);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Esta_Id", item.Esta_Id);
                parameter.Add("Sede_Id", item.Sede_Id);
                parameter.Add("Mesa_Id", item.Mesa_Id);
                parameter.Add("Vota_UsuarioModifica", item.Vota_UsuarioModifica);
                parameter.Add("Vota_FechaModifica", item.Vota_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Vota_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
