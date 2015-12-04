using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Car
/// </summary>
/// 
namespace Manager.Models
{ 
    public class Car
    {
        int id { get; set; }
        int idCustomer { get; set; }
        string licensePlate { get; set; }
        string owner { get; set; }
        string type { get; set; }
        string producer { get; set; }
        string color { get; set; }
        string registerPlace { get; set; }
        string dateCreate { get; set; }
        string userCreate { get; set; }
        string dateUpdate { get; set; }
        string userUpdate { get; set; }
        string status { get; set; }




        public Car()
        {

        }
    }
}