﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace Manager.Models
{
    public class BillDAO
    {
        public BillDAO()
        {
        }
        public int addBill(Bill bill)
        {
            string sql = "insert into dbo.Bill(date_Bill, total_electricity, total_water, total_trash, total_internet, total_apartment, total, id_Apartment, id_Price,user_create, date_update, user_update, status) values"
                + "(@date_Bill, @total_electricity, @total_water, @total_trash, @total_internet, @total_apartment, @total, @id_Apartment, @id_Price, @user_create, @date_update, @user_update, @status)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date_Bill", bill.dateBill);
            cmd.Parameters.AddWithValue("@total_electricity", bill.totalElectric);
            cmd.Parameters.AddWithValue("@total_water", bill.totalWater);
            cmd.Parameters.AddWithValue("@total_trash", bill.totalTrash);
            cmd.Parameters.AddWithValue("@total_internet", bill.totalInternet);
            cmd.Parameters.AddWithValue("@total", bill.total);
            cmd.Parameters.AddWithValue("@id_Price", bill.idPrice);
            cmd.Parameters.AddWithValue("@user_create", bill.userCreate);
            cmd.Parameters.AddWithValue("@date_update", bill.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", bill.userUpdate);
            cmd.Parameters.AddWithValue("@status", bill.status);
            cmd.Parameters.AddWithValue("@id_Apartment", bill.idApartment);
            cmd.Parameters.AddWithValue("@total_apartment", bill.totalApartment);
            return GenericDataAccess.ExecuteNoneQuery(cmd);
            
        }
        public  List<Bill> getBills()
        {
            string sql = "select * from Bill";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Bill bill;
            int idBill;
            int idApartment;
            int idPrice;
            double totalElectric;
            double totalWater;
            double totalTrash;
            double totalInternet;
            double totalApartment;
            double total;
            string status;
            string dateBill;
            string userCreate;
            string dateUpdate;
            string userUpdate;

            List<Bill> lst = new List<Bill>();
            foreach (DataRow dr in dt.Rows)
            {
                 idBill= Convert.ToInt16(dr[0]);
                 dateBill = dr[1].ToString();
                 totalElectric = Convert.ToDouble(dr[2]);
                 totalWater = Convert.ToDouble(dr[3]);
                 totalTrash = Convert.ToDouble(dr[4]);
                 totalInternet = Convert.ToDouble(dr[5]);
                 total = Convert.ToDouble(dr[6]);
                 idApartment = Convert.ToInt16(dr[7]);
                idPrice = Convert.ToInt16(dr[8]);
                userCreate = dr[9].ToString();
                dateUpdate = dr[10].ToString();
                userUpdate = dr[11].ToString();
                status = dr[12].ToString();
                totalApartment = Convert.ToDouble(dr[13]);
                bill = new Bill( idBill, idApartment, idPrice, totalElectric, totalWater, totalTrash,totalInternet, totalApartment, total,status,dateBill,userCreate,dateUpdate,userUpdate);
                lst.Add(bill);
            }
            return lst;
        }
        public int updateBill(Bill bill)
        {
            string sql = "update Bill set date_Bill=@date_Bill,total_electricity=@total_electricity, total_electricity = @total_electricity , total_water = @total_water, total_trash = @total_trash , total_internet = @total_internet, total_apartment=@total_apartment , total = @total, id_Apartment = @id_Apartment, id_Price = @id_Price, user_create = @user_create, date_update = @date_update, status = @status, user_update = @user_update"
            + "Where id_Bill=@IdBill";
          
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdBill", bill.idBill);
            cmd.Parameters.AddWithValue("@date_Bill", bill.dateBill);
            cmd.Parameters.AddWithValue("@total_electricity", bill.totalElectric);
            cmd.Parameters.AddWithValue("@total_water", bill.totalWater);
            cmd.Parameters.AddWithValue("@total_trash", bill.totalTrash);
            cmd.Parameters.AddWithValue("@total_internet", bill.totalInternet);
            cmd.Parameters.AddWithValue("@total", bill.total);
            cmd.Parameters.AddWithValue("@id_Price", bill.userCreate);
            cmd.Parameters.AddWithValue("@date_update", bill.dateUpdate);
            cmd.Parameters.AddWithValue("@user_create", bill.userUpdate);
            cmd.Parameters.AddWithValue("@date_update", bill.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", bill.userUpdate);
            cmd.Parameters.AddWithValue("@status", bill.status);
            cmd.Parameters.AddWithValue("@total_apartment", bill.totalApartment);
            
            return GenericDataAccess.ExecuteNoneQuery(cmd);
        }
        public  Bill getBill(int id)
        {
            Bill bill;
            int idBill;
            int idApartment;
            int idPrice;
            double totalElectric;
            double totalWater;
            double totalTrash;
            double totalInternet;
            double totalApartment;
            double total;
            string status;
            string dateBill;
            string userCreate;
            string dateUpdate;
            string userUpdate;
          
            string sql = "select * from Bill  Where id_Bill=@IdBill";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdBill", id);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idBill = Convert.ToInt16(dr[0]);
                dateBill = dr[1].ToString();
                totalElectric = Convert.ToDouble(dr[2]);
                totalWater = Convert.ToDouble(dr[3]);
                totalTrash = Convert.ToDouble(dr[4]);
                totalInternet = Convert.ToDouble(dr[5]);
                total = Convert.ToDouble(dr[6]);
                idApartment = Convert.ToInt16(dr[7]);
                idPrice = Convert.ToInt16(dr[8]);
                userCreate = dr[9].ToString();
                dateUpdate = dr[10].ToString();
                userUpdate = dr[11].ToString();
                status = dr[12].ToString();
                totalApartment = Convert.ToDouble(dr[13]);
                bill = new Bill(id, idApartment, idPrice, totalElectric, totalWater, totalTrash, totalInternet, totalApartment, total, status, dateBill, userCreate, dateUpdate, userUpdate);
                return bill;
            }
            return null;
        }

        public int deleteBill(int id)
        {

            string sql = "Delete from Bill  Where id_Bill=@IdBill";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdBill", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);
            
        }
        public  string getBilldetail(string idBill)
        {
            string result = "";
            Bill bill = getBill(Convert.ToInt16(idBill));
            Apartment a = ApartmentDAO.getApartment(bill.idApartment);
            result = bill.idApartment + " " + + bill.idBill + " " + bill.idPrice + " " + bill.status + " " + bill.total + " " + bill.totalElectric +
                " "  + bill.totalInternet + " " + bill.totalTrash + " " + bill.totalWater;
            result += "," + a.priceRent + " " + a.priceSale + " " + a.statusApartment + " " + a.nameApartment;
          Water w = WaterDAO.getWater_byIdBill(bill.idBill);
          Electric e = ElectricDAO.getElectric_byIdBill(bill.idBill);
            result += "," + w.idWater + " " + w.numberNew + " " + w.numberOld + " " + w.totalMoney;
            result += "," + e.idElectric + " " + e.numberNew + " " + e.numberOld + " " + e.totalMoney;


            return result;
        }
        public  Price getprice()
       {
            //Price p = PriceDAO.getPrice_active();

           return null;
       }

        public  int getId()
        {
           
            int idBill=0;

            string sql = "select id_Bill from Bill ";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idBill = Convert.ToInt16(dr[0]);
            }
            return idBill;
        }


    }
}