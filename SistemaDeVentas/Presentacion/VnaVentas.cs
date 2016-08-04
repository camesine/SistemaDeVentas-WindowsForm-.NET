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
    public partial class VnaVentas : Form
    {
        private AccesoDetalle AD = new AccesoDetalle();
        private Detalle detalleseleccionado;


        private AccesoVenta AV = new AccesoVenta();
        private ObservableCollection<Venta> ListadoVentas;
        private Venta VentaSeleccionada;


        private ObservableCollection<Producto> ListadoProductoADesplegar;
        private AccesoProductos AP = new AccesoProductos();
        private Producto Productoseleccionado;


        private ObservableCollection<Cliente> ListadoClientesADesplegar;
        private AccesoClientes AC = new AccesoClientes();
        private Cliente Clienteseleccionado;


        private static VnaVentas instance;
        public static VnaVentas DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new VnaVentas();
                return instance;
            }
            set
            {
                instance = value;
            }
        }



        public VnaVentas()
        {
            InitializeComponent();
        }



        private void VnaVentas_Load(object sender, EventArgs e)
        {
            this.bDTiendaDataSet.Tables[1].DefaultView.RowFilter = ("convert(codventa,'System.String') like '" + 0 + "%'");
            this.detalleDataGridView.DataSource = this.bDTiendaDataSet.Tables[1].DefaultView;

            
            this.detalleTableAdapter.Fill(this.bDTiendaDataSet.Detalle);
            
            this.detalleTableAdapter.Fill(this.bDTiendaDataSet.Detalle);
            
            this.WindowState = FormWindowState.Maximized;
            this.TxtNombre.ReadOnly = true;
            this.TxtPaterno.ReadOnly = true;
            this.TxtMaterno.ReadOnly = true;
            
            this.ListadoClientesADesplegar = this.AC.ObtenerClientes();
            this.CargarComboCliente();


            this.TxtNombreProducto.ReadOnly = true;
            
            this.ListadoProductoADesplegar = this.AP.ObtenerProductos();
            this.CargarComboProducto();

            this.TxtIdVenta.ReadOnly = true;
            this.TxtIva.ReadOnly = true;
            this.TxtNeto.ReadOnly = true;
            this.TxtTotal.ReadOnly = true;
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.TxtDineroCliente.Enabled = false;
            this.txtvuelto.Enabled = false;
            this.BtnNuevaVenta.Focus();
            this.BtnTerminarVenta.Enabled = false;
            this.BtnCancelarVenta.Enabled = false;
            
        }




        public void CargarComboCliente()
        {
            for (int i = 0; i < this.ListadoClientesADesplegar.Count(); i++)
            {
                this.CmxIdCliente.Items.Add(ListadoClientesADesplegar[i].Idcliente);
            }

        }




        public void CargarComboProducto()
        {
            for (int i = 0; i < this.ListadoProductoADesplegar.Count(); i++)
            {
                this.CmxIdProducto.Items.Add(ListadoProductoADesplegar[i].Idproducto);
            }

        }





        private void CmxIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = this.ListadoClientesADesplegar[this.CmxIdCliente.SelectedIndex].Idcliente;
            
            Clienteseleccionado = AC.ObtenerCliente(indice);
            
            this.TxtNombre.Text = Clienteseleccionado.Nombres.ToString();
            this.TxtMaterno.Text = Clienteseleccionado.Materno.ToString();
            this.TxtPaterno.Text = Clienteseleccionado.Paterno.ToString();

        }




        private void CmxIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = this.ListadoProductoADesplegar[this.CmxIdProducto.SelectedIndex].Idproducto;

            Productoseleccionado = AP.ObtenerProducto(indice);

            this.TxtNombreProducto.Text = Productoseleccionado.Nombre.ToString();

        }




        private void detalleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detalleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTiendaDataSet);

        }




        private void detalleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.detalleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTiendaDataSet);

        }




        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {

            this.AV.GuardarNuevaVenta();

            this.ListadoVentas = this.AV.ObtenerVentas();

            int mayor = 0;

            for (int i = 0; i < ListadoVentas.Count(); i++)
            {
                if (ListadoVentas[i].Idventa > mayor)
                {
                    this.VentaSeleccionada = ListadoVentas[i];
                }
            }

            this.TxtIdVenta.Text = VentaSeleccionada.Idventa.ToString();
            this.TxtNeto.Text = VentaSeleccionada.Neto.ToString();
            this.TxtIva.Text = VentaSeleccionada.Iva.ToString();
            this.TxtTotal.Text = VentaSeleccionada.Total.ToString();

            this.groupBox1.Enabled = true;
            this.groupBox2.Enabled = true;
            this.groupBox3.Enabled = true;
            this.TxtDineroCliente.Enabled = true;
            this.txtvuelto.Enabled = true;
            this.BtnTerminarVenta.Enabled = true;
            this.BtnCancelarVenta.Enabled = true;
            this.BtnNuevaVenta.Enabled = false;
            this.groupBox1.Enabled = true;
            
        }




        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Boolean ok = true;

            if (this.TxtNombre.Text.Equals(null) || this.TxtNombre.Text.Equals("") && ok)
            {
                MessageBox.Show("Error cliente");
                ok = false;
            }

            if (this.TxtCondiciones.Text.Equals(null) || this.TxtCondiciones.Text.Equals("") && ok)
            {
                MessageBox.Show("Error en condiciones");
                ok = false;
            }

            if (this.TxtNombreProducto.Text.Equals(null) || this.TxtNombreProducto.Text.Equals("") && ok)
            {
                MessageBox.Show("Error Producto");
                ok = false;
            }

            if (this.TxtCantidadProducto.Text.Equals(null) || this.TxtCantidadProducto.Text.Equals("") && ok)
            {
                MessageBox.Show("Error en cantidad");
                ok = false;
            }


            if (ok)
            {
                foreach (char c in this.TxtCantidadProducto.Text.Trim())// Recorre la cadena caracter por caracter y checa si el caracter actual es un digito.
                {
                    if (!char.IsDigit(c))// si no es un digito lanzamos excepción.
                    {
                        MessageBox.Show("Error en cantidad");
                        ok = false;
                    }
                }
            }
            

            if (ok)
            {
                this.detalleseleccionado = new Detalle();

                this.detalleseleccionado.Cantidad = int.Parse(this.TxtCantidadProducto.Text);
                this.detalleseleccionado.Precio = Productoseleccionado.Pcosto / 100 * Productoseleccionado.Utilidad;
                this.detalleseleccionado.Subtotal = detalleseleccionado.Cantidad * detalleseleccionado.Precio;
                this.detalleseleccionado.Codproducto = Productoseleccionado.Idproducto;
                this.detalleseleccionado.Codventa = this.VentaSeleccionada.Idventa;

                if (this.detalleseleccionado.Cantidad <= this.Productoseleccionado.Stock)
                {
                    this.AD.GuardarNuevoDetalle(detalleseleccionado);
                    this.AP.ActualizarStockCompra(Productoseleccionado.Idproducto, detalleseleccionado.Cantidad);

                    this.bDTiendaDataSet.Clear();
                    this.detalleTableAdapter.Fill(this.bDTiendaDataSet.Detalle);


                    this.VentaSeleccionada.Neto = this.VentaSeleccionada.Neto + this.detalleseleccionado.Subtotal;
                    this.TxtNeto.Text = VentaSeleccionada.Neto.ToString();
                    this.VentaSeleccionada.Iva = (this.VentaSeleccionada.Neto / 100 * 19);
                    this.TxtIva.Text = VentaSeleccionada.Iva.ToString();
                    this.VentaSeleccionada.Total = this.VentaSeleccionada.Neto + this.VentaSeleccionada.Iva;
                    this.TxtTotal.Text = VentaSeleccionada.Total.ToString();
                    this.groupBox1.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Este producto solo tiene " + this.Productoseleccionado.Stock + " unidades en stock");
                }
            }
        }






        private void BtnTerminarVenta_Click(object sender, EventArgs e)
        {
            this.VentaSeleccionada.Idventa = int.Parse(this.TxtIdVenta.Text);
            this.VentaSeleccionada.Fecha = this.dateTimePicker1.Value;
            this.VentaSeleccionada.Neto = int.Parse(this.TxtNeto.Text);
            this.VentaSeleccionada.Iva = int.Parse(this.TxtIva.Text);
            this.VentaSeleccionada.Total = int.Parse(this.TxtTotal.Text);
            this.VentaSeleccionada.Condiciones = this.TxtCondiciones.Text;
            this.VentaSeleccionada.Cod_cliente = this.Clienteseleccionado.Idcliente;
            
            Boolean ok = true;

            foreach (char c in this.TxtDineroCliente.Text.Trim())// Recorre la cadena caracter por caracter y checa si el caracter actual es un digito.
            {
                if (!char.IsDigit(c))// si no es un digito lanzamos excepción.
                {
                    
                    ok = false;
                }
            }

            if(this.TxtDineroCliente.Text.Equals("") || this.TxtDineroCliente.Text.Equals(null)){

                ok = false;

            }

            if (ok)
            {
                if (int.Parse(this.TxtTotal.Text) > int.Parse(this.TxtDineroCliente.Text))
                {
                    ok = false;
                }
            }

            


            if (ok)
            {
                int vuelto = int.Parse(this.TxtDineroCliente.Text)  - int.Parse(this.TxtTotal.Text) ;
                this.txtvuelto.Text = vuelto.ToString();
                AV.ActualizarVenta(VentaSeleccionada);
                MessageBox.Show("La compra se a hecho correctamente");
               Resetear();
               this.bDTiendaDataSet.Tables[1].DefaultView.RowFilter = ("convert(codventa,'System.String') like '" + 0 + "%'");

               this.detalleDataGridView.DataSource = this.bDTiendaDataSet.Tables[1].DefaultView;
                
                

            }
            else
            {
                MessageBox.Show("Error al realizar la compra");
            }


        }




        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.AV.BorrarVenta(this.VentaSeleccionada.Idventa);
            this.bDTiendaDataSet.Clear();
            this.detalleTableAdapter.Fill(this.bDTiendaDataSet.Detalle);

            Resetear();
        }






        public void Resetear()
        {
            this.txtvuelto.Text = "";
            this.TxtDineroCliente.Text = "";
            this.TxtIdVenta.Text = "";
            this.TxtNeto.Text = "";
            this.TxtIva.Text = "";
            this.TxtTotal.Text = "";
            this.TxtNombre.Text = "";
            this.TxtMaterno.Text = "";
            this.TxtPaterno.Text = "";
            this.TxtNombreProducto.Text = "";
            this.TxtCantidadProducto.Text = "";
            this.TxtCondiciones.Text = "";
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.VentaSeleccionada = null;
            this.Productoseleccionado = null;
            this.Clienteseleccionado = null;
            this.detalleseleccionado = null;
            this.TxtDineroCliente.Enabled = false;
            this.txtvuelto.Enabled = false;
            this.BtnTerminarVenta.Enabled = false;
            this.BtnCancelarVenta.Enabled = false;
            this.BtnNuevaVenta.Enabled = true;
        }





        private void TxtIdVenta_TextChanged(object sender, EventArgs e)
        {
            if (!this.TxtIdVenta.Text.Equals(""))
            {
                this.bDTiendaDataSet.Tables[1].DefaultView.RowFilter = ("convert(codventa,'System.String') like '" + this.TxtIdVenta.Text + "%'");

                this.detalleDataGridView.DataSource = this.bDTiendaDataSet.Tables[1].DefaultView;
            }
        }
        
    }
}
