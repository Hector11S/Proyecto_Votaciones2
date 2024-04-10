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
    public partial class VotosPorMesasRepository : IRepository<tbVotosPorMesas>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Delete(int VoMe_Id)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("VoMe_Id", VoMe_Id);

                var result = db.QueryFirst(ScriptsBaseDeDatos.VotosPorMesas_Eliminar, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result.Resultado, MessageStatus = (result.Resultado == 1) ? "Exito" : "Error" };
            }
        }

        public tbVotosPorMesas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbVotosPorMesas item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("MePS_Id", item.MePS_Id);
                parameter.Add("VoMe_CandidatoId", item.VoMe_CandidatoId);
                parameter.Add("VoMe_EsPresidente", item.VoMe_EsPresidente);

                var result = db.Execute(ScriptsBaseDeDatos.VotosPorMesas_Insertar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }

        public RequestStatus Insertar(tbVotosPorMesas item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("MePS_Id", item.MePS_Id);
                parameter.Add("VoMe_CandidatoId", item.VoMe_CandidatoId);
                parameter.Add("VoMe_EsPresidente", item.VoMe_EsPresidente);

                var result = db.Execute(ScriptsBaseDeDatos.VotosPorMesas_Insertar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }

        public IEnumerable<tbVotosPorMesas> List()
        {
            List<tbVotosPorMesas> result = new List<tbVotosPorMesas>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var queryResult = db.Query<dynamic>(ScriptsBaseDeDatos.VotosPorMesas_Listar, commandType: CommandType.StoredProcedure);

                foreach (var item in queryResult)
                {
                
                    var viewModel = new tbVotosPorMesas
                    {
                        Nombre = item.Nombre,
                        Apellidos = item.Apellidos,
                        Cargo = item.Cargo,
                        CandidatoId = item.CandidatoId,
                        TotalVotos = item.TotalVotos,
           
                    };
                    result.Add(viewModel);
                }
            }
            return result;
        }

        public List<tbVotosPorMesas> ListAlcaldesPorMunicipio(string Muni_Codigo)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("Muni_Codigo", Muni_Codigo);

                var queryResult = db.Query<dynamic>(ScriptsBaseDeDatos.VotosPorMesas_ListarAlcaldesPorMunicipio, parameter, commandType: CommandType.StoredProcedure).ToList();

                var result = queryResult.Select(item => new tbVotosPorMesas
                {
                    NombreAlcalde = item.NombreAlcalde,
                    ApellidoAlcalde = item.ApellidoAlcalde,
                    CargoAlcalde = item.CargoAlcalde,
                    CandidatoIdAlcalde = item.CandidatoIdAlcalde,
                    TotalVotosAlcalde = item.TotalVotosAlcalde,
                    ColorPartido = item.ColorPartido
                }).ToList();

                return result;
            }
        }


        public IEnumerable<tbVotosPorMesas> ListPresidentes()
        {
            List<tbVotosPorMesas> result = new List<tbVotosPorMesas>();
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var queryResult = db.Query<dynamic>(ScriptsBaseDeDatos.VotosPorMesas_ListarPresidentes, commandType: CommandType.StoredProcedure);

                foreach (var item in queryResult)
                {

                    var viewModel = new tbVotosPorMesas
                    {
                        NombrePresidente = item.NombrePresidente,
                        ApellidoPresidente = item.ApellidoPresidente,
                        CargoPresidente = item.CargoPresidente,
                        CandidatoIdPresidente = item.CandidatoIdPresidente,
                        TotalVotosPresidentes = item.TotalVotosPresidentes,
                        ColorPartido = item.ColorPartido
                    };
                    result.Add(viewModel);
                }
            }
            return result;
        }

        public RequestStatus Update(tbVotosPorMesas item)
        {
            using (var db = new SqlConnection(VotacionesContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("VoMe_Id", item.VoMe_Id);
                parameter.Add("MePS_Id", item.MePS_Id);
                parameter.Add("VoMe_CandidatoId", item.VoMe_CandidatoId);
                parameter.Add("VoMe_EsPresidente", item.VoMe_EsPresidente);

                var result = db.Execute(ScriptsBaseDeDatos.VotosPorMesas_Editar, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }




        tbVotosPorMesas IRepository<tbVotosPorMesas>.Find(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<tbVotosPorMesas> IRepository<tbVotosPorMesas>.List()
        {
            throw new NotImplementedException();
        }
    }
}
