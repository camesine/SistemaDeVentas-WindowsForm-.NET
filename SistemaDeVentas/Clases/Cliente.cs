using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Clases
{
    public class Cliente : INotifyPropertyChanged // Nuestra clase implementa INotifyPropertyChanged
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


        private int idcliente;
        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }



        private string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }


        private string paterno;
        public string Paterno
        {
            get { return paterno; }
            set { paterno = value; }
        }



        private string materno;
        public string Materno
        {
            get { return materno; }
            set { materno = value; }
        }


        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }



        private string fono;
        public string Fono
        {
            get { return fono; }
            set { fono = value; }
        }



        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public Cliente(int idcliente, string nombres, string paterno, 
            string materno, string direccion, string fono, string email)
        {
            this.Idcliente = idcliente;
            this.Nombres = nombres;
            this.Paterno = paterno;
            this.Materno = materno;
            this.Direccion = direccion;
            this.Fono = fono;
            this.Email = email;
        }




    }
}