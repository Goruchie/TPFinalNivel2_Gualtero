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
                data.setQuery("select Codigo, Nombre, A.Descripcion Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C Where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                data.runReader();

                while (data.Reader.Read())
                {
                    Item aux = new Item();
                    aux.Code = (string)data.Reader["Codigo"];
                    aux.Name = (string)data.Reader["Nombre"];
                    aux.Description = (string)data.Reader["Descripcion"];
                    aux.Brand = new Brand();
                    aux.Brand.Description = (string)data.Reader["Marca"];
                    aux.Category = new Category();
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
    }
}
