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
    public partial class DepartamentoRepository : IRepository<tbDepartamentos>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }
        public RequestStatus Delete(string Dept_Codigo)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Dept_Codigo", Dept_Codigo);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbDepartamentos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbDepartamentos item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Dept_Codigo", item.Dept_Codigo);
                parameter.Add("Dept_Descripcion", item.Dept_Descripcion);
                parameter.Add("Dept_UsuarioCreacion", item.Dept_UsuarioCreacion);
                parameter.Add("Dept_FechaCreacion", item.Dept_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbDepartamentos> List()
        {

            List<tbDepartamentos> result = new List<tbDepartamentos>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbDepartamentos>(ScriptsBaseDeDatos.Depa_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }
        public tbDepartamentos List(string Dept_Codigo)
        {

            tbDepartamentos result = new tbDepartamentos();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Dept_Codigo", Dept_Codigo);
                result = db.QueryFirst<tbDepartamentos>(ScriptsBaseDeDatos.Depa_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }

        }

        public RequestStatus Update(tbDepartamentos item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Dept_Codigo", item.Dept_Codigo);
                parameter.Add("Dept_Descripcion", item.Dept_Descripcion);
                parameter.Add("Dept_UsuarioModifica", item.Dept_UsuarioModifica);
                parameter.Add("Dept_FechaModifica", item.Dept_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Depa_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }
    }
}
