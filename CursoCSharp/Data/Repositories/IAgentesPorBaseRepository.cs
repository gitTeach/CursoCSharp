using Entity.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface IAgentesPorBaseRepository
    {
        AgentesPorBase Listar(int id);

    }
}
