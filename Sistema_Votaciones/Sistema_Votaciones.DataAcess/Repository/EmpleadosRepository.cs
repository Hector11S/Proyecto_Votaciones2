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
    public partial class EmpleadosRepository : IRepository<tbEmpleados>
    {

        public RequestStatus Update(int? id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Empl_Id", id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Empl_ActivarDesactivar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbEmpleados Find(int? id)
        {
            tbEmpleados result = new tbEmpleados();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Empl_Id", id);
                result = db.QueryFirst<tbEmpleados>(ScriptsBaseDeDatos.Empl_Llenar, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbEmpleados item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Empl_Id", item.Empl_Id);
                parameter.Add("Carg_Id", item.Carg_Id);
                parameter.Add("Part_Id", item.Part_Id);
                parameter.Add("Sede_Id", item.Sede_Id);
                parameter.Add("Mesa_Id", item.Mesa_Id);
                parameter.Add("Empl_UsuarioCreacion", item.Empl_UsuarioCreacion);
                parameter.Add("Empl_FechaCreacion", item.Empl_FechaCreacion);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Empl_Insertar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public IEnumerable<tbEmpleados> List()
        {

            List<tbEmpleados> result = new List<tbEmpleados>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                result = db.Query<tbEmpleados>(ScriptsBaseDeDatos.Empl_Listar, commandType: CommandType.Text).ToList();
                return result;
            }

        }
        public tbEmpleados FindByEmpl(int? id)
        {
            tbEmpleados result = new tbEmpleados();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Empl_Id", id);
                result = db.QueryFirst<tbEmpleados>(ScriptsBaseDeDatos.Empl_LlenarByEmpl, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }


        public RequestStatus Update(tbEmpleados item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Empl_Id", item.Empl_Id);
                parameter.Add("Carg_Id", item.Carg_Id);
                parameter.Add("Part_Id", item.Part_Id);
                parameter.Add("Sede_Id", item.Sede_Id);
                parameter.Add("Mesa_Id", item.Mesa_Id);
                parameter.Add("Empl_UsuarioModifica", item.Empl_UsuarioModifica);
                parameter.Add("Empl_FechaModifica", item.Empl_FechaModifica);

                var result = db.QueryFirst(ScriptsBaseDeDatos.Empl_Editar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
