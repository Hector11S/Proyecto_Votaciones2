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
    public partial class PartidoRepository : IRepository<tbPartidos>
    {
        public RequestStatus Delete(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Part_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Part_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbPartidos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPartidos item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Part_Descripcion", item.Part_Descripcion);
                parameter.Add("Part_Color", item.Part_Color);
                parameter.Add("Part_Imagen", item.Part_Imagen);
                parameter.Add("Part_UsuarioCreacion", item.Part_UsuarioCreacion);
                parameter.Add("Part_FechaCreacion", item.Part_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Part_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbPartidos> List()
        {

            List<tbPartidos> result = new List<tbPartidos>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbPartidos>(ScriptsBaseDeDatos.Part_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbPartidos item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Part_Id", item.Part_Id);
                parameter.Add("Part_Descripcion", item.Part_Descripcion);
                parameter.Add("Part_Color", item.Part_Color);
                parameter.Add("Part_Imagen", item.Part_Imagen);
                parameter.Add("Part_UsuarioModifica", item.Part_UsuarioModifica);
                parameter.Add("Part_FechaModifica", item.Part_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Part_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
