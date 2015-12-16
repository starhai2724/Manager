using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Price
/// </summary>
/// 

    namespace Manager.Models
{ 
public class Price
{
    public int idPrice { get; set; }
    public double priceElectric { get; set; }
    public double priceWater { get; set; }
    public double priceInternet { get; set; }
    public double priceTrash { get; set; }
    public string dateCreate { get; set; }
    public string userCreate { get; set; }
    public string dateUpdate { get; set; }
    public string userUpdate { get; set; }
    public string status { get; set; }



    public Price(int idPrice, double priceElectric, double priceWater, double priceInternet, double priceTrash, string dateCreate, string userCreate, string dateUpdate, string userUpdate, string status)
    {
        this.idPrice = idPrice;
        this.priceElectric = priceElectric;
        this.priceWater = priceWater;
        this.priceInternet = priceInternet;
        this.priceTrash = priceTrash;
        this.dateCreate = dateCreate;
        this.userCreate = userCreate;
        this.dateUpdate = dateUpdate;
        this.userUpdate = userUpdate;
        this.status = status;
    }
}
}