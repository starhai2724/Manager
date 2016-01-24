using System;

using Manager.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_userCustomer : System.Web.UI.Page
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
    public static int add(string username, string password,  string rePassword, string customer, string rule)
    {
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userCreate = user.username;
        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        password = Encode.GetMd5Hash(password);
        p.Response.Write(password);
        User_Apartment a = new User_Apartment(username, password, Convert.ToInt16(customer), dateCreate, userCreate, "", "", "", 0, rule);

        return User_ApartmentDAO.addUser_Apartment(a);


    }
    [System.Web.Services.WebMethod]
    public static int delete(string username)
    {
        return dao.deleteUser_Apartment(username);

    }
    [System.Web.Services.WebMethod]
    public static int editUser(string username, string password,  string rePassword, string customer, string rule)
    {
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userUpdate = user.username;
        DateTime dateTime = DateTime.Now;
        string dateUpdate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        password = Encode.GetMd5Hash(password);
        User_Apartment a = new User_Apartment(username, password, Convert.ToInt16(customer), "", "", dateUpdate, userUpdate, "", 0, rule);
        return dao.updateCustomer(a);
    }



    [System.Web.Services.WebMethod]
    public static List<User_Apartment> search(string find)
    {
        List<User_Apartment> lst = dao.findUser(find);
        List<User_Apartment> result = new List<User_Apartment>();
        foreach (User_Apartment u in lst)
        {
            if (u.id_cus != 0)
            {
                result.Add(u);
            }
        }
        return result;

    }



}