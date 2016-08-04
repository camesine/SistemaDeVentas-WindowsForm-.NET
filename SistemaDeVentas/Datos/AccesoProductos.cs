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
    public class AccesoProductos
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


        //Metodo que permite guardar un nuevo producto utilizando como parametro un objeto de tipo ProductoVendomatico
        public Boolean GuardarNuevoProducto(Producto NuevoProducto)
        {

            Boolean ok = true;

            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand();
            CMD.Connection = CN;
            CMD.CommandType = CommandType.Text;

            //se crea la sentencia sql
            CMD.CommandText = "INSERT Producto (nombre, descripcion, stock , pcosto, utilidad) VALUES (@p1,@p2,@p3,@p4,@p5)";

            //se le agregan los parametros a la consulta
     
            CMD.Parameters.AddWithValue("@p1", NuevoProducto.Nombre);
            CMD.Parameters.AddWithValue("@p2", NuevoProducto.Descripcion);
            CMD.Parameters.AddWithValue("@p3", NuevoProducto.Stock);
            CMD.Parameters.AddWithValue("@p4", NuevoProducto.Pcosto);
            CMD.Parameters.AddWithValue("@p5", NuevoProducto.Utilidad);

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





        //Este metodo permite obtener un producto especifico desde la base de datos.
        //Devuelve un objeto de tipo ProductoVendomatico para ser utilizado desde otra clase
        public Producto ObtenerProducto(int idABuscar)
        {
            // se crea la sentencia sql y se insertan los parametros
            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand("SELECT * FROM Producto WHERE idproducto = @p1", CN);
            CMD.Parameters.AddWithValue("@p1", idABuscar);
            CMD.CommandType = CommandType.Text;

            try // Intentamos
            {
                CN.Open(); // Abrir conexión a la Base de datos,.
                RDR = CMD.ExecuteReader(CommandBehavior.SingleRow);// Ejecutar instrucción SQL.

                if (RDR.Read()) // Si se lee el registro (por que si existe) entonces:
                {
                    // Creamos un objeto de tipo ProductoVendomatico que "envuelve"
                    // el registro actual de la tabla.

                    Producto producto =
                        new Producto((int)RDR["idproducto"], (string)RDR["nombre"], (string)RDR["descripcion"],
                            (int)RDR["stock"], (int)RDR["pcosto"], (int)RDR["utilidad"]);

                    return producto; 
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

        // Método que obtiene todos los productos de la tabla de productos.
        public ObservableCollection<Producto> ObtenerProductos()
        {
            // Instanciamos la variable CN pasandole a su constructor la variable "cadenaConexion".
            CN = new SqlCeConnection(cadenaConexion);
            // Instanciamos la variable CMD pasandole a su constructor la instrucción Sql que debe ejecutar
            // así como  la variable CN que le indica en que base de datos debe ejecutar dicha instrucción.
            CMD = new SqlCeCommand("SELECT * FROM Producto", CN);
            // Tipo de comando.
            CMD.CommandType = CommandType.Text;

            // Creamos una colección de tipo ProductoVendomatico que "envuelve"
            // a los registros de la tabla que se van a recuperar.
            ObservableCollection<Producto> ListaDeProductos =
                new ObservableCollection<Producto>();

            try // Intentamos...
            {
                CN.Open(); // Abrir la conexión.
                RDR = CMD.ExecuteReader(); // Ejecutar la instrucción SQL SELECT.

                while (RDR.Read()) // recorrer todos los registros recuerados.
                {
                    
                    Producto ProductoActual =
                        new Producto ((int)RDR["idproducto"], (string)RDR["nombre"], (string)RDR["descripcion"],
                            (int)RDR["stock"], (int)RDR["pcosto"], (int)RDR["utilidad"]);

                    // Agregar el objeto a la coleccion.
                    ListaDeProductos.Add(ProductoActual);
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

            return ListaDeProductos; // Regresamos la lista.
        }

        // Método que actualiza un productos existente de la tabla de productos.
        public Boolean ActualizarProductoExistente(Producto Producto)
        {
            Boolean ok = true;
            //se instancia la cadena de conexion a la base de datos y la sentencia sql pasandole los parametros
            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand
            ("UPDATE Producto SET nombre = @p1, descripcion = @p2, stock = @p3, pcosto = @p4 , utilidad = @p5 WHERE idproducto = @p6", CN);

            CMD.CommandType = CommandType.Text;


            CMD.Parameters.AddWithValue("@p1", Producto.Nombre);
            CMD.Parameters.AddWithValue("@p2", Producto.Descripcion);
            CMD.Parameters.AddWithValue("@p3", Producto.Stock);
            CMD.Parameters.AddWithValue("@p4", Producto.Pcosto);
            CMD.Parameters.AddWithValue("@p5", Producto.Utilidad);
            CMD.Parameters.AddWithValue("@p6", Producto.Idproducto);
            

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

        //Metodo que permite borrar un producto de la tabla productos utilizando como parametro la clave primaria id
        public Boolean BorrarProducto(string id)
        {
            Boolean ok = true;
            //se declara la ruta de conexion a la base de datos, la sentencia sql pasandole el tipo de comando y parametros
            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand("DELETE FROM Producto WHERE idproducto = @p1", CN);
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

        //Permite actualizar el stock del produto en la tabla productos reduciendo el stock en -1 por cada compra en el vendomatico
        public void ActualizarStockCompra(int id, int cantidad )
        {
            int stock = this.ObtenerStock(id);
            stock = stock - cantidad;

            //se crea la sentencia sql pasandole los parametros necesarion
            CN = new SqlCeConnection(cadenaConexion);
            CMD = new SqlCeCommand
            ("UPDATE Producto SET stock = @p1 WHERE idproducto = @p2", CN);

            CMD.CommandType = CommandType.Text;


            
            CMD.Parameters.AddWithValue("@p1", stock);
            
            CMD.Parameters.AddWithValue("@p2", id);


            try
            {
                CN.Open();
                CMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CN.Close();
            }
        }


        //este metodo obtiene el stock de un producto utilizando como parametro el id, asi podemos ver si es factible 
        //comprar el producto dependiendo el stock
        public int ObtenerStock(int id)
        {
            // Instanciamos la variable CN pasandole a su constructor la variable "cadenaConexion".
            CN = new SqlCeConnection(cadenaConexion);
            // Instanciamos la variable CMD pasandole a su constructor la instrucción Sql que debe ejecutar
            // así como  la variable CN que le indica en que base de datos debe ejecutar dicha instrucción.
            CMD = new SqlCeCommand("SELECT stock FROM Producto WHERE idproducto = @p1", CN);
            // Tipo de comando.
            CMD.CommandType = CommandType.Text;
            CMD.Parameters.AddWithValue("@p1", id);
            // Creamos una colección de tipo ProductoVendomatico que "envuelve"
            // a los registros de la tabla que se van a recuperar.
            int stock = 0;

            try // Intentamos...
            {
                CN.Open(); // Abrir la conexión.
                RDR = CMD.ExecuteReader(); // Ejecutar la instrucción SQL SELECT.

                while (RDR.Read()) // recorrer todos los registros recuerados.
                {

                    stock = (int)RDR["stock"];

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

            return stock; // Regresamos la lista.
        }


    
    }
}
