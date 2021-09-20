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
                comando.CommandText = "SELECT A.Id AS ID, A.Codigo AS Codigo, A.Nombre AS Nombre,A.Descripcion AS Descripcion,M.Id AS MarcaID , M.Descripcion AS Marca,isnull(C.Id,-1) AS IdC , isnull(C.Descripcion,'Sin Categoria') AS Categoria, ImagenUrl, Precio FROM ARTICULOS AS A LEFT JOIN MARCAS AS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id";
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
                    aux.Marca.Id = (int)lector["MarcaID"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.Id = (int)lector["IdC"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    if(!(lector["ImagenUrl"] is DBNull))
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
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria, ImagenUrl)values('" + nuevoArt.Codigo + "', '" + nuevoArt.Nombre + "', '" + nuevoArt.Descripcion + "', " + nuevoArt.Precio + ", @idMarca, @idCategoria, @ImagenUrl )");
                datos.setearParametro("@idMarca", nuevoArt.Marca.Id);
                datos.setearParametro("@idCategoria", nuevoArt.Categoria.Id);
                datos.setearParametro("@ImagenUrl", nuevoArt.ImagenUrl);
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

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarc, IdCategoria = @IdCate, ImagenUrl = @ImgUrl, Precio = @Precio WHERE Id =" + art.Id + "");

                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@IdMarc", art.Marca.Id); // trae null
                datos.setearParametro("@IdCate", art.Categoria.Id);
                datos.setearParametro("@ImgUrl", art.ImagenUrl);
                datos.setearParametro("@Precio", art.Precio);

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
        public void eliminar(Articulo elimArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Delete from ARTICULOS where id = " + elimArticulo.Id + "");
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

        public List<Articulo> buscar(string criterio, string valorBuscado)
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                try
                {
                    if (criterio == "Código")
                    {
                        comando.CommandText = "Select A.Id as ID, A.Codigo as Codigo, A.Nombre as Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, isnull(C.Descripcion,'Sin Categoria') as Categoria, ImagenUrl, Precio from ARTICULOS as A Left join MARCAS as M on A.IdMarca = M.Id Left join CATEGORIAS as C on A.IdCategoria = C.Id where A.Codigo like ('%" + valorBuscado + "%')";
                    }
                    else if (criterio == "Nombre")
                    {
                        comando.CommandText = "Select A.Id as ID, A.Codigo as Codigo, A.Nombre as Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, isnull(C.Descripcion,'Sin Categoria') as Categoria, ImagenUrl, Precio  from ARTICULOS as A Left join MARCAS as M on A.IdMarca = M.Id Left join CATEGORIAS as C on A.IdCategoria = C.Id where A.Nombre like ('%" + valorBuscado + "%')";
                    }
                    else if (criterio == "Marca")
                    {
                        comando.CommandText = "Select A.Id as ID, A.Codigo as Codigo, A.Nombre as Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, isnull(C.Descripcion,'Sin Categoria') as Categoria, ImagenUrl, Precio  from ARTICULOS as A Left join MARCAS as M on A.IdMarca = M.Id Left join CATEGORIAS as C on A.IdCategoria = C.Id where M.Descripcion like ('%" + valorBuscado + "%')";
                    }
                    else if (criterio == "Categoría")
                    {
                        comando.CommandText = "Select A.Id as ID, A.Codigo as Codigo, A.Nombre as Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, isnull(C.Descripcion,'Sin Categoria') as Categoria, ImagenUrl, Precio  from ARTICULOS as A Left join MARCAS as M on A.IdMarca = M.Id Left join CATEGORIAS as C on A.IdCategoria = C.Id where C.Descripcion like ('%" + valorBuscado + "%')";
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
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
                    if (!(lector["ImagenUrl"] is DBNull))
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

    }
}
