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
        public int id { get; set; }
        public int idCustomer { get; set; }
        public string licensePlate { get; set; }
        public string owner { get; set; }
        public string type { get; set; }
        public string producer { get; set; }
        public string color { get; set; }
        public string registerPlace { get; set; }
        public string dateCreate { get; set; }
        public string userCreate { get; set; }
        public string dateUpdate { get; set; }
        public string userUpdate { get; set; }
        public string status { get; set; }


        public Car(int id, int idCustomer, string licensePlate, string owner, string type, string producer, string color, string registerPlace, string dateCreate, 
            string userCreate, string dateUpdate, string userUpdate, string status )
        {

        }

        public Car()
        {

        }
    }
}