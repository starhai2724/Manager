using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_customers : System.Web.UI.Page
{
  static  CustomerDAO customerDAO = new CustomerDAO();
    static User_ApartmentDAO userDAO = new User_ApartmentDAO();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //load data
    [System.Web.Services.WebMethod]
    public static List<Customer> getCustomers()
    {
        return customerDAO.getCustomers();

    }
    // get customers by holder
    [System.Web.Services.WebMethod]
    public static List<Customer> getCustomersByHolder()
    {
        List<Customer> lst= customerDAO.getCustomersByHolder();
        List<Customer> lstCustomerByHolder = new List<Customer>();
        for (int i = 0; i < lst.Count; i++)
        {
            if (lst[i].holder.Equals("Chủ"))
            {
                lstCustomerByHolder.Add(lst[i]);
            }
        }

        return lstCustomerByHolder;

    }

    



//add
[System.Web.Services.WebMethod]
    public static void add(string name, string address, string identifiCard, string sex, string idApartment, string birthday, string holder, string email, string phone, string status)
    {
        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        int id = Convert.ToInt16(idApartment + "");
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userCreate = user.username;
        Customer c = new Customer(0, id, name, address, birthday, sex, identifiCard, holder, status, email, phone, dateCreate, userCreate, "", "");

        customerDAO.addCustomer(c);

    }
    //edit
    [System.Web.Services.WebMethod]
    public static void edit(string id, string name, string address, string identifiCard, string sex, string idApartment, string birthday, string holder, string email, string phone, string status)
    {
        DateTime dateTime = DateTime.Now;
        string update = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        int idA = Convert.ToInt16(idApartment + "");
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userUpdate = user.username;

        Customer c = new Customer(Convert.ToInt16(id), idA, name, address, birthday, sex, identifiCard, holder, status, email, phone, "", "", update, userUpdate);

        customerDAO.updateCustomer(c);

    }



    [System.Web.Services.WebMethod]
    public static Customer getCustomer(string idCustomer)
    {
        return customerDAO.getCustomer(Convert.ToInt16(idCustomer));

    }

    //search 
    [System.Web.Services.WebMethod]
    public static List<Customer> search(string find)
    {

        return customerDAO.searchCustomers(find);


    }
    [System.Web.Services.WebMethod]
    public static void delete(string id)
    {
        Customer cus = customerDAO.getCustomer(Convert.ToInt16(id));
        if (null != cus)
        {
            userDAO.deleteUser_ApartmentByIdCustomer(cus.idCustomer + "");
            customerDAO.deleteCustomerByApartment(cus.idCustomer);
        }

    }



}