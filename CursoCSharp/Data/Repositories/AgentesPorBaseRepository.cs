using Data.DbModels;
using Entity.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class AgentesPorBaseRepository : IAgentesPorBaseRepository
    {

        public readonly DB_Context db;
        public AgentesPorBaseRepository()
        {
            db = new DB_Context();
        }

        public int CantAgentexBase(int idBase)
        {
            try
            {
                var data = db.TAgente.Where(x => x.IdBase == idBase && x.Nombre == "Juan").Count();
                return data;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

        public AgentesPorBase Listar(int id)
        {
            try
            {
                AgentesPorBase result = new AgentesPorBase();
                result.ListaAgentes = new List<Agente>();


                var data = db.TBase.Find(id);

                if (data != null)
                {
                    var agentes = db.TAgente.Where(x => x.IdBase == id)
                                            .Select(x => new Agente()
                                            {
                                                IdAgente = x.IdAgente,
                                                Nombre = x.Nombre,
                                                Apellido = x.Apellido
                                            }).OrderByDescending(x=> x.Nombre)
                                            .Take(2);

                    result.ListadoDeAgentes = agentes;

                    foreach (var item in agentes)
                    {
                        result.ListaAgentes.Add(item);
                    }

                    result.IdBase = data.IdBase;
                    result.Nombre = data.Nombre;
                    result.Direccion = data.Direccion;

                    return result;
                }
                else
                {
                    return null;
                }


            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }

        public IQueryable<ListaAgentePorBases> ListarAgentes(int idBase)
        {
            try
            {
                var data = db.TAgente.Where(x => x.IdBase == idBase)
                                       .Select(x => new ListaAgentePorBases
                                       {
                                           IdAgente = x.IdAgente,
                                           Nombre = x.Nombre,
                                           IdBase = x.IdBase,
                                           NombreBase = x.IdBaseNavigation.Nombre
                                       });
                return data != null ? data : null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
