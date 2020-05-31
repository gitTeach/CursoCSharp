using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DBModels
{
    public class ListaAgentePorBases
    {
        public int IdAgente { get; set; }
        public string Nombre { get; set; }
        public int? IdBase { get; set; }
        public string NombreBase { get; set; }
    }
}
