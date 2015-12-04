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
        int idElectric { get; set; }
        int idBill { get; set; }
        int numberOld { get; set; }
        int numberNew { get; set; }
        string status { get; set; }
        string dateCreate { get; set; }
        string userCreate { get; set; }
        string dateUpdate { get; set; }
        string userUpdate { get; set; }


        public Electric()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}