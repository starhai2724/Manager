using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Water
/// </summary>
/// 
namespace Manager.Models
{
    public class Water
    {
       public int idWater { get; set; }
       public int idBill { get; set; }
       public int numberOld { get; set; }
       public int numberNew { get; set; }
       public double totalMoney { get; set; }
       public string status { get; set; }
       public string dateCreate { get; set; }
       public string userCreate { get; set; }
       public string dateUpdate { get; set; }
       public string userUpdate { get; set; }

       public Water(int idWater, int idBill, int numberOld, int numberNew, double totalMoney,string status, string dateCreate, string userCreate, string dateUpdate, string userUpdate)
        {
            this.idWater = idWater;
            this.idBill = idBill;
            this.numberOld = numberOld;
            this.numberNew = numberNew;
            this.totalMoney = totalMoney;
            this.status = status;
            this.dateCreate = dateCreate;
            this.userCreate = userCreate;
            this.dateUpdate = dateUpdate;
            this.userUpdate = userUpdate;
        }

       public Water()
       {
           // TODO: Complete member initialization
       }
        
    }

}