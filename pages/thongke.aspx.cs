using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Manager.Models;

public partial class pages_thongke : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Services.WebMethod]
    public static string tk(string a, string b)
    {
       // string[] arrs = date_start.Split('-');
       // string start = arrs[2] +"/" + arrs[1] + "/" + arrs[0];
        //string[] arre = date_end.Split('-');
       // string end = arre[2] + "/"  + arre[1] + "/" + arre[0];

        string result = ThongKeDAO.thongKe(a, b);
            //  string[] arr = result.Split(' ');
            //   string total = arr[0];
            //   string total_rent = arr[1];
            //   string total_sale = arr[2];
            return result;
       
    }
}