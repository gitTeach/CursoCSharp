using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.DInjection;

namespace Data
{
    public class DiRegisterData
    {
        public static List<IClassType> GetDataList()
        {
            var list = new List<IClassType>();
            list.Add(new ClassType<IAgenteRepository, AgenteRepository>());
            //list.Add(new ClassType<IClienteRepository, ClienteRepository>());
            return list;
        }
    }
}
