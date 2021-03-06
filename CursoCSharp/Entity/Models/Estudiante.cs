﻿using System;
using System.Collections.Generic;
using System.Text;
using Entity.Interfaces;

namespace Entity.Models
{
    public class Estudiante : Persona, Metodos   
    {
        public string IdEstudiante { get; set; }
        public string CentroEstudio { get; set; }
        public int AñoIngreso { get; set; }
        public double Saldo { get; set; }


        public Estudiante()
        {

        }

        public Estudiante(string pId, string pCentro, int pAño, double pSaldo)
        {
            this.IdEstudiante = pId;
            this.CentroEstudio = pCentro;
            this.AñoIngreso = pAño;
            this.Saldo = pSaldo;
        }

        public Estudiante(string I, string N, int E, string S,
                         string pId, string pCentro, int pAño, double pSaldo) : base(I, N, E, S)
        {
            this.IdEstudiante = pId;
            this.CentroEstudio = pCentro;
            this.AñoIngreso = pAño;
            this.Saldo = pSaldo;
        }

        public virtual void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("{0}{1}", "Id: ", this.IdEstudiante);
            Console.WriteLine("{0}{1}", "Centro: ", this.CentroEstudio);
            Console.WriteLine("{0}{1}", "Año: ", this.AñoIngreso);
            Console.WriteLine("{0}{1}", "Saldo: ", this.Saldo);
        }

        public void incrementarValor()
        {
            this.Saldo = (this.Saldo * 0.07) + this.Saldo;
        }
        public double getValor() {
            return this.Saldo;
        }

        public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("{0}{1}", "Id: ", this.IdEstudiante);
            Console.WriteLine("{0}{1}", "Centro: ", this.CentroEstudio);
            Console.WriteLine("{0}{1}", "Año: ", this.AñoIngreso);
            Console.WriteLine("{0}{1}", "Saldo: ", this.Saldo);
        }

    }
}
