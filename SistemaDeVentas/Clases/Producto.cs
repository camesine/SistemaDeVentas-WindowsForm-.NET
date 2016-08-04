using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Clases
{
   
        public class Producto : INotifyPropertyChanged // Nuestra clase implementa INotifyPropertyChanged
        {

            // Implementamos la Interfaz INotifyPropertyChanged para notificar a nuestros controles enlazados que una propiedad de
            // esta clase ha cambiado.
            //M�s informaci�n sobre la interfaz INotifyPropertyChanged:
            //http://msdn.microsoft.com/es-mx/library/system.componentmodel.inotifypropertychanged.aspx

            public event PropertyChangedEventHandler PropertyChanged;

            public void OnPropertyChanged(PropertyChangedEventArgs e)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, e);
                }
            }

            // campos y propiedades miembro.
            private int _idproducto;
            public int Idproducto
            {
                get
                {
                    return _idproducto;
                }
                set
                {
                    _idproducto = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Idproducto"));
                }
            }

            private string _nombre;
            public string Nombre
            {
                get { return _nombre; }
                set
                {
                    // Trim() quita los espacios en blanco a la izquierda y a la derecha de la cadena. Luego
                    // checamos si value es una cadena nula o vac�a.

                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new Exception("El campo Nombres es obligatorio");// Lanzamos excepci�n.
                    }

                    _nombre = value;

                    OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
                    OnPropertyChanged(new PropertyChangedEventArgs("NombreCompleto"));
                }
            }

            private string _descripcion;
            public string Descripcion
            {
                get { return _descripcion; }
                set
                {
                    _descripcion = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Descripcion"));
                }
            }

            private int _stock;
            public int Stock
            {
                get { return _stock; }
                set
                {
                    _stock = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Stock"));
                    OnPropertyChanged(new PropertyChangedEventArgs("NombreCompleto"));
                }
            }


            private int _pcosto;
            public int Pcosto
            {
                get { return _pcosto; }
                set
                {
                    _pcosto = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("PCosto"));
                    OnPropertyChanged(new PropertyChangedEventArgs("NombreCompleto"));
                }
            }




            private int _utilidad;
            public int Utilidad
            {
                get { return _utilidad; }
                set
                {
                    _utilidad = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Utilidad"));
                }
            }





            //    Propiedad de solo lectura (no tiene bloque set) que vamos a mostrar en el listbox.
            public string NombreCompleto
            {
                get { return this.Stock + " " + this.Nombre; }
            }


            // Constructor.
            public Producto(int id, string nombre, string descripcion, int stock,
                int pcosto, int utilidad)
            {
                this.Idproducto = id;
                this.Nombre = nombre;
                this.Descripcion = descripcion;
                this.Stock = stock;
                this.Pcosto = pcosto;
                this.Utilidad = utilidad;

            }

        }
    }

