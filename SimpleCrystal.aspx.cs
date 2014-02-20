using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class SimpleCrystal1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportDocument rptDoc = new ReportDocument();
        dsTestCrystal ds = new dsTestCrystal();
        DataTable dt = new DataTable();
        dt.TableName = "Crystal Report Example";
        dt = getAllOrders().Tables[0];
        ds.Tables[0].Merge(dt);
        rptDoc.Load(Server.MapPath("SimpleCrystal.rpt"));
        rptDoc.SetDataSource(ds);
        CrystalReportViewer1.ReportSource = rptDoc;
    }
    public DataSet getAllOrders()
    {
        string sqlCon = ConfigurationManager.AppSettings["conStr1"].ToString();
        SqlConnection Con = new SqlConnection(sqlCon);
        SqlCommand cmd = new SqlCommand();
        DataSet ds = null;
        SqlDataAdapter adapter;
        try
        {
            Con.Open();
            cmd.CommandText = "getAllOrders";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("@UserName", bUser.UserName));
            //cmd.Parameters.Add(new SqlParameter("@Password", bUser.Password));
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
            if (Con.State != ConnectionState.Closed)
                Con.Close();
        }
        return ds;
    }
}