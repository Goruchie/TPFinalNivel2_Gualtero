﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class DataAccess
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }
        public DataAccess()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            sqlCommand = new SqlCommand();
        }
        public void setQuery(string query)
        {
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = query;
        }
        public void runReader()
        {
            sqlCommand.Connection = connection;

            try
            {
                connection.Open();
                reader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void runAction()
        {
            sqlCommand.Connection = connection;

            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setParameter(string name, object value)
        {
            sqlCommand.Parameters.AddWithValue(name, value);
        }
        public void closeConnection()
        {
            if (reader != null)
                reader.Close();
            connection.Close();
        }
    }
}
