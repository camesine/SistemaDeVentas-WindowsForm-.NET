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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VnaProductos.DefInstance.MdiParent = this;
            VnaProductos.Modo = "Buscar";
            VnaProductos.DefInstance.Show();
            
        }

        private void mantenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VnaClientes.DefInstance.MdiParent = this;
            VnaClientes.DefInstance.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VnaVentas.DefInstance.MdiParent = this;
            VnaVentas.DefInstance.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VnaProductos.DefInstance.MdiParent = this;
            VnaProductos.Modo = "Nuevo";
            VnaProductos.DefInstance.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VnaProductos.DefInstance.MdiParent = this;
            VnaProductos.Modo = "Modificar";
            VnaProductos.DefInstance.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VnaProductos.DefInstance.MdiParent = this;
            VnaProductos.Modo = "Eliminar";
            VnaProductos.DefInstance.Show();
        }

        private void mantenedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VnaVentasMantenedor.DefInstance.MdiParent = this;
            VnaVentasMantenedor.DefInstance.Show();
        }

        private void resumenMensualVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VnaInformeMensual.DefInstance.MdiParent = this;
            VnaInformeMensual.DefInstance.Show();
        }

        private void productoMasVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VnaMasVendido.DefInstance.MdiParent = this;
            VnaMasVendido.DefInstance.Show();
        }

        private void stockPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VnaInformeStock.DefInstance.MdiParent = this;
            VnaInformeStock.DefInstance.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
