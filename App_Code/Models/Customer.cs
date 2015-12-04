using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
/// 
namespace Manager.Models
{
    public class Customer
    {
        int idCustomer { get; set; }
        int idApartment { get; set; }
        string nameCustomer { get; set; }
        string addressCustomer { get; set; }
        string birthday { get; set; }
        string sex { get; set; }
        string identifiCardCustomer { get; set; }
        string holder { get; set; }
        string status { get; set; }
        string email { get; set; }
        string sdt { get; set; }
        string dateCreate { get; set; }
        string userCreate { get; set; }
        string dateUpdate { get; set; }
        string userUpdate { get; set; }





        public Customer()
        {

        }
    }
}