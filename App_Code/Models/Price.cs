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
    int idPrice { get; set; }
    double priceElectric { get; set; }
    double priceWater { get; set; }
    double priceInternet { get; set; }
    double priceTrash { get; set; }
    double priceManagement { get; set; }
    double priceMoto { get; set; }
    double priceCar { get; set; }
    double priceService { get; set; }
    string dateCreate { get; set; }
    string userCreate { get; set; }
    string dateUpdate { get; set; }
    string userUpdate { get; set; }
    string status { get; set; }



    public Price()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
}