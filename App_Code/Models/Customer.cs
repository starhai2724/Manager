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
       
        public int idCustomer { get; set; }
        public int idApartment { get; set; }
        public string nameCustomer { get; set; }
        public string addressCustomer { get; set; }
        public string birthday { get; set; }
        public string sex { get; set; }
        public string identifiCardCustomer { get; set; }
        public string holder { get; set; }
        public string status { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public string dateCreate { get; set; }
        public string userCreate { get; set; }
        public string dateUpdate { get; set; }
        public string userUpdate { get; set; }





        public Customer(int idCustomer, int idApartment, string nameCustomer, string addressCustomer, string birthday, string sex,string identifiCardCustomer, string holder, string status, string email, string sdt, string dateCreate,string userCreate, string dateUpdate, string userUpdate)
             
        {
            this.idCustomer = idCustomer;
            this.idApartment = idApartment;
            this.nameCustomer = nameCustomer;
            this.addressCustomer = addressCustomer;
            this.birthday = birthday;
            this.sex = sex;
            this.identifiCardCustomer = identifiCardCustomer;
            this.holder = holder;
            this.status = status;
            this.email = email;
            this.sdt = sdt;
            this.dateCreate = dateCreate;
            this.userCreate = userCreate;
            this.dateUpdate = dateUpdate;
            this.userUpdate = userUpdate; 

        }
    }
}