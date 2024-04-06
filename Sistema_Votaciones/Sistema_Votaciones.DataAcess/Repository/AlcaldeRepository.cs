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
    public partial class AlcaldeRepository : IRepository<tbAlcaldes>
    {
        public RequestStatus Delete(int? Alca_Id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Alca_Id", Alca_Id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Alca_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbAlcaldes Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbAlcaldes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Alca_Id", item.Alca_Id);
                parameter.Add("Alca_Imagen", item.Alca_Imagen);
                parameter.Add("Part_Id", item.Part_Id);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Alca_UsuarioCreacion", item.Alca_UsuarioCreacion);
                parameter.Add("Alca_FechaCreacion", item.Alca_FechaCreacion);

                var result = db.Execute(ScriptsBaseDeDatos.Alca_Insertar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }

        public IEnumerable<tbAlcaldes> List()
        {

            List<tbAlcaldes> result = new List<tbAlcaldes>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbAlcaldes>(ScriptsBaseDeDatos.Alca_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus Update(tbAlcaldes item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Alca_Id", item.Alca_Id);
                parameter.Add("Alca_Imagen", item.Alca_Imagen);
                parameter.Add("Part_Id", item.Part_Id);
                parameter.Add("Muni_Codigo", item.Muni_Codigo);
                parameter.Add("Alca_UsuarioModifica", item.Alca_UsuarioCreacion);
                parameter.Add("Alca_FechaModifica", item.Alca_FechaCreacion);

                var result = db.Execute(ScriptsBaseDeDatos.Alca_Editar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }
    }
}
