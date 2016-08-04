using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Clases
{
    public class Detalle
    {

        private int iddetalle;

        public int Iddetalle
        {
            get { return iddetalle; }
            set { iddetalle = value; }
        }


        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private int subtotal;

        public int Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }


        private int codproducto;

        public int Codproducto
        {
            get { return codproducto; }
            set { codproducto = value; }
        }


        private int codventa;

        public int Codventa
        {
            get { return codventa; }
            set { codventa = value; }
        }

        public Detalle(int iddetalle, int cantidad, int precion, int subtotal,
            int codproducto, int codventa)
        {
            this.Iddetalle = iddetalle;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Subtotal = subtotal;
            this.Codproducto = codproducto;
            this.Codventa = codventa;
        }

        public Detalle()
        {
            this.Iddetalle = 0;
            this.Cantidad = 0;
            this.Precio = 0;
            this.Subtotal = 0;
            this.Codproducto = 0;
            this.Codventa = 0;
        }



    }
}
