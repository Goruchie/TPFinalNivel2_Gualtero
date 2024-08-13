using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using domain;

namespace service
{
    public class StoreServices
    {
        public List<Item> list()
        {
            List<Item> list = new List<Item>();
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("select Codigo, Nombre, A.Descripcion Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.Id, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C Where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                data.runReader();

                while (data.Reader.Read())
                {
                    Item aux = new Item();
                    aux.Id = (int)data.Reader["Id"];
                    aux.Code = (string)data.Reader["Codigo"];
                    aux.Name = (string)data.Reader["Nombre"];
                    aux.Description = (string)data.Reader["Descripcion"];
                    aux.Brand = new Brand();
                    aux.Brand.Id = (int)data.Reader["IdMarca"];
                    aux.Brand.Description = (string)data.Reader["Marca"];
                    aux.Category = new Category();
                    aux.Category.Id = (int)data.Reader["IdCategoria"];
                    aux.Category.Description = (string)data.Reader["Categoria"];
                    if (!(data.Reader["ImagenUrl"] is DBNull))
                        aux.UrlImage = (string)data.Reader["ImagenUrl"];                    
                    aux.Price = data.Reader["Precio"] != DBNull.Value ? Convert.ToInt32((decimal)data.Reader["Precio"]) : 0;

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.closeConnection();
            }
        }
        public void add(Item newone)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.setQuery("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                data.setParameter("@Codigo", newone.Code);
                data.setParameter("@Nombre", newone.Name);
                data.setParameter("@Descripcion", newone.Description);
                data.setParameter("@IdMarca", newone.Brand.Id);
                data.setParameter("@IdCategoria", newone.Category.Id);
                data.setParameter("@ImagenUrl", newone.UrlImage);
                data.setParameter("@Precio", newone.Price);

                data.runAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.closeConnection();
            }            
        }
        public void modify(Item edited)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.setQuery("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio Where id = @id");
                data.setParameter("@Codigo", edited.Code);
                data.setParameter("@Nombre", edited.Name);
                data.setParameter("@Descripcion", edited.Description);
                data.setParameter("@IdMarca", edited.Brand.Id);
                data.setParameter("@IdCategoria", edited.Category.Id);
                data.setParameter("@ImagenUrl", edited.UrlImage);
                data.setParameter("@Precio", edited.Price);
                data.setParameter("@id", edited.Id);

                data.runAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.closeConnection();
            }
        }
        public void delete(int id)
        {            
            try
            {
                DataAccess data = new DataAccess();
                data.setQuery("delete from ARTICULOS where id = @id");
                data.setParameter("@id", id);
                data.runAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }
        public List<Item> filter(string filterBy, string criteria, string search)
        {
            List<Item> list = new List<Item>();
            DataAccess data = new DataAccess();
            try
            {
                string query = "select Codigo, Nombre, A.Descripcion Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.Id, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C Where M.Id = A.IdMarca And C.Id = A.IdCategoria And ";
                if (filterBy == "Price")
                {
                    switch (criteria)
                    {
                        case "Less than":
                            query += "Precio < " + search;
                            break;
                        case "Greater than":
                            query += "Precio > " + search;
                            break;
                        default:
                            query += "Precio = " + search;
                            break;
                    }
                }

                else if (filterBy == "Code")
                {
                    switch (criteria)
                    {
                        case "Starts with":
                            query += "Codigo like '" + search + "%' ";
                            break;
                        case "Ends with":
                            query += "Codigo like '%" + search + "'";
                            break;
                        default:
                            query += "Codigo like '%" + search + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criteria)
                    {
                        case "Starts with":
                            query += "Nombre like '" + search + "%' ";
                            break;
                        case "Ends with":
                            query += "Nombre like '%" + search + "'";
                            break;
                        default:
                            query += "Nombre like '%" + search + "%'";
                            break;
                    }
                }
                
                data.setQuery(query);
                data.runReader();
                while (data.Reader.Read())
                                    {
                    Item aux = new Item();
                    aux.Id = (int)data.Reader["Id"];
                    aux.Code = (string)data.Reader["Codigo"];
                    aux.Name = (string)data.Reader["Nombre"];
                    aux.Description = (string)data.Reader["Descripcion"];
                    aux.Brand = new Brand();
                    aux.Brand.Id = (int)data.Reader["IdMarca"];
                    aux.Brand.Description = (string)data.Reader["Marca"];
                    aux.Category = new Category();
                    aux.Category.Id = (int)data.Reader["IdCategoria"];
                    aux.Category.Description = (string)data.Reader["Categoria"];
                    if (!(data.Reader["ImagenUrl"] is DBNull))
                        aux.UrlImage = (string)data.Reader["ImagenUrl"];
                    aux.Price = data.Reader["Precio"] != DBNull.Value ? Convert.ToInt32((decimal)data.Reader["Precio"]) : 0;

                    list.Add(aux);
                }
            return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
