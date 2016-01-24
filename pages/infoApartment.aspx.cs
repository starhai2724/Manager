using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Management;
using Manager.Models;

public partial class pages_infoApartment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Services.WebMethod]
    public static List<Bill> getInfomation_apartment(string id_Cus, string date_start, string date_end)
    {
        // return BillDAO.getInfomation_apartment(Convert.ToInt16(id_Cus),  date_start,  date_end);
        return BillDAO.getInfomation_apartment(1004, date_start, date_end);
    }
        
}