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
        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        Price a = new Price(0, Double.Parse(priceElectric), Double.Parse(priceWater), Double.Parse(priceInternet), Double.Parse(priceTrash),dateCreate,"","","", status);
       
        PriceDAO dao = new PriceDAO();
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
        DateTime dateTime = DateTime.Now;
        string dateUpdate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        Price a = new Price(Convert.ToInt16(idPrice),Double.Parse(priceElectric), Double.Parse(priceWater), Double.Parse(priceInternet), Double.Parse(priceTrash),"","", dateUpdate,"", status);
        PriceDAO dao = new PriceDAO();
        dao.updatePrice(a);
    }


    //search
    [System.Web.Services.WebMethod]
    public static List<Price> search(string st)
    {

        return PriceDAO.findPrices(st);


    }


}