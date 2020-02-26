using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MvcPlantilla
{
    public class BaseHelper
    {
        public static int ejecutarsentencia (string sentencia,
                                        CommandType tipo,
            List<SqlParameter> parametros = null)
        {

           SqlConnection cnn = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try 
	{	        
		cnn.ConnectionString = "data source=SALA3-E37\SQLEXPRESS;user id=sa;password=Express;initial catalog=CUENTAS";
                cnn.Open();
                comando.Connection = cnn;
                comando.CommandType = tipo;
                comando.CommandText = "INSERT INTO Video VALUES (idVideo,titulo,repro,url)"
	}
	catch (Exception)
	{
		
		throw;
	}

        
    }
}