﻿using System;
using System.Collections.Generic;
using System.Text;
using Entity.Interfaces;

namespace Entity.Models
{
    public class Persona : Metodos
    {
        protected string Identidad { get; set; }
        private string Nombre { get; set; }
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

        public void MostrarInfo()
        {
            Console.WriteLine("{0}{1}", "Identidad: ", this.Identidad);
            Console.WriteLine("{0}{1}", "Nombre: ", this.Nombre);
            Console.WriteLine("{0}{1}", "Edad: ", this.Edad);
            Console.WriteLine("{0}{1}", "Sexo: ", this.Sexo);
        }

        public void Imprimir()
        {
            Console.WriteLine("{0}{1}", "Identidad: ", this.Identidad);
            Console.WriteLine("{0}{1}", "Nombre: ", this.Nombre);
            Console.WriteLine("{0}{1}", "Edad: ", this.Edad);
            Console.WriteLine("{0}{1}", "Sexo: ", this.Sexo);
        }

        public void incrementarValor()
        {
            
        }
        public double getValor()
        {
            return 0.00;
        }



    }
}
