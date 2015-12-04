using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Services.WebMethod]
    public static User_Apartment checkUsernameAndPassword(string username, string password)
    {
        User_Apartment user = User_ApartmentDAO.getUser_Apartment(username);
        if (null != user)
        {
            if (user.password.Equals(password))
            {
                return user;

            }


        }

        return null;



    }


}