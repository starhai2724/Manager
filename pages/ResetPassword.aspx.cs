using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_ResetPassword : System.Web.UI.Page
{
    static User_ApartmentDAO dao = new User_ApartmentDAO();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Services.WebMethod]
    public static string checkPassword(string passwordOld, string password)
    {
        Page p = new Page();
        User_Apartment a = (User_Apartment)p.Session["user"];
        string rule = (string)p.Session["rule"];
        string result = "";
        if (null != a)
        {
            if (a.password.Equals(Encode.GetMd5Hash(passwordOld)))

            {
                User_Apartment u = new User_Apartment(a.username, Encode.GetMd5Hash(password), 0, "", "", "", "", "", 0, "");
                dao.resetPassword(u);
                if (rule.Equals("2"))
                {
                    result = "infoApartment.aspx";
                }
                if (rule.Equals("3"))
                {
                    result = "infoEmployee.aspx";
                }

                return result;
            }
        }
        return "false";





    }



}