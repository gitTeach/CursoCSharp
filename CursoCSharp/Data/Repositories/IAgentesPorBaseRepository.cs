using Entity.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public interface IAgentesPorBaseRepository
    {
        AgentesPorBase Listar(int id);

        IQueryable<ListaAgentePorBases> ListarAgentes(int idBase);
        int CantAgentexBase(int idBase);


    }
}
