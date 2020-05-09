using System;
using System.Collections.Generic;
using System.Text;
using Entity.Interfaces;

namespace Entity.Models
{
    public class Trabajador : Persona, Metodos
    {
        public string Empresa;
        public string Cargo;
        public double Sueldo;

        public Trabajador()
        {

        }

        public Trabajador(string pE, string pC, double pS)
        {
            this.Empresa = pE;
            this.Cargo = pC;
            this.Sueldo = pS;
        }


        public Trabajador(string I, string N, int E, string S,
            string pE, string pC, double pS) : base(I, N, E, S)
        {
            this.Empresa = pE;
            this.Cargo = pC;
            this.Sueldo = pS;
        }

        public virtual void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("{0}{1}", "Empresa: ", this.Empresa);
            Console.WriteLine("{0}{1}", "Cargo: ", this.Cargo);
            Console.WriteLine("{0}{1}", "Sueldo: ", this.Sueldo);
        }

        public void incrementarValor() {
            this.Sueldo = (this.Sueldo * 0.10) + this.Sueldo;
        }
        public double getValor() {
            return this.Sueldo;
        }

        public void Imprimir()
        {
            base.MostrarInfo();
            Console.WriteLine("{0}{1}", "Empresa: ", this.Empresa);
            Console.WriteLine("{0}{1}", "Cargo: ", this.Cargo);
            Console.WriteLine("{0}{1}", "Sueldo: ", this.Sueldo);
        }

    }
}
