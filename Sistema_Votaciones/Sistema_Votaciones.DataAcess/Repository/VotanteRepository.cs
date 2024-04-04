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
        public RequestStatus Delete(int? Vota_Id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Vota_Id", Vota_Id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Votantes_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
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
                parameter.Add("Vota_Nombre", item.Vota_Nombre);
                parameter.Add("Vota_Apellidos", item.Vota_Apellidos);
                parameter.Add("Vota_DNI", item.Vota_DNI);
                parameter.Add("Vota_YaVoto", item.Vota_YaVoto);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Esta_Id", item.Esta_Id);
                parameter.Add("MePS_Id", item.MePS_Id);
                parameter.Add("Vota_DNI", item.Vota_DNI);
                parameter.Add("Vota_UsuarioCreacion", 2);
                parameter.Add("Vota_FechaCreacion", DateTime.Now);

                var result = db.Execute(ScriptsBaseDeDatos.Votantes_Insertar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }

        public IEnumerable<tbVotantes> List()
        {

            List<tbVotantes> result = new List<tbVotantes>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbVotantes>(ScriptsBaseDeDatos.Votantes_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbVotantes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Vota_Id", item.Vota_Id);
                parameter.Add("Vota_Nombre", item.Vota_Nombre);
                parameter.Add("Vota_Apellidos", item.Vota_Apellidos);
                parameter.Add("Vota_DNI", item.Vota_DNI);
                parameter.Add("Vota_YaVoto", item.Vota_YaVoto);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Esta_Id", item.Esta_Id);
                parameter.Add("MePS_Id", item.MePS_Id);
                parameter.Add("Vota_DNI", item.Vota_DNI);
                parameter.Add("Vota_UsuarioCreacion", 2);
                parameter.Add("Vota_FechaCreacion", DateTime.Now);

                var result = db.Execute(ScriptsBaseDeDatos.Votantes_Editar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }


        public int BuscarVotantePorDNI(string dni)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Vota_DNI", dni);

                return db.ExecuteScalar<int>(ScriptsBaseDeDatos.Votante_BuscarPorDNI, parameter, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
