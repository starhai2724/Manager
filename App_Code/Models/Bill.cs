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
        public int idBill { get; set; }
        public int idApartment { get; set; }
        public int idPrice { get; set; }
        public double totalElectric { get; set; }
        public double totalWater { get; set; }
        public double totalTrash { get; set; }
        public double totalInternet { get; set; }
        public double totalCarOrMoto { get; set; }
        public double totalService { get; set; }
        public double totalAnother { get; set; }
        public double total { get; set; }
        public string status { get; set; }
        public string dateBill { get; set; }
        public string dateCreate { get; set; }
        public string userCreate { get; set; }
        public string dateUpdate { get; set; }
        public string userUpdate { get; set; }

        public Bill(int IdBill, int IdApartment, int IdPrice, double TotalElectric, double TotalWater,
          double TotalTrash, double TotalInternet, double TotalCarOrMoto, double TotalService, double TotalAnother,
         double Total, string Status, string DateBill, string DateCreate, string UserCreate, string DateUpdate, string UserUpdate)
        {

            this.idBill = IdBill;
            this.idApartment = IdApartment;
            this.idPrice = IdPrice;
            this.totalElectric = TotalElectric;
            this.totalWater = TotalWater;
            this.totalTrash = TotalTrash;
            this.totalInternet = TotalInternet;
            this.totalCarOrMoto = TotalCarOrMoto;
            this.totalService = TotalService;
            this.totalAnother = TotalAnother;
            this.total = Total;
            this.status = Status;
            this.dateBill = DateBill;
            this.dateCreate = DateCreate;
            this.userCreate = UserCreate;
            this.dateUpdate = DateUpdate;
            this.userUpdate = UserUpdate;

        }

        public Bill()
        {
        }

    }
}