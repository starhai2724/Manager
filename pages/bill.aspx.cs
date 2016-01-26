using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Manager.Models;

public partial class pages_bill : System.Web.UI.Page
{
    static PriceDAO priceDAO = new PriceDAO();
    static WaterDAO waterDAO = new WaterDAO();
    static ElectricDAO electricDAO = new ElectricDAO();
    static BillDAO billDAO = new BillDAO();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Services.WebMethod]
    public static List<Bill> getBills()
    {
        return billDAO.getBills();
    }
    [System.Web.Services.WebMethod]
    public static Bill getBill_byId(string idBill)
    {
        return billDAO.getBill(Convert.ToInt16(idBill));
    }
    [System.Web.Services.WebMethod]
    public static string getBilldetail(string idBill)
    {
        string result = billDAO.getBilldetail(idBill);

        return result;
    }

    [System.Web.Services.WebMethod]
    public static Price getTrash_internet()
    {
        return billDAO.getprice();
    }

    //
    [System.Web.Services.WebMethod]
    public static Price getPriceApply()
    {
        List<Price> lst = priceDAO.getPriceApply();
        foreach (Price p in lst)
        {
            if (p.status.Equals("Đang hoạt động"))
                return p;
        }

        return null;

    }
    [System.Web.Services.WebMethod]
    public static List<Water> getWaters()
    {

        return waterDAO.getWaters();
    }

    [System.Web.Services.WebMethod]
    public static List<Electric> getElectrics()
    {

        return electricDAO.getElectrics();
    }
    [System.Web.Services.WebMethod]
    public static void add(string idApartment, string water_new, string water_old, string electric_new, string electric_old,
           string totalWater, string totalElectric, string totalApartment, string totalTrash, string totalInternet,
             string total, string dateBill, string idPrice, string status)
    {

        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;

        Bill bill = new Bill(0, Convert.ToInt16(idApartment), Convert.ToInt16(idPrice), Convert.ToDouble(totalElectric), Convert.ToDouble(totalWater), Convert.ToDouble(totalTrash), Convert.ToDouble(totalInternet), Convert.ToDouble(totalApartment), Convert.ToDouble(total), status, dateBill, "", "", "");
        billDAO.addBill(bill);
        int id = billDAO.getId();
        if (0 != id)
        {
            Water water = new Water(0, id, Convert.ToInt16(water_old), Convert.ToInt32(water_new), Convert.ToDouble(totalWater), "", dateBill, "", "", "");
            Electric electric = new Electric(0, id, Convert.ToInt16(electric_old), Convert.ToInt16(electric_new), Convert.ToDouble(totalElectric), "", dateBill, "", "", "");
            waterDAO.addWater(water);
            electricDAO.addElectric(electric);

        }

    }

    [System.Web.Services.WebMethod]
    public static void edit(string idBill, string idApartment, string water_new, string water_old, string electric_new, string electric_old,
           string totalWater, string totalElectric, string totalApartment, string totalTrash, string totalInternet,
             string total, string dateBill, string idPrice, string status)
    {

        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        int id = Convert.ToInt16(idBill);
        Bill bill = new Bill(id, Convert.ToInt16(idApartment), Convert.ToInt16(idPrice), Convert.ToDouble(totalElectric), Convert.ToDouble(totalWater), Convert.ToDouble(totalTrash), Convert.ToDouble(totalInternet), Convert.ToDouble(totalApartment), Convert.ToDouble(total), status, dateBill, "", "", "");

        billDAO.updateBill(bill);
        if (0 != id)
        {
            Water water = new Water(0, id, Convert.ToInt16(water_old), Convert.ToInt32(water_new), Convert.ToDouble(totalWater), "", "", "", dateBill, "");
            Electric electric = new Electric(0, id, Convert.ToInt16(electric_old), Convert.ToInt16(electric_new), Convert.ToDouble(totalElectric), "", "", "", dateBill, "");
            waterDAO.updateWater(water);
            electricDAO.updateElectric(electric);

        }

    }
    [System.Web.Services.WebMethod]
    public static int deleteBill(string idBill)
    {
        int id = Convert.ToInt16(idBill);
        electricDAO.deleteElectricByIdBill(id);
        waterDAO.deleteWaterByIdBill(id);
        return billDAO.deleteBill(id);

    }
    [System.Web.Services.WebMethod]
    public static List<Bill> search(string st)
    {
        return billDAO.search(st);
    }




}