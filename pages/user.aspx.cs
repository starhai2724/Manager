using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_user : System.Web.UI.Page
{
    static User_ApartmentDAO dao = new User_ApartmentDAO();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [System.Web.Services.WebMethod]
    public static List<User_Apartment> getUsers()
    {
        return User_ApartmentDAO.getUser_Apartments();


    }
    [System.Web.Services.WebMethod]
    public static string chekUsername(string username)
    {
        User_Apartment user = dao.getUser_Apartment(username);
        if (null != user)
        {
            return user.username;
        }
        return null;




    }
    // add 
    [System.Web.Services.WebMethod]
    public static int add(string username, string password, string customer, string rePassword, string employee, string rule)
    {
        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        User_Apartment a = new User_Apartment(username, password, Convert.ToInt16(customer), dateCreate, "Nguyen", "", "", "", Convert.ToInt16(employee), rule);

        return User_ApartmentDAO.addUser_Apartment(a);


    }
    [System.Web.Services.WebMethod]
    public static int delete(string username)
    {
        return dao.deleteUser_Apartment(username);

    }
    [System.Web.Services.WebMethod]
    public static int editUser(string username, string password, string customer, string rePassword, string employee, string rule)
    {
        DateTime dateTime = DateTime.Now;
        string dateUpdate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        User_Apartment a = new User_Apartment(username, password, Convert.ToInt16(customer), "", "", dateUpdate, "", "", Convert.ToInt16(employee), rule);
        return dao.updateCustomer(a);
    }



}