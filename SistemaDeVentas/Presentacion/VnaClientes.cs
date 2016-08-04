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
    public partial class VnaClientes : Form
    {



        private static VnaClientes instance;
        public static VnaClientes DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new VnaClientes();
                return instance;
            }
            set
            {
                instance = value;
            }
        }




        public VnaClientes()
        {
            InitializeComponent();
        }




        private void VnaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTiendaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.bDTiendaDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'bDTiendaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.bDTiendaDataSet.Cliente);
            this.WindowState = FormWindowState.Maximized;
        }




        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTiendaDataSet);

        }




        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTiendaDataSet);

        }




        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            this.bDTiendaDataSet.Tables[0].DefaultView.RowFilter = ("Nombres like '" + this.TxtBuscar.Text + "%'");
            this.clienteDataGridView.DataSource = this.bDTiendaDataSet.Tables[0].DefaultView;
        }

        
    }
}
