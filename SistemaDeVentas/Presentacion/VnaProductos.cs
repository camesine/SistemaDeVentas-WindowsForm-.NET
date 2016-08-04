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
    public partial class VnaProductos : Form
    {


        private ObservableCollection<Producto> ListadoProductoADesplegar;
        private AccesoProductos AP = new AccesoProductos();
        private Producto Productoseleccionado;



        private static String mimodo;
        public static String Modo
        {
            get
            {
                if (mimodo == null)
                    Modo = "Buscar";
                return mimodo;
            }
            set
            {
                mimodo = value;

            }
        }



        private static VnaProductos instance;
        public static VnaProductos DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new VnaProductos();
                }
                else
                {
                    //    instance.Activate();
                    instance.recargar();
                }

                return instance;
            }
            set
            {
                instance = value;
            }
        }



        private void recargar()
        {
            this.cargarmodo();
            //this.llenarcombo();
            this.Show();
        }



        public void cargarmodo()
        {
            string Op = VnaProductos.Modo;
            switch (Op)
            {
                case "Buscar": { this.modobuscar(); break; }
                case "Nuevo": { this.modonuevo(); break; }
                case "Modificar": { this.modoedicion(); break; }
                case "Eliminar": { this.modoeliminar(); break; }
                default: { this.modobuscar(); break; }
            }
        }



        private void desabilitarcontroles()
        {
            this.TxtId.ReadOnly = true;
            this.TxtDescripcion.ReadOnly = true;
            this.TxtStock.ReadOnly = true;
            this.TxtPcosto.ReadOnly = true;
            this.TxtUtilidad.ReadOnly = true;
            this.TxtNombreModificar.ReadOnly = true;
        }




        private void abilitarcontroles()
        {
            this.TxtId.ReadOnly = false;
            this.TxtDescripcion.ReadOnly = false;
            this.TxtStock.ReadOnly = false;
            this.TxtPcosto.ReadOnly = false;
            this.TxtUtilidad.ReadOnly = false;
            this.TxtNombreModificar.ReadOnly = false;
        }



        public void Limpiarcontroles()
        {
            this.TxtDescripcion.Text = "";
            this.TxtId.Text = "";
            this.TxtNombre.Text = "";
            this.TxtPcosto.Text = "";
            this.TxtStock.Text = "";
            this.TxtUtilidad.Text = "";
            this.TxtNombreModificar.Text = "";
        }




        public void modobuscar()
        {
            this.TxtNombreModificar.Visible = false;
            this.label7.Visible = false;
            this.llenarcombo();
            this.CmxNombre.Visible = true;
            this.TxtNombre.Visible = false;
            this.desabilitarcontroles();
            this.groupBox2.Visible = false;
            Limpiarcontroles();
            
        }



        public void modonuevo()
        {
            this.TxtNombreModificar.Visible = false;
            this.label7.Visible = false;
            Limpiarcontroles();
            this.CmxNombre.Visible = false;
            this.TxtNombre.Visible = true;
            this.BtnGuardar.Visible = true;
            this.BtnEliminar.Visible = false;
            this.groupBox2.Visible = true;
            abilitarcontroles();
            this.label6.Visible = false;
            this.TxtId.Visible = false;
        }




        public void modoedicion()
        {
            this.TxtNombreModificar.Visible = true;
            this.label7.Visible = true;
            this.llenarcombo();
            this.groupBox2.Visible = true;
            Limpiarcontroles();
            this.CmxNombre.Visible = true;
            this.TxtNombre.Visible = false;
            this.BtnGuardar.Visible = true;
            this.BtnEliminar.Visible = false;
            this.label6.Visible = true;
            this.TxtId.Visible = true;
            abilitarcontroles();
            this.TxtId.ReadOnly = true;
        }



        public void modoeliminar()
        {
            this.TxtNombreModificar.Visible = false;
            this.label7.Visible = false;
            this.llenarcombo();
            this.groupBox2.Visible = true;
            Limpiarcontroles();
            this.CmxNombre.Visible = true;
            this.TxtNombre.Visible = false;
            this.BtnGuardar.Visible = false;
            this.BtnEliminar.Visible = true;
            this.desabilitarcontroles();
        }

        

        public VnaProductos()
        {
            InitializeComponent();
        }

        

        private void VnaProductos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.llenarcombo();

        }



        private void llenarcombo()
        {
            ListadoProductoADesplegar = AP.ObtenerProductos();
            this.CmxNombre.Items.Clear();
            for (int i = 0; i < ListadoProductoADesplegar.Count(); i++)
                this.CmxNombre.Items.Add(ListadoProductoADesplegar[i].Nombre);
        }



        private void CmxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.ListadoProductoADesplegar[this.CmxNombre.SelectedIndex].Idproducto;
            Productoseleccionado = AP.ObtenerProducto(indice);
            this.TxtId.Text = Productoseleccionado.Idproducto.ToString();
        
            TxtDescripcion.Text = Productoseleccionado.Descripcion.ToString();
            TxtStock.Text = Productoseleccionado.Stock.ToString();
            TxtPcosto.Text = Productoseleccionado.Pcosto.ToString();
            TxtUtilidad.Text = Productoseleccionado.Utilidad.ToString();
            TxtNombreModificar.Text = Productoseleccionado.Nombre.ToString();
        }




        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            Boolean ok = false;

            Boolean error = false;

            foreach (char c in this.TxtStock.Text.Trim())// Recorre la cadena caracter por caracter y checa si el caracter actual es un digito.
            {
                if (!char.IsDigit(c))// si no es un digito lanzamos excepción.
                {
                    MessageBox.Show("Error en stock");
                    error = true;
                }
            }
            if (!error)
            {
                foreach (char c in this.TxtPcosto.Text.Trim())// Recorre la cadena caracter por caracter y checa si el caracter actual es un digito.
                {
                    if (!char.IsDigit(c))// si no es un digito lanzamos excepción.
                    {
                        MessageBox.Show("Error en precio costo");
                        error = true;
                    }
                }
            }

            if (!error)
            {
                foreach (char c in this.TxtUtilidad.Text.Trim())// Recorre la cadena caracter por caracter y checa si el caracter actual es un digito.
                {
                    if (!char.IsDigit(c))// si no es un digito lanzamos excepción.
                    {
                        MessageBox.Show("Error en utilidad");
                        error = true;
                    }
                }
            }

            if (!error)
            {

                if (VnaProductos.Modo.Equals("Nuevo"))
                {
                    Producto p = new Producto(0, this.TxtNombre.Text, this.TxtDescripcion.Text, int.Parse(TxtStock.Text), int.Parse(this.TxtPcosto.Text), int.Parse(this.TxtUtilidad.Text));

                    ok = AP.GuardarNuevoProducto(p);
                }

                if (VnaProductos.Modo.Equals("Modificar"))
                {
                    Producto p = new Producto(int.Parse(this.TxtId.Text), this.TxtNombreModificar.Text, this.TxtDescripcion.Text, int.Parse(TxtStock.Text), int.Parse(this.TxtPcosto.Text), int.Parse(this.TxtUtilidad.Text));

                    ok = AP.ActualizarProductoExistente(p);
                }

                if (ok)
                {
                    MessageBox.Show("Guardado correcto");
                    Limpiarcontroles();
                    this.llenarcombo();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }





        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Boolean ok = AP.BorrarProducto(this.TxtId.Text);
            if (ok)
            {
                MessageBox.Show("Producto eliminado");
                Limpiarcontroles();
                this.llenarcombo();
            }
        }




        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }

}
