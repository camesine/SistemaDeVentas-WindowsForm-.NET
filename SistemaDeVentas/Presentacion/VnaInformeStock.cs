using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Presentacion
{
    public partial class VnaInformeStock : Form
    {


        private static VnaInformeStock instance;
        public static VnaInformeStock DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new VnaInformeStock();
                return instance;
            }
            set
            {
                instance = value;
            }
        }




        public VnaInformeStock()
        {
            InitializeComponent();
        }



        private void VnaInformeStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTiendaDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.bDTiendaDataSet.Producto);
            this.WindowState = FormWindowState.Maximized;
        }



        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTiendaDataSet);

        }
    }
}
