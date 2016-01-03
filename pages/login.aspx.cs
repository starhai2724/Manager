using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_login : System.Web.UI.Page
{
    static User_ApartmentDAO dao = new User_ApartmentDAO();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Services.WebMethod]
    public static User_Apartment checkUsernameAndPassword(string username, string password)
    {
        User_Apartment user = dao.getUser_Apartment(username);
        if (null != user)
        {
            if (user.password.Equals(password))
            {
                Page p = new Page();
                p.Session["user"] = "OK";
                if (user.rule.Equals("Quản lý"))
                {
                    p.Session["user"] = user;
                    p.Session["rule"] = "1";
                    //p.Response.Redirect("home.aspx");
                }
                else if (user.rule.Equals("Xem thong tin căn hộ"))
                {
                    p.Session["user"] = user;
                    p.Session["rule"] = "2";
                   // p.Response.Redirect("infoApartment.aspx");
                }
                else if (user.rule.Equals("Xem thông tin nhân viên"))
                {
                    p.Session["user"] = user;
                    p.Session["rule"] = "3";
                  // p.Response.Redirect("infoEmployee.aspx");
                }

               // p.Response.Redirect("home.aspx");




                return user;

            }


        }

        return null;



    }


}