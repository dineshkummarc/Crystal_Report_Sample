using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

static public class Utility
{
    //public Utility()
    //{
    //}
    static public SqlConnection getConnection()
    {
        string sqlCon = ConfigurationManager.AppSettings["conStr"].ToString();
        SqlConnection Con = new SqlConnection(sqlCon);
        return Con;
    }
    static public void closeConnection(SqlConnection Con)
    {
        try
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}