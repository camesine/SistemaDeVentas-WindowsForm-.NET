using SistemaDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Datos
{
    public class AccesoDetalle
    {

        // Creamos una variable de referencia a la cadena de conexión almacenada en la configuración del proyecto.
        private string cadenaConexion = Properties.Settings.Default.ConexionBD;

        // Variables para recuperar información de la Base de datos
        private SqlCeConnection CN;
        private SqlCeCommand CMD;
        private SqlCeDataReader RDR;

        // El objeto Transaction es especialmente útil cuando se necesita
        // realizar una operacion que requiera insertar filas en varias tablas (por ejemplo una venta)
        // ya que si algo falla en alguna de las tablas, los cambios
        // hechos a las demás se deshacen, evitando así, una pérdida de integridad en los datos.
        private SqlCeTransaction TR;





        public Boolean GuardarNuevoDetalle(Detalle NuevoDetalle)
        {

            Boolean ok = true;

            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand();
            CMD.Connection = CN;
            CMD.CommandType = CommandType.Text;

            //se crea la sentencia sql
            CMD.CommandText = "INSERT Detalle (cantidad, precio, subtotal, codproducto, codventa) VALUES (@p1,@p2,@p3,@p4,@p5)";

            //se le agregan los parametros a la consulta

            CMD.Parameters.AddWithValue("@p1", NuevoDetalle.Cantidad);
            CMD.Parameters.AddWithValue("@p2", NuevoDetalle.Precio);
            CMD.Parameters.AddWithValue("@p3", NuevoDetalle.Subtotal);
            CMD.Parameters.AddWithValue("@p4", NuevoDetalle.Codproducto);
            CMD.Parameters.AddWithValue("@p5", NuevoDetalle.Codventa);

            try
            {
                //se abre la base de datos y se ejecuta la insercion
                CN.Open();
                TR = CN.BeginTransaction();
                CMD.Transaction = TR;
                CMD.ExecuteNonQuery();
                // CMD.ExecuteScalar devuelve object no pude pasar de object a int directamente
                TR.Commit();
            }
            catch (Exception ex)
            {
                ok = false;
                if (TR != null)
                {
                    TR.Rollback(); // Si hay una excepción llamamos al método Rollback() para que deshaga
                    // cualquier cambio hecho a la base de datos.
                }
                throw ex;
            }
            finally
            {
                //se cierra la conexion a la base de datos
                CN.Close();
            }

            return ok;
        }


        public ObservableCollection<Detalle> ObtenerDetalles()
        {
            // Instanciamos la variable CN pasandole a su constructor la variable "cadenaConexion".
            CN = new SqlCeConnection(cadenaConexion);
            // Instanciamos la variable CMD pasandole a su constructor la instrucción Sql que debe ejecutar
            // así como  la variable CN que le indica en que base de datos debe ejecutar dicha instrucción.
            CMD = new SqlCeCommand("SELECT * FROM detalle", CN);
            // Tipo de comando.
            CMD.CommandType = CommandType.Text;

            // Creamos una colección de tipo ProductoVendomatico que "envuelve"
            // a los registros de la tabla que se van a recuperar.
            ObservableCollection<Detalle> ListaDeDetalles =
                new ObservableCollection<Detalle>();

            try // Intentamos...
            {
                CN.Open(); // Abrir la conexión.
                RDR = CMD.ExecuteReader(); // Ejecutar la instrucción SQL SELECT.

                while (RDR.Read()) // recorrer todos los registros recuerados.
                {

                    Detalle DetalleActual =
                        new Detalle((int)RDR["iddetalle"], (int)RDR["cantidad"], (int)RDR["precio"],
                            (int)RDR["subtotal"], (int)RDR["codproducto"], (int)RDR["codventa"]);

                    // Agregar el objeto a la coleccion.
                    ListaDeDetalles.Add(DetalleActual);
                }
            }
            catch (Exception ex)
            {
                throw ex; // Lanzamos excepción.
            }
            finally
            {
                CN.Close(); // Cerramos la conexión.
            }

            return ListaDeDetalles; // Regresamos la lista.
        }





    }
}
