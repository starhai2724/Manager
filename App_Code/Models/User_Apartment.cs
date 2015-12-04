using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User_Apartment
/// </summary>
namespace Manager.Models
{
    public class User_Apartment
    {
        string username { get; set; }
        string password { get; set; }
        int id_cus { get; set; }
        string dateCreate { get; set; }
        string userCreate { get; set; }
        string dateUpdate { get; set; }
        string userUpdate { get; set; }
        string status { get; set; }

        public User_Apartment()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}