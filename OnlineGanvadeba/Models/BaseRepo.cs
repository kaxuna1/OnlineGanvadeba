using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace OnlineGanvadeba.Models
{
    public class BaseRepo
    {
        public static IDbConnection OpenConnection()
        {
            IDbConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredoWebApiConn"].ConnectionString);
            connection.Open();
            return connection;
        }
        public static IDbConnection OpenConnection2()
        {
            IDbConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConsulCon"].ConnectionString);
            connection.Open();
            return connection;
        }
    }
}