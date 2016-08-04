using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Clases
{
    public class Venta
    {
        private int idventa;
        public int Idventa
        {
            get { return idventa; }
            set { idventa = value; }
        }



        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }



        private int neto;
        public int Neto
        {
            get { return neto; }
            set { neto = value; }
        }



        private int iva;
        public int Iva
        {
            get { return iva; }
            set { iva = value; }
        }



        private int total;
        public int Total
        {
            get { return total; }
            set { total = value; }
        }


        private string condiciones;
        public string Condiciones
        {
            get { return condiciones; }
            set { condiciones = value; }
        }


        private int cod_ciente;
        public int Cod_cliente
        {
            get { return cod_ciente; }
            set { cod_ciente = value; }
        }




        public Venta(int idventa, DateTime fecha, int neto, int iva, int total,
            string condiciones, int cod_cliente)
        {
            this.Idventa = idventa;
            this.Fecha = fecha;
            this.Neto = neto;
            this.Iva = iva;
            this.Total = total;
            this.Condiciones = condiciones;
            this.Cod_cliente = cod_cliente;

        }


    }
}
