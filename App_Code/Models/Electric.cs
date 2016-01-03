using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Electric
/// </summary>
/// 
namespace Manager.Models
{
    public class Electric
    {
        public int idElectric { get; set; }
        public int idBill { get; set; }
        public int numberOld { get; set; }
        public int numberNew { get; set; }
        public double totalMoney { get; set; }
        public string status { get; set; }
        public string dateCreate { get; set; }
        public string userCreate { get; set; }
        public string dateUpdate { get; set; }
        public string userUpdate { get; set; }


      
        public Electric(int IdElectric, int IdBill, int NumberOld, int numberNew, double totalMoney, string Status, string DateCreate, string UserCreate, string DateUpdate, string UserUpdate)
        {
            this.idElectric = IdElectric;
            this.idBill = IdBill;
            this.numberNew = numberNew;
            this.numberOld = NumberOld;
            this.status = Status;
            this.dateCreate = DateCreate;
            this.userCreate = UserCreate;
            this.dateUpdate = DateUpdate;
            this.userUpdate = UserUpdate;
        }
    }
}