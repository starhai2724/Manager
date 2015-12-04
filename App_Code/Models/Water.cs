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
        int idWater { get; set; }
        int idBill { get; set; }
        int numberOld { get; set; }
        int numberNew { get; set; }
        string status { get; set; }
        string dateCreate { get; set; }
        string userCreate { get; set; }
        string dateUpdate { get; set; }
        string userUpdate { get; set; }

        public Water()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

}