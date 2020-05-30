using Data.Repositories;
using Entity.DBModels;
using Entity.Models;
using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {

        static AgenteRepository repository = new AgenteRepository();
        static AgentesPorBaseRepository repositoryAgente = new AgentesPorBaseRepository();
        static Agente agente = new Agente();
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


            //#region Ejercicio1LabSemana1
            //Fecha F = new Fecha(2, 5, 2020);
            //F.Imprimir("dd/mm/yyyy");
            //Console.WriteLine("Cambiando formato.....");
            //F.Imprimir("mm/dd/yyyy");
            //Console.WriteLine("Cambiando formato.....");
            //F.Imprimir("dd/MM/yyyy");

            //Fecha F2 = new Fecha(32, 1, 2020); //Dia de mas
            //Fecha F3 = new Fecha(31, 1, -1); //Año no valido
            //Fecha F4 = new Fecha(31, -1, 2020); //Mes no valido
            //Fecha F5 = new Fecha(-31, 1, 2020); //Dia no valido
            //Fecha F6 = new Fecha(29, 2, 2020); //Dia de mas para Febrero
            //Fecha F7 = new Fecha(31, 6, 2020); //Dia de mas para Junio
            //Fecha F8 = new Fecha(31, 1, 2020); //Fecha correcta para Enero
            //Fecha F9 = new Fecha(30, 6, 2020); //Fecha correcta para Junio

            ////Pruebas





            //#endregion

            //#region HerenciaPersona


            //Persona P1 = new Persona();
            //Persona P2 = new Persona("0501", "Josue", 30, "Masculino");

            //Estudiante E1 = new Estudiante();
            //Estudiante E2 = new Estudiante("6121", "Ceutec", 2012, 0.00);
            //Estudiante E3 = new Estudiante("0501", "Josue", 30, "Masculino",
            //                                "6121", "Ceutec", 2012, 1000.00);


            //E3.MostrarInfo();
            //Console.WriteLine("======================");

            //Trabajador T1 = new Trabajador("1605", "Rosa", 31, "Femenino",
            //                                "La Economica", "Gerente General", 18000);

            //E3.incrementarValor();
            //Console.WriteLine("======================");
            //E3.MostrarInfo();
            //Console.WriteLine("======================");


            //T1.incrementarValor();
            //Console.WriteLine("======================");
            //T1.MostrarInfo();
            //Console.WriteLine("======================");




            //#endregion

            #region
            // Figura f = new Figura(); 
            //No se puede instanciar debido a que Figura es clase abstracta

            /*
            Figura F = new Cilindro(2, 4);
            Console.WriteLine("====== Polimorfismo =======");
            Console.WriteLine("====== Cilindro =======");
            Console.WriteLine(F.Area());
            Console.WriteLine(F.AreaAbstracto());
            Console.WriteLine("====== Polimorfismo =======");
            Console.WriteLine("====== Triangulo =======");
            F = new Triangulo(2, 4);
            Console.WriteLine(F.Area());
            Console.WriteLine(F.AreaAbstracto());
            */

            /*agente.Nombre = "Jose";
            agente.Apellido = "Lizandro";
            agente.Salario = 30000;
            agente.NumeroTelefono = "11223344";
            */

            /*
            var guardar = repository.Save(agente);

            Console.WriteLine(guardar);
            agente.IdAgente = 7;
            agente.IdBase = 1;
            var actualizar = repository.Update(agente);
            Console.WriteLine(actualizar);

            */
            #endregion

            /*
            #region Menu
            int resp = 1;
            bool operacionexitosa = false;

            do
            {
                Console.WriteLine("============================");
                Console.WriteLine("1. Registrar agente");
                Console.WriteLine("2. Actualizar agente");
                Console.WriteLine("3. Eliminar agente");
                Console.WriteLine("4. Buscar agente");
                Console.WriteLine("5. Listar todos los agentes");
                Console.WriteLine("6. Asociar Agente a Base");
                Console.WriteLine("7. Salir");
                Console.WriteLine("============================");

                Console.WriteLine("Ingrese opcion");
                resp = Convert.ToInt32(Console.ReadLine());

                switch (resp)
                {
                    case 1:
                        agente = Agregar();
                        operacionexitosa = repository.Save(agente);

                        if (operacionexitosa)
                            Console.WriteLine("Se ha agregado el registro");
                        break;
                    case 4:
                        Buscar();
                        break;
                    case 5:
                        Listar();
                        break;

                    default:
                        break;
                }


            } while (resp != 7);

            #endregion Menu
            */

            /*Semana 5*/

            #region AgentePorBase

            var data = repositoryAgente.Listar(1);

            if (data != null)
            {
                
                Console.WriteLine("{0} : {1}", "Id Base", data.IdBase);
                Console.WriteLine("{0} : {1}", "Nombre", data.Nombre);
                Console.WriteLine("{0} : {1}", "Direccion", data.Direccion);

                foreach (var item in data.ListaAgentes)
                {
                    Console.WriteLine("==================");
                    Console.WriteLine("{0} : {1}", "Id Agente", item.IdAgente);
                    Console.WriteLine("{0} : {1}", "Nombre", item.Nombre);
                    Console.WriteLine("{0} : {1}", "Apellido", item.Apellido);
                }

            }

            #endregion










        }

        static Agente Agregar()
        {
            Agente agente = new Agente();
            Console.WriteLine("Nombre: ");
            agente.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            agente.Apellido = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            agente.NumeroTelefono = Console.ReadLine();
            Console.WriteLine("Salario: ");
            agente.Salario = Convert.ToDecimal(Console.ReadLine());

            return agente;
        }

        static Agente Actualizar()
        {
            Agente agente = new Agente();
            Console.WriteLine("Nombre: ");
            agente.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            agente.Apellido = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            agente.NumeroTelefono = Console.ReadLine();
            Console.WriteLine("Salario: ");
            agente.Salario = Convert.ToDecimal(Console.ReadLine());

            return agente;
        }

        static void Buscar()
        {
            Console.WriteLine("Ingrese el id del agente");
            int id = Convert.ToInt32(Console.ReadLine());
            agente = repository.GetbyId(id);
            if (agente != null)
            {
                MostrarInfo(agente);
            }
        }

        static void Listar()
        {
            var data = repository.GetAll();
            if (data != null)
            {
                Console.Clear();
                foreach (var item in data)
                {
                    MostrarInfo(item);
                }
            }
        }

        static void MostrarInfo(Agente agente)
        {   
            Console.WriteLine("======================");
            Console.WriteLine("{0} : {1}", "Id", agente.IdAgente);
            Console.WriteLine("{0} : {1}", "Nombre", agente.Nombre);
            Console.WriteLine("{0} : {1}", "Apellido", agente.Apellido);
            Console.WriteLine("{0} : {1}", "IdBase", agente.IdBase);
            Console.WriteLine("{0} : {1}", "Numero Telefono", agente.NumeroTelefono);
            Console.WriteLine("{0} : {1}", "Salario", agente.Salario);
            Console.WriteLine("======================");
        }

    
    }
}
