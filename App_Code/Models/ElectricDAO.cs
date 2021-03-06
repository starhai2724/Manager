﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerDAO
/// </summary>
/// 

namespace Manager.Models
{ 
public class ElectricDAO
{
    public ElectricDAO()
    {
    }
    public int addElectric(Electric electric)
    {
        string sql = "insert into dbo.Electric(number_old, number_new, total_money, id_bill, date_create, user_create, date_update, user_update, status)values(@number_old, @number_new, @total_money, @id_bill, @date_create, @user_create, @date_update, @user_update, @status)";

        SqlCommand cmd = GenericDataAccess.CreateCommand();
        cmd.CommandText = sql;
        cmd.Parameters.AddWithValue("@number_old", electric.numberOld);
        cmd.Parameters.AddWithValue("@number_new", electric.numberNew);
        cmd.Parameters.AddWithValue("@total_money", electric.totalMoney);
        cmd.Parameters.AddWithValue("@id_bill", electric.idBill);
        cmd.Parameters.AddWithValue("@date_create", electric.dateCreate);
        cmd.Parameters.AddWithValue("@user_create", electric.userCreate);
        cmd.Parameters.AddWithValue("@date_update", electric.dateUpdate);
        cmd.Parameters.AddWithValue("@user_update", electric.userUpdate);
        cmd.Parameters.AddWithValue("@status", electric.status);
        return GenericDataAccess.ExecuteNoneQuery(cmd);


    }
    public  List<Electric> getElectrics()
    {
        string sql = "select * from Electric";
        SqlCommand cmd = GenericDataAccess.CreateCommand();
        cmd.CommandText = sql;
        DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
        Electric Electric;
        int idElectric;
        int idBill;
        int numberOld;
        int numberNew;
        double totalMoney;
        string status;
        string dateCreate;
        string userCreate;
        string dateUpdate;
        string userUpdate;

        List<Electric> lst = new List<Electric>();
        foreach (DataRow dr in dt.Rows)
        {
            idElectric = Convert.ToInt16(dr[0]);
            numberOld = Convert.ToInt16(dr[1]);
            numberNew = Convert.ToInt16(dr[2]);
            totalMoney = Convert.ToDouble(dr[3]);
            idBill = Convert.ToInt16(dr[4]);
            dateCreate = dr[5].ToString();
            userCreate = dr[6].ToString();
            dateUpdate = dr[7].ToString();
            userUpdate = dr[8].ToString();
            status = dr[9].ToString();
            Electric = new Electric(idElectric, idBill, numberOld, numberNew, totalMoney, status, dateCreate, userCreate, dateUpdate, userUpdate);
            lst.Add(Electric);
        }
        return lst;


    }

    //type_Apartment,name_Apartment,size,priceSale,priceRent,
    //status_Apartment,date_create,user_create,date_update,user_update
    public int updateElectric(Electric Electric)
    {
        string sql = "update Electric set number_old=@number_old, number_new=@number_new, total_money=@total_money, date_update=@date_update, user_update=@user_update, status=@status "
+ "Where id_bill=@id_bill";
        SqlCommand cmd = GenericDataAccess.CreateCommand();
        cmd.CommandText = sql;
        cmd.Parameters.AddWithValue("@number_old", Electric.numberOld);
        cmd.Parameters.AddWithValue("@number_new", Electric.numberNew);
        cmd.Parameters.AddWithValue("@total_money", Electric.totalMoney);
        cmd.Parameters.AddWithValue("@id_bill", Electric.idBill);
        cmd.Parameters.AddWithValue("@date_update", Electric.dateUpdate);
        cmd.Parameters.AddWithValue("@user_update", Electric.userUpdate);
        cmd.Parameters.AddWithValue("@status", Electric.status);
        return GenericDataAccess.ExecuteNoneQuery(cmd);



    }
    public static Electric getElectric(int id)
    {
        int idElectric;
        int idBill;
        int numberOld;
        int numberNew;
        double totalMoney;
        string status;
        string dateCreate;
        string userCreate;
        string dateUpdate;
        string userUpdate;
        string sql = "select * from Electric where id_Electric=@IdElectric";
        SqlCommand cmd = GenericDataAccess.CreateCommand();
        cmd.CommandText = sql;
        cmd.Parameters.AddWithValue("@IdElectric", id);
        DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
        foreach (DataRow dr in dt.Rows)
        {
            idElectric = Convert.ToInt16(dr[0]);
            numberOld = Convert.ToInt16(dr[1]);
            numberNew = Convert.ToInt16(dr[2]);
            totalMoney = Convert.ToDouble(dr[3]);
            idBill = Convert.ToInt16(dr[4]);
            dateCreate = dr[5].ToString();
            userCreate = dr[6].ToString();
            dateUpdate = dr[7].ToString();
            userUpdate = dr[8].ToString();
            status = dr[9].ToString();
            return new Electric(idElectric, idBill, numberOld, numberNew, totalMoney, status, dateCreate, userCreate, dateUpdate, userUpdate);
        }
        return null;


    }
        public static Electric getElectric_byIdBill(int idBill)
        {
            int idElectric;
            int numberOld;
            int numberNew;
            double totalMoney;
            string status;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string sql = "select * from Electric where id_bill=@IdBill";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdBill", idBill);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idElectric = Convert.ToInt16(dr[0]);
                numberOld = Convert.ToInt16(dr[1]);
                numberNew = Convert.ToInt16(dr[2]);
                totalMoney = Convert.ToDouble(dr[3]);
                idBill = Convert.ToInt16(dr[4]);
                dateCreate = dr[5].ToString();
                userCreate = dr[6].ToString();
                dateUpdate = dr[7].ToString();
                userUpdate = dr[8].ToString();
                status = dr[9].ToString();
                return new Electric(idElectric, idBill, numberOld, numberNew, totalMoney, status, dateCreate, userCreate, dateUpdate, userUpdate);
            }
            return null;


        }

        public int deleteElectric(int id)
    {

        string sql = "Delete from Electric where id_Electric=@IdElectric";

        SqlCommand cmd = GenericDataAccess.CreateCommand();
        cmd.CommandText = sql;
        cmd.Parameters.AddWithValue("@IdElectric", id);
        return GenericDataAccess.ExecuteNoneQuery(cmd);

    }

        public int deleteElectricByIdBill(int id)
        {
            string sql = "Delete from Electric where id_bill=@idBill";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@idBill", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);
        }

    }
}