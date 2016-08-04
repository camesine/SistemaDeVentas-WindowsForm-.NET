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
    public partial class VnaInformeMensual : Form
    {


        private AccesoVenta AV = new AccesoVenta();
        private ObservableCollection<Venta> ListadoVentas;
        



        private static VnaInformeMensual instance;
        public static VnaInformeMensual DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new VnaInformeMensual();
                return instance;
            }
            set
            {
                instance = value;
            }
        }



        public VnaInformeMensual()
        {
            InitializeComponent();
            this.ListadoVentas = new ObservableCollection<Venta>();


            this.ListadoVentas = this.AV.ObtenerVentas();

        }



        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTiendaDataSet);

        }



        private void VnaInformeMensual_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTiendaDataSet.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.bDTiendaDataSet.venta);

        }

       
    }
}
