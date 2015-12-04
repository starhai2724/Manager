using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Bill
/// </summary>
/// 
namespace Manager.Models
{
    public class Bill
    {
        int idBill { get; set; }
        int idApartment { get; set; }
        int idPrice { get; set; }
        double totalElectric { get; set; }
        double totalWater { get; set; }
        double totalTrash { get; set; }
        double totalInternet { get; set; }
        double totalCarOrMoto { get; set; }
        double totalService { get; set; }
        double totalAnother { get; set; }
        double total { get; set; }
        string status { get; set; }
        string dateBill { get; set; }
        string dateCreate { get; set; }
        string userCreate { get; set; }
        string dateUpdate { get; set; }
        string userUpdate { get; set; }



        public Bill()
        {
          



        }
    }
}