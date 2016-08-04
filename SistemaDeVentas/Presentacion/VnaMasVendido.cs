using SistemaDeVentas.Clases;
using SistemaDeVentas.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Presentacion
{

    public partial class VnaMasVendido : Form
    {

        private ObservableCollection<Producto> ListadoProductos;
        private AccesoProductos AP = new AccesoProductos();

        private ObservableCollection<Detalle> ListadoDetalles;
        private AccesoDetalle AD = new AccesoDetalle();
        



        private static VnaMasVendido instance;
        public static VnaMasVendido DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new VnaMasVendido();
                return instance;
            }
            set
            {
                instance = value;
            }
        }




        public VnaMasVendido()
        {
            InitializeComponent();
        }



        private void VnaMasVendido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTiendaDataSet.Detalle' Puede moverla o quitarla según sea necesario.
            this.detalleTableAdapter.Fill(this.bDTiendaDataSet.Detalle);
            // TODO: esta línea de código carga datos en la tabla 'bDTiendaDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.bDTiendaDataSet.Producto);
            this.WindowState = FormWindowState.Maximized;
            MasVendido();
        }




        public void MasVendido()
        {
            this.ListadoDetalles = this.AD.ObtenerDetalles();

            int id_masvendido = 0;
            int cantidad = 0;
            int mayor = 0;
            //ALGORITMO PARA OBTENER EL PRODUCTO MAS VENDIDO
            for (int i = 0; i < ListadoDetalles.Count(); i++)
            {
                cantidad = ListadoDetalles[i].Cantidad;

                for (int j = i + 1; j < ListadoDetalles.Count(); j++)
                {
                    if (ListadoDetalles[i].Codproducto == ListadoDetalles[j].Codproducto)
                    {
                        cantidad = cantidad + ListadoDetalles[j].Cantidad;
                    }
                   
                }
                if (cantidad >= mayor)
                {
                    mayor = cantidad;
                    cantidad = 0;
                    id_masvendido = ListadoDetalles[i].Codproducto;
                }
                cantidad = 0;
            }

            

            this.bDTiendaDataSet.Tables[2].DefaultView.RowFilter = ("convert(idproducto,'System.String') like '" + id_masvendido + "%'");
            this.productoDataGridView.DataSource = this.bDTiendaDataSet.Tables[2].DefaultView;
            this.bDTiendaDataSet.Tables[1].DefaultView.RowFilter = ("convert(codproducto,'System.String') like '" + id_masvendido + "%'");
            this.detalleDataGridView.DataSource = this.bDTiendaDataSet.Tables[1].DefaultView;

        }



        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTiendaDataSet);

        }
    
    
    }

}
