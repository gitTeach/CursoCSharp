using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.DBModels
{
    public class AgentesPorBase
    {

        public int IdBase { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Agente> ListaAgentes  { get; set; }

        public IQueryable<Agente> ListadoDeAgentes { get; set; }


    }
}
