using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

/// <summary>
/// Summary description for ThongKeDAO
/// </summary>
/// 
/// 
 namespace Manager.Models
{
public class ThongKeDAO
{
    public ThongKeDAO()
    {
      
    }
    public static string thongKe(string date_Start, string date_End)
    {

            //  DateTime start = DateTime.ParseExact("24/01/2013", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime start = DateTime.ParseExact(date_Start, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(date_End, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string result = "";
            BillDAO billDAO = new BillDAO();
            List<Bill> lst = billDAO.getBills();
            double total_paid = 0;// tổng doanh thu của những CH đã thanh toán
            double total_sale = 0; // tổng doanh thu thuê
            double total_rent = 0; // tổng doanh thu bán
            double total_electric = 0;
            double total_water = 0;
            double total_trash = 0;
            double total_internet = 0;
            foreach (Bill b in lst)
            {
                DateTime dateBill = DateTime.Parse(b.dateBill);
                if(dateBill.Date>=start.Date && dateBill.Date <= end.Date && b.status.Equals("Đã thanh toán"))
                {
                    total_paid += b.total;
                    total_electric += b.totalElectric;
                    total_water += b.totalWater;
                    total_trash += b.totalTrash;
                    total_internet += b.totalInternet;
                }
                    
                if (dateBill.Date >= start.Date && dateBill.Date <= end.Date && b.totalApartment == 0)
                    total_rent += b.total;
                if (dateBill.Date >= start.Date && dateBill.Date <= end.Date && b.totalApartment != 0)
                    total_sale += b.total;
            }
            result = total_paid + " " + total_rent + " " + total_sale + " " + total_electric + " " + total_water + " " + total_trash + " " + total_internet;
            return result;
    }
        public static List<Bill> thongKe_Bill(string date_Start, string date_End)
        {
            DateTime start = DateTime.ParseExact(date_Start, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(date_End, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            BillDAO billDAO = new BillDAO();
            List<Bill> lst = billDAO.getBills();
            List<Bill> result = new List<Bill>();
            foreach (Bill b in lst)
            {
                DateTime dateBill = DateTime.Parse(b.dateBill);
                if (dateBill.Date >= start.Date && dateBill.Date <= end.Date )
                    result.Add(b);
            }
                return result;
        }
    }
}