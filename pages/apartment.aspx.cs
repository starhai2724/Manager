using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Manager.Models;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

public partial class _apartment : System.Web.UI.Page
{
    static BillDAO billDAO = new BillDAO();
    static ElectricDAO elecDAO = new ElectricDAO();
    static WaterDAO waterDAO = new WaterDAO();
    static CustomerDAO customerDAO = new CustomerDAO();
    static User_ApartmentDAO userDAO = new User_ApartmentDAO();

    protected void Page_Load(object sender, EventArgs e)
    {



    }
    [System.Web.Services.WebMethod]
    public static void add(string name, string type, string size, string priceS, string priceR, string status)
    {

        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        priceS = priceS.Replace(",", "");
        priceS = priceS.Replace("VND", "");
        priceR = priceR.Replace(",", "");
        priceR = priceR.Replace("VND", "");
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userCreate = user.username;
        Apartment a = new Apartment(0, name, type, size, Double.Parse(priceS), Double.Parse(priceR), status, dateCreate, userCreate, "", "");
        ApartmentDAO.addAparment(a);



    }
    [System.Web.Services.WebMethod]
    public static void delete(string id)
    {
        int numId = Convert.ToInt16(id);
        // water; electric; bill; User_apartment;  Customer; Apartment

        Bill bill = billDAO.getBillByIdApartment(numId);
        if (null != bill)
        {
            waterDAO.deleteWaterByIdBill(bill.idBill);
            elecDAO.deleteElectricByIdBill(bill.idBill);
            billDAO.deleteBillByIdApartment(numId);
        }

        Customer cus = customerDAO.getCustomerByIdApartment(numId);
        if (null != cus)
        {
            userDAO.deleteUser_ApartmentByIdCustomer(cus.idCustomer + "");
            customerDAO.deleteCustomerByApartment(numId);
        }
        ApartmentDAO.deleteApartment(numId);
    }


    //get data
    [System.Web.Services.WebMethod]
    public static List<Apartment> getApartments()
    {
        return ApartmentDAO.getApartments();


    }



    [System.Web.Services.WebMethod]
    public static Apartment getApartment(string id)
    {
        return ApartmentDAO.getApartment(Convert.ToInt16(id));
    }


    //edit apartment
    [System.Web.Services.WebMethod]
    public static void editApartment(string id, string name, string type, string size, string priceS, string priceR, string status, string userUpdate)
    {
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userEdit = user.username;
        priceS = priceS.Replace(",", "");
        priceS = priceS.Replace("VND", "");
        priceR = priceR.Replace(",", "");
        priceR = priceR.Replace("VND", "");
        DateTime dateTime = DateTime.Now;
        string dateUpdate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        Apartment a = new Apartment(Convert.ToInt16(id), name, type, size, Double.Parse(priceS), Double.Parse(priceR), status, "", "", dateUpdate, userEdit);
        ApartmentDAO.updateApartment(a);
    }

    //search
    [System.Web.Services.WebMethod]
    public static List<Apartment> search(string st)
    {

        return ApartmentDAO.findApartments(st);


    }

    //get data except status "Trong"
    [System.Web.Services.WebMethod]
    public static List<Apartment> getApartmentsExcept()
    {
        List<Apartment> lst = ApartmentDAO.getApartments();
        List<Apartment> lstApartmentByStatus = new List<Apartment>();
        if (null != lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (!lst[i].statusApartment.Equals("Trống"))
                {
                    lstApartmentByStatus.Add(lst[i]);
                }

            }
        }


        return lstApartmentByStatus;


    }



}











