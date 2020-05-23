using System;
using System.Collections.Generic;
using System.Text;
using Entity.DBModels;

namespace Data.Repositories
{
    public interface IAgenteRepository
    {

        bool Save();

        Agente GetbyId();

        List<Agente> GetAll();

        bool Update();

        bool Delete();

        bool Exist();



    }


}
