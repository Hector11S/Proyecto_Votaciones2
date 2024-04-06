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
    public partial class MunicipioRepository : IRepository<tbMunicipios>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }
        public RequestStatus Delete(string Muni_Codigo)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Muni_Codigo", Muni_Codigo);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Muni_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbMunicipios Find(int? id)
        {
            throw new NotImplementedException();
        }
        
        public RequestStatus Insert(tbMunicipios item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Muni_Descripcion", item.Muni_Descripcion);
                parameter.Add("Muni_UsuarioCreacion", item.Muni_UsuarioCreacion);
                parameter.Add("Muni_FechaCreacion", item.Muni_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Muni_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbMunicipios> List()
        {

            List<tbMunicipios> result = new List<tbMunicipios>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbMunicipios>(ScriptsBaseDeDatos.Muni_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }
        public List<tbMunicipios> List(string Muni_Codigo)
        {

            List<tbMunicipios> result = new List<tbMunicipios>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Muni_Codigo", Muni_Codigo);
                result = db.Query<tbMunicipios>(ScriptsBaseDeDatos.Muni_ListarPorDept, parameter, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbMunicipios item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Muni_Descripcion", item.Muni_Descripcion);
                parameter.Add("Muni_UsuarioModifica", 2);
                parameter.Add("Muni_FechaModifica", DateTime.Now);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Muni_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
