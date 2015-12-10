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
        public string username { get; set; }
        public string password { get; set; }
        public int id_cus { get; set; }
        public string dateCreate { get; set; }
        public string userCreate { get; set; }
        public string dateUpdate { get; set; }
        public string userUpdate { get; set; }
        public string status { get; set; }
        public int idEmp { get; set; }
        public string rule { get; set; }
        
        public User_Apartment(string Username, string Password, int Id_cus, string DateCreate, string UserCreate, string DateUpdate, string UserUpdate, string Status, int IdEmp, string Rule)
        {
            this.username = Username;
            this.password = Password;
            this.id_cus = Id_cus;
            this.dateCreate = DateCreate;
            this.userCreate = UserCreate;
            this.dateUpdate = DateUpdate;
            this.userUpdate = UserUpdate;
            this.status = Status;
            this.rule = Rule;
            this.idEmp = IdEmp;

        }
    }
}