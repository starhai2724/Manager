using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Apartment
/// </summary>
namespace Manager.Models
     
{

    public class Apartment
    {


        public int idApartment { get; set; }
        public string nameApartment;
        public string typeApartment { get; set; }
        public string size { get; set; }
        public double priceSale { get; set; }
        public double priceRent { get; set; }
        public int statusApartment { get; set; }
        public string dateCreate { get; set; }
        public string userCreate { get; set; }
        public string dateUpdate { get; set; }
        public string userUpdate { get; set; }



        public string NameApartment
        {
            get { return nameApartment; }
            set { nameApartment = value; }
        }


        public void aba()
        {

        }



        public Apartment(int IdApartment, string NameApartment, string TypeApartment, string Size, double PriceSale,
            double PriceRent, int StatusApartment, string DateCreate, string UserCreate, string DateUpdate, string UserUpdate)
        {

            this.idApartment = IdApartment;
            this.nameApartment = NameApartment;
            this.typeApartment = TypeApartment;
            this.size = Size;
            this.priceSale = PriceSale;
            this.priceRent = PriceRent;
            this.statusApartment = StatusApartment;
            this.dateCreate = DateCreate;
            this.userCreate = UserCreate;
            this.dateUpdate = DateUpdate;
            this.userUpdate = UserUpdate;

        }

    }
}