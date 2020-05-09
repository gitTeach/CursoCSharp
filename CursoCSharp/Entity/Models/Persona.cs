using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Persona
    {
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }


        public Persona()
        {

        }


        public Persona (string I, string N, int E, string S)
        {
            this.Identidad = I;
            this.Nombre = N;
            this.Edad = E;
            this.Sexo = S;
        }




    }
}
