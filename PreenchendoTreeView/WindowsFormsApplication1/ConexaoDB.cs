using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace WindowsFormsApplication1
{
    public class ConexaoDB
    {

        public SqlConnection _connection;



        public ConexaoDB()
        {
            try
            {

                string strConnectionString = ConfigurationManager.ConnectionStrings["ConexaoSQL"].ToString();

                _connection = new SqlConnection(strConnectionString);

            }

            catch (Exception ex)
            {

                throw ex;

            }

        }
                
    }
}
