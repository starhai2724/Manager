using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Manager.Models;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

public partial class pages_price : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Services.WebMethod]
    public static void add(string priceElectric, string priceWater, string priceInternet, string priceTrash, string status)
    {
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userCreate = user.username;
        priceElectric = priceElectric.Replace(",", "");
        priceElectric = priceElectric.Replace("VND", "");
        priceWater = priceWater.Replace(",", "");
        priceWater = priceWater.Replace("VND", "");
        priceInternet = priceInternet.Replace(",", "");
        priceInternet = priceInternet.Replace("VND", "");
        priceTrash = priceTrash.Replace(",", "");
        priceTrash = priceTrash.Replace("VND", "");

        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        Price a = new Price(0, Double.Parse(priceElectric), Double.Parse(priceWater), Double.Parse(priceInternet), Double.Parse(priceTrash), dateCreate, userCreate, "", "", status);

        PriceDAO dao = new PriceDAO();
        if (status.Equals("Đang hoạt động"))
        {
            List<Price> lst = PriceDAO.getPrices();
            if (null != lst)
            {
                foreach (Price price in lst)
                {
                    if (price.status.Equals("Đang hoạt động"))
                    {
                        Price priceEdit = new Price(Convert.ToInt16(price.idPrice), 0, 0, 0, 0, "", "", "", "", "Không hoạt động");
                        dao.updatePriceByStatus(priceEdit);
                    }

                }


            }
        }

        dao.addPrice(a);

    }
    [System.Web.Services.WebMethod]
    public static void delete_byId(string idPrice)
    {
        PriceDAO dao = new PriceDAO();
        dao.deletePrice(Convert.ToInt16(idPrice));
    }


    //get data
    [System.Web.Services.WebMethod]
    public static List<Price> getPrices()
    {
        return PriceDAO.getPrices();
        // return null;
    }
    [System.Web.Services.WebMethod]
    public static Price getPrice(string id)
    {
        int numid = Convert.ToInt16(id);
        Price a = PriceDAO.getPrice(numid);

        return a;
    }
    //edit price
    [System.Web.Services.WebMethod]
    public static void editPrice(string idPrice, string priceElectric, string priceWater, string priceInternet, string priceTrash, string status)
    {
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userUpdate = user.username;
        priceElectric = priceElectric.Replace(",", "");
        priceElectric = priceElectric.Replace("VND", "");
        priceWater = priceWater.Replace(",", "");
        priceWater = priceWater.Replace("VND", "");
        priceInternet = priceInternet.Replace(",", "");
        priceInternet = priceInternet.Replace("VND", "");
        priceTrash = priceTrash.Replace(",", "");
        priceTrash = priceTrash.Replace("VND", "");
        DateTime dateTime = DateTime.Now;
        string dateUpdate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        PriceDAO dao = new PriceDAO();
        Price a = new Price(Convert.ToInt16(idPrice), Double.Parse(priceElectric), Double.Parse(priceWater), Double.Parse(priceInternet), Double.Parse(priceTrash), "", "", dateUpdate, userUpdate, status);
        if (status.Equals("Đang hoạt động"))
        {
            List<Price> lst = PriceDAO.getPrices();
            if (null != lst)
            {
                foreach (Price price in lst)
                {
                    if (price.status.Equals("Đang hoạt động"))
                    {
                        Price priceEdit = new Price(Convert.ToInt16(price.idPrice), 0, 0, 0, 0, "", "", dateUpdate, userUpdate, "Không hoạt động");
                        dao.updatePriceByStatus(priceEdit);
                    }

                }


            }
        }


        dao.updatePrice(a);



    }


    //search
    [System.Web.Services.WebMethod]
    public static List<Price> search(string st)
    {

        return PriceDAO.findPrices(st);


    }


}