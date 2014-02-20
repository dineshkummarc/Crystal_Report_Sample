using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
public class DAUser
{
    BOUser bUser;
    public DAUser()
    {
    }
    public DAUser(BOUser buser) 
    {
        bUser = buser;
    }
    public DataSet SelectAll()
    {
        SqlConnection Con = Utility.getConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = null;
        SqlDataAdapter adapter;
        try
        {
            Con.Open();
            cmd.CommandText = "Users_SelectAll";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Con;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Users");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally 
        {
            cmd.Dispose();
            Utility.closeConnection(Con);
        }
        return ds;
    }

    public DataSet IsAuthenticate()
    {
        SqlConnection Con = Utility.getConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = null;
        SqlDataAdapter adapter;
        try
        {
            Con.Open();
            cmd.CommandText = "Users_IsAuthenticated";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserName", bUser.UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", bUser.Password));
            cmd.Connection = Con;
            ds = new DataSet();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Users");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally 
        {
            cmd.Dispose();
            Utility.closeConnection(Con);
        }
        return ds;
    }
}