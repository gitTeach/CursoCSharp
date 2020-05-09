using Entity.Models;
using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Console.WriteLine("Hello World!");
            Console.ReadLine();

            //Fundamentos C#

            // Tipos de Variable numericas
            int x;
            long y; 
            float f;
            double d;


            //Variables Cadenda

            string s;
            char c;

            // logico
            bool b;

            int[] miArreglo = new int[4];
            //Persona[] miArregloPersona = new Persona[4]; //Para crear un arreglo de clase.

            miArreglo[0] = 1;
            miArreglo[1] = 2;
            miArreglo[2] = 3;
            miArreglo[3] = 4;
            miArreglo[4] = 5; //Linea dará error por estar fuera de rango


            List<int> miLista = new List<int>();

            //miLista.Add("Juna"); //Esto no es valido debido a que no es un elemento del mismo tipo de la lista
            miLista.Add(1);
            miLista.Add(2);
            miLista.Add(3);
            miLista.Add(4);
            miLista.Add(5);
            miLista.Add(6);


           //Declaracion -- Instanciacion
            Persona P = new Persona();

            P.Identidad = "1605";
            P.Nombre = "Karla";
            P.Edad = 28;
            P.Sexo = "Femenino";

            Persona P2 = new Persona("0501", "Josue", 30, "Masculino");

            Console.WriteLine("=================");
            Console.WriteLine(P.Identidad);
            Console.WriteLine(P.Nombre);
            Console.WriteLine(P.Edad);
            Console.WriteLine(P.Sexo);
            Console.WriteLine("=================");
            Console.WriteLine(P2.Identidad);
            Console.WriteLine(P2.Nombre);
            Console.WriteLine(P2.Edad);
            Console.WriteLine(P2.Sexo);
            Console.WriteLine("=================");


            */

            /*
            #region Ejercicio2LabSemana1

            Factura F = new Factura(1, "Pieza 1", -3, 100);

            Console.WriteLine("El monto es: " + F.ObtenerMonto());
            Console.WriteLine();

            Factura F2 = new Factura(1, "Pieza 1", -3, -100);
            Console.WriteLine("El monto es: " + F.ObtenerMonto());
            Console.WriteLine();

            Factura F3 = new Factura(1, "Pieza 1", 4, 150);
            Console.WriteLine("El monto es: " + F.ObtenerMonto());
            Console.WriteLine();

            #endregion
            */


            #region Ejercicio1LabSemana1
            Fecha F = new Fecha(2, 5, 2020);
            F.Imprimir("dd/mm/yyyy");
            Console.WriteLine("Cambiando formato.....");
            F.Imprimir("mm/dd/yyyy");
            Console.WriteLine("Cambiando formato.....");
            F.Imprimir("dd/MM/yyyy");

            Fecha F2 = new Fecha(32, 1, 2020); //Dia de mas
            Fecha F3 = new Fecha(31, 1, -1); //Año no valido
            Fecha F4 = new Fecha(31, -1, 2020); //Mes no valido
            Fecha F5 = new Fecha(-31, 1, 2020); //Dia no valido
            Fecha F6 = new Fecha(29, 2, 2020); //Dia de mas para Febrero
            Fecha F7 = new Fecha(31, 6, 2020); //Dia de mas para Junio
            Fecha F8 = new Fecha(31, 1, 2020); //Fecha correcta para Enero
            Fecha F9 = new Fecha(30, 6, 2020); //Fecha correcta para Junio

            //Pruebas
           




            #endregion













        }
    }
}
