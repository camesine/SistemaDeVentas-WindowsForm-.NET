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
    public partial class VnaVentasMantenedor : Form
    {



        private static VnaVentasMantenedor instance;
        public static VnaVentasMantenedor DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new VnaVentasMantenedor();
                return instance;
            }
            set
            {
                instance = value;
            }
        }





        public VnaVentasMantenedor()
        {
            InitializeComponent();
        }




        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTiendaDataSet);

        }




        private void VnaVentasMantenedor_Load(object sender, EventArgs e)
        {
            this.ventaTableAdapter.Fill(this.bDTiendaDataSet.venta);
            this.WindowState = FormWindowState.Maximized;
        }




        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

            this.bDTiendaDataSet.Tables[3].DefaultView.RowFilter = ("convert(idventa,'System.String') like '" + this.TxtBuscar.Text + "%'"); 
            this.ventaDataGridView.DataSource = this.bDTiendaDataSet.Tables[3].DefaultView;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
