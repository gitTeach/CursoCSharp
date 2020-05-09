using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Fecha
    {
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Año { get; set; }

        public Fecha()
        {

        }
        public Fecha(int pD, int pM, int pA)
        {   
            this.Dia = pD;
            this.Mes = pM;
            this.Año = pA;

            ValidarFecha();
        }

        public void InvalidarFecha()
        {
            Console.WriteLine("Los valores ingresados no cumplian con las validaciones requeridas");

            this.Dia = 0;
            this.Mes = 0;
            this.Año = 0;
        }

        public bool ValidarFecha()
        {
            bool EsValida = true;

            if (Dia < 0 || Mes < 0 || Año < 0)
            {
                InvalidarFecha();
                return false;
            }   

            if (Mes == 1 || Mes == 3 || Mes == 5 || Mes == 7 || Mes == 8 || Mes == 10 || Mes == 12)
            {
                if(Dia > 31)
                {
                    return false;
                }

            }
            else if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
            {
                if (Dia > 30)
                {
                    return false;
                }
            }
            else if (Mes == 2 )
            {
                if (Dia > 28)
                {
                    return false;
                }
            }

            return EsValida;

        }

        public void Imprimir(string Formato)
        {
            switch (Formato)
            {
                case "dd/mm/yyyy":
                    Console.WriteLine("{0}{1}{2}{3}{4}", this.Dia, "/", this.Mes, "/", this.Año);
                    //Console.WriteLine(this.Dia + "/" + this.Mes + "/" + this.Año);
                    break;
                case "mm/dd/yyyy":
                    Console.WriteLine("{0}{1}{2}{3}{4}", this.Mes, "/", this.Dia, "/", this.Año);
                    break;
                case "dd/MM/yyyy":
                    Console.WriteLine("{0}{1}{2}{3}{4}", this.Dia, "/", MesEnLetras(this.Mes), "/", this.Año);
                    break;
                default:
                    break;
            }
        }
        public string MesEnLetras(int pM)
        {
            string MesLetras = "";
            switch (pM)
            {
                case 1:
                    MesLetras = "Enero";
                    break;
                case 2:
                    MesLetras = "Febrero";
                    break;
                case 3:
                    MesLetras = "Marzo";
                    break;
                case 4:
                    MesLetras = "Abril";
                    break;
                case 5:
                    MesLetras = "Mayo";
                    break;
                case 6:
                    MesLetras = "Junio";
                    break;
                case 7:
                    MesLetras = "Julio";
                    break;
                case 8:
                    MesLetras = "Agosto";
                    break;
                case 9:
                    MesLetras = "Septiembre";
                    break;
                case 10:
                    MesLetras = "Octubre";
                    break;
                case 11:
                    MesLetras = "Noviembre";
                    break;
                case 12:
                    MesLetras = "Diciembre";
                    break;
                default:
                    break;
            }

            return MesLetras;
        }

    }
}
