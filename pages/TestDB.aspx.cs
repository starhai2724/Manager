using Manager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
public partial class pages_TestDB : System.Web.UI.Page
{
    private String strConnString = ConfigurationManager.ConnectionStrings["ApartmentConnection"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }

    protected void test_Click(object sender, EventArgs e)
    {
        string sql = "insert into dbo.test(name) values('name')";
        SqlCommand cmd = GenericDataAccess.CreateCommand();
        cmd.CommandText="insert into dbo.test(name) values('name')";
        GenericDataAccess.ExecuteNoneQuery(cmd);

    }


    [WebMethod]
    public static string testJson(string name)
    {



        return name;


    }

}