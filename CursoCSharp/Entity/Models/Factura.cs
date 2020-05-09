using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Factura
    {
        public int NPieza { get; set; }
        public string Descripcion { get; set; }
        
        private int _Cantidad;
        public double _Precio;


        public int Cantidad
        {
            get 
            {
                return _Cantidad;
            }
            set
            {
                if (value < 0)
                    _Cantidad = 0;
                else
                    _Cantidad = value;
            }
        }

        public double Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                if (value < 0)
                    _Precio = 0;
                else
                    _Precio = value;
            }
        }

        public Factura()
        {

        }
         
        public Factura(int pNPieza, string pDesc, int pCantidad, double pPrecio)
        {
            this.NPieza = pNPieza;
            this.Descripcion = pDesc;
            this.Cantidad = pCantidad;
            this.Precio = pPrecio;
        }

        public void MiProcedimiento()
        {
            Console.WriteLine("No retorna nada");
        }


        public double ObtenerMonto()
        {
            return (this.Precio * this.Cantidad);
        }

    }
}
