﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Manager.Models;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

public partial class _apartment : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {



    }
    [System.Web.Services.WebMethod]
    public static void add(string name, string type, string size, string priceS, string priceR, string status)
    {
        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        Apartment a = new Apartment(0, name, type, size, Double.Parse(priceS), Double.Parse(priceR), Convert.ToInt16(status), dateCreate, "", "", "");
        ApartmentDAO.addAparment(a);

    }
    [System.Web.Services.WebMethod]
    public static void delete(string id)
    {
        ApartmentDAO.deleteApartment(Convert.ToInt16(id));
    }


    //get data
    [System.Web.Services.WebMethod]
    public static List<Apartment> getApartments()
    {
        return ApartmentDAO.getApartments();


    }



    [System.Web.Services.WebMethod]
    public static Apartment testJson(string id)
    {
        int numid = Convert.ToInt16(id);
        Apartment a = ApartmentDAO.getApartment(numid);

        return a;

    }


    //edit apartment
    [System.Web.Services.WebMethod]
    public static void editApartment(string id, string name, string type, string size, string priceS, string priceR, string status)
    {
        DateTime dateTime = DateTime.Now;
        string dateUpdate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        Apartment a = new Apartment(Convert.ToInt16(id), name, type, size, Double.Parse(priceS), Double.Parse(priceR), Convert.ToInt16(status), "", "", dateUpdate, "");
        ApartmentDAO.updateApartment(a);
    }







}




