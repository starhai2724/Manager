using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_customers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //load data
    [System.Web.Services.WebMethod]
    public static List<Customer> getCustomers()
    {
        return CustomerDAO.getCustomers();

    }
    //add
    [System.Web.Services.WebMethod]
    public static void add(string name, string address, string identifiCard, string sex, string idApartment, string birthday, string holder, string email, string phone, string status )
    {
        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        int id = Convert.ToInt16(idApartment + "");


        Customer c = new Customer(0, id, name, address, birthday, sex, identifiCard, holder, status, email, phone, dateCreate, "", "", "");

        CustomerDAO.addCustomer(c);

    }



}