using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class BrandServices
    {
        public List<Brand> list()
        {
            List<Brand> list = new List<Brand>();
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Select Id, Descripcion from MARCAS");
                data.runReader();

                while (data.Reader.Read())
                {
                    Brand aux = new Brand();
                    aux.Id = (int)data.Reader["Id"];
                    aux.Description = (string)data.Reader["Descripcion"];

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
