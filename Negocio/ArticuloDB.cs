using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace DBArticulo
{
    public class ArticuloDB
    {
        public List<Articulo> listaArticulo()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id AS ID, A.Codigo AS Codigo, A.Nombre AS Nombre,A.Descripcion AS Descripcion, M.Descripcion AS Marca, isnull(C.Descripcion,'Sin Categoria') AS Categoria, ImagenUrl, Precio FROM ARTICULOS AS A LEFT JOIN MARCAS AS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                { 
                    Articulo aux = new Articulo();
                    
                    

                    aux.Id = (int)lector["ID"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void agregar(Articulo nuevoArt)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio)values('" + nuevoArt.Codigo + "', '" + nuevoArt.Nombre + "', '"+ nuevoArt.Descripcion + "', " + nuevoArt.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }

        

    }
}
