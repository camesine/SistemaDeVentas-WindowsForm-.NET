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
    public class AccesoVenta
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





        public void GuardarNuevaVenta()
        {


            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand();
            CMD.Connection = CN;
            CMD.CommandType = CommandType.Text;

            //se crea la sentencia sql
            CMD.CommandText = "INSERT venta (fecha, neto, iva, total, condiciones, cod_cliente) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)";

            //se le agregan los parametros a la consulta

            CMD.Parameters.AddWithValue("@p1", DateTime.Today );
            CMD.Parameters.AddWithValue("@p2", 0);
            CMD.Parameters.AddWithValue("@p3", 0);
            CMD.Parameters.AddWithValue("@p4", 0);
            CMD.Parameters.AddWithValue("@p5", "");
            CMD.Parameters.AddWithValue("@p6", 1);

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

            
        }


        public ObservableCollection<Venta> ObtenerVentas()
        {
            // Instanciamos la variable CN pasandole a su constructor la variable "cadenaConexion".
            CN = new SqlCeConnection(cadenaConexion);
            // Instanciamos la variable CMD pasandole a su constructor la instrucción Sql que debe ejecutar
            // así como  la variable CN que le indica en que base de datos debe ejecutar dicha instrucción.
            CMD = new SqlCeCommand("SELECT * FROM venta", CN);
            // Tipo de comando.
            CMD.CommandType = CommandType.Text;

            // Creamos una colección de tipo ProductoVendomatico que "envuelve"
            // a los registros de la tabla que se van a recuperar.
            ObservableCollection<Venta> ListaDeVentas =
                new ObservableCollection<Venta>();

            try // Intentamos...
            {
                CN.Open(); // Abrir la conexión.
                RDR = CMD.ExecuteReader(); // Ejecutar la instrucción SQL SELECT.

                while (RDR.Read()) // recorrer todos los registros recuerados.
                {

                    Venta ventaactual =
                        new Venta((int)RDR["idventa"], (DateTime)RDR["fecha"], (int)RDR["neto"],
                            (int)RDR["iva"], (int)RDR["total"], (string)RDR["condiciones"],(int)RDR["cod_cliente"]);

                    // Agregar el objeto a la coleccion.
                    ListaDeVentas.Add(ventaactual);
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

            return ListaDeVentas; // Regresamos la lista.
        }


        public Boolean ActualizarVenta(Venta v)
        {
            Boolean ok = true;
            //se instancia la cadena de conexion a la base de datos y la sentencia sql pasandole los parametros
            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand
            ("UPDATE venta SET fecha = @p1, neto = @p2, iva = @p3, total = @p4 , condiciones = @p5 , cod_cliente = @p6  WHERE idventa = @p7", CN);

            CMD.CommandType = CommandType.Text;


            CMD.Parameters.AddWithValue("@p1", v.Fecha);
            CMD.Parameters.AddWithValue("@p2", v.Neto);
            CMD.Parameters.AddWithValue("@p3", v.Iva);
            CMD.Parameters.AddWithValue("@p4", v.Total);
            CMD.Parameters.AddWithValue("@p5", v.Condiciones);
            CMD.Parameters.AddWithValue("@p6", v.Cod_cliente);
            CMD.Parameters.AddWithValue("@p7", v.Idventa);


            try
            {
                CN.Open();
                CMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ok = false;
                throw ex;
            }
            finally
            {
                CN.Close();
            }
            return ok;
        }


        public Boolean BorrarVenta(int id)
        {
            Boolean ok = true;
            //se declara la ruta de conexion a la base de datos, la sentencia sql pasandole el tipo de comando y parametros
            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand("DELETE FROM venta WHERE idventa = @p1", CN);
            CMD.CommandType = CommandType.Text;
            CMD.Parameters.AddWithValue("@p1", id);

            try
            {
                CN.Open();
                CMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ok = false;
                throw ex;
            }
            finally
            {
                CN.Close();
            }
            return ok;
        }
       

    }
}
