using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
public class BOUser
{
    #region Variable declaration
    private string username;
    private string firstname;
    private string lastname;
    private string password;
    private int contactno;
    private string emailid;

    DAUser daUser;
    #endregion

    #region Constructor declaration
    public BOUser()
	{
        daUser = new DAUser(this);
    }
    #endregion

    #region Property declaration
    public string UserName
    {
        get
        {
            return this.username;
        }
        set 
        {
            this.username = value;
            if (this.username == "")
            {
                throw new Exception("Please provide user name...");
            }
        }
    }
    public string FirstName
    {
        get
        {
            return this.firstname;
        }
        set
        {
            this.firstname = value;
            if (this.firstname == "")
            {
                throw new Exception("Please provide first name...");
            }
        }
    }
    public string LastName
    {
        get
        {
            return this.lastname;
        }
        set
        {
            this.lastname = value;
            if (this.lastname == "")
            {
                throw new Exception("Please provide last name...");
            }
        }
    }
    public string Password
    {
        get
        {
            return this.password;
        }
        set
        {
            this.password = value;
            if (this.password == "")
            {
                throw new Exception("Please provide password...");
            }
        }
    }
    public int ContactNo
    {
        get
        {
            return this.contactno;
        }
        set
        {
            this.contactno = value;
            if (this.username == "")
            {
                throw new Exception("Please provide contactno...");
            }
        }
    }
    public string EMailID
    {
        get
        {
            return this.emailid;
        }
        set
        {
            this.emailid = value;
            if (this.emailid == "")
            {
                throw new Exception("Please provide emailid...");
            }
        }
    }
    #endregion

    #region Method declaration

    public DataSet SelectAll()
    {
        //DataSet ds;
        //ds = daUser.SelectAll();
        //return ds;
        return new DAUser().SelectAll();
    }
    public string IsAuthenticate()
    {
        DataSet ds;
        string message;
        ds = daUser.IsAuthenticate();
        if ((ds != null) && (ds.Tables[0] !=null) && (ds.Tables[0].Rows.Count > 0))
        {
            int is_active = Convert.ToInt16(ds.Tables["users"].Rows[0]["is_active"]);
            if (is_active == 1)
            {
                message = "Success";
            }
            else
            {
                message = "Your activation is currently under pending.";
            }
        }
        else
            message = "Incorrect username or password.";
        return message;
    }
    #endregion
}