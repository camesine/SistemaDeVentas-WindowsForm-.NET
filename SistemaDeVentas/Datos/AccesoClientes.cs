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
    public class AccesoClientes
    {
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




        public ObservableCollection<Cliente> ObtenerClientes()
        {
            // Instanciamos la variable CN pasandole a su constructor la variable "cadenaConexion".
            CN = new SqlCeConnection(cadenaConexion);
            // Instanciamos la variable CMD pasandole a su constructor la instrucción Sql que debe ejecutar
            // así como  la variable CN que le indica en que base de datos debe ejecutar dicha instrucción.
            CMD = new SqlCeCommand("SELECT * FROM Cliente", CN);
            // Tipo de comando.
            CMD.CommandType = CommandType.Text;

            // Creamos una colección de tipo ProductoVendomatico que "envuelve"
            // a los registros de la tabla que se van a recuperar.
            ObservableCollection<Cliente> ListaDeClientes = new ObservableCollection<Cliente>();

            try // Intentamos...
            {
                CN.Open(); // Abrir la conexión.
                RDR = CMD.ExecuteReader(); // Ejecutar la instrucción SQL SELECT.

                while (RDR.Read()) // recorrer todos los registros recuerados.
                {

                    Cliente ClienteActual =
                        new Cliente((int)RDR["idcliente"], (string)RDR["nombres"], (string)RDR["paterno"],
                            (string)RDR["materno"], (string)RDR["direccion"], (string)RDR["fono"],(string)RDR["email"]);

                    // Agregar el objeto a la coleccion.
                    ListaDeClientes.Add(ClienteActual);
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

            return ListaDeClientes; // Regresamos la lista.
        }

        //Este metodo permite obtener un producto especifico desde la base de datos.
        //Devuelve un objeto de tipo ProductoVendomatico para ser utilizado desde otra clase
        public Cliente ObtenerCliente(int idcliente)
        {
            // se crea la sentencia sql y se insertan los parametros
            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand("SELECT * FROM Cliente WHERE idcliente = @p1", CN);
            CMD.Parameters.AddWithValue("@p1", idcliente);
            CMD.CommandType = CommandType.Text;

            try // Intentamos
            {
                CN.Open(); // Abrir conexión a la Base de datos,.
                RDR = CMD.ExecuteReader(CommandBehavior.SingleRow);// Ejecutar instrucción SQL.

                if (RDR.Read()) // Si se lee el registro (por que si existe) entonces:
                {
                    // Creamos un objeto de tipo ProductoVendomatico que "envuelve"
                    // el registro actual de la tabla.

                    Cliente cliente =
                        new  Cliente((int)RDR["idcliente"], (string)RDR["nombres"], (string)RDR["paterno"],
                            (string)RDR["materno"], (string)RDR["direccion"], (string)RDR["fono"],(string)RDR["email"]);

                    return cliente;
                }
                else // Si no (por que no existe)
                {
                    return null; // Regresamos un valor nulo.
                }

            }
            catch (Exception ex)
            {
                throw ex; // Lanzamos una excepción en caso de haberla ( por ejemplo que no se puede conectar a la Base de Datos)
            }
            finally // Finalmente si se produce o no una excepción, cerramos la conexión.
            {
                CN.Close();
            }

        }




    }
}
