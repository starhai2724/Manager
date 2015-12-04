using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WaterDAO
/// </summary
/// >
/// 
namespace Manager.Models
{
    public class WaterDAO
    {
        public WaterDAO()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int addWater(Water water)
        {
            string sql = "insert into dbo.Water(number_old, number_new, total_money, id_bill, date_create, user_create, date_update, user_update, status)values( @number_old, @number_new, @total_money, @id_bill, @date_create, @user_create, @date_update, @user_update, @status)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@number_old", water.numberOld);
            cmd.Parameters.AddWithValue("@number_new", water.numberNew);
            cmd.Parameters.AddWithValue("@total_money", water.totalMoney);
            cmd.Parameters.AddWithValue("@id_bill", water.idBill);
            cmd.Parameters.AddWithValue("@date_create", water.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", water.userCreate);
            cmd.Parameters.AddWithValue("@date_update", water.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", water.userUpdate);
            cmd.Parameters.AddWithValue("@status", water.status);
            return GenericDataAccess.ExecuteNoneQuery(cmd);


        }
        public static List<Water> getWaters()
        {
            string sql = "select * from Water";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Water water;
            int idWater;
            int idBill;
            int numberOld;
            int numberNew;
            double totalMoney;
            string status;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;

            List<Water> lst = new List<Water>();
            foreach (DataRow dr in dt.Rows)
            {
                idWater = Convert.ToInt16(dr[0]);
                numberOld = Convert.ToInt16(dr[1]);
                numberNew = Convert.ToInt16(dr[2]);
                totalMoney = Convert.ToDouble(dr[3]);
                idBill = Convert.ToInt16(dr[4]);
                dateCreate = dr[5].ToString();
                userCreate = dr[6].ToString();
                dateUpdate = dr[7].ToString();
                userUpdate = dr[8].ToString();
                status = dr[9].ToString();
                water = new Water(idWater, idBill, numberOld, numberNew, totalMoney, status, dateCreate, userCreate, dateUpdate, userUpdate);
                lst.Add(water);
            }
            return lst;


        }

        //type_Apartment,name_Apartment,size,priceSale,priceRent,
        //status_Apartment,date_create,user_create,date_update,user_update
        public int updateWater(Water water)
        {
            string sql = "update Water set number_old=@number_old, number_new=@number_new, total_money=@total_money, id_bill=@id_bill, date_create=@date_create, user_create=@user_create, date_update=@date_update, user_update=@user_update, status=@status "
+ "Where id_water=@IDWater";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@number_old", water.numberOld);
            cmd.Parameters.AddWithValue("@number_new", water.numberNew);
            cmd.Parameters.AddWithValue("@total_money", water.totalMoney);
            cmd.Parameters.AddWithValue("@id_bill", water.idBill);
            cmd.Parameters.AddWithValue("@date_create", water.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", water.userCreate);
            cmd.Parameters.AddWithValue("@date_update", water.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", water.userUpdate);
            cmd.Parameters.AddWithValue("@status", water.status);
            cmd.Parameters.AddWithValue("@IDWater", water.idWater);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
        public static Water getWater(int id)
        {
            int idWater;
            int idBill;
            int numberOld;
            int numberNew;
            double totalMoney;
            string status;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string sql = "select * from Water where id_water=@IdWater";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdWater", id);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idWater = Convert.ToInt16(dr[0]);
                numberOld = Convert.ToInt16(dr[1]);
                numberNew = Convert.ToInt16(dr[2]);
                totalMoney = Convert.ToDouble(dr[3]);
                idBill = Convert.ToInt16(dr[4]);
                dateCreate = dr[5].ToString();
                userCreate = dr[6].ToString();
                dateUpdate = dr[7].ToString();
                userUpdate = dr[8].ToString();
                status = dr[9].ToString();
                return new Water(idWater, idBill, numberOld, numberNew, totalMoney, status, dateCreate, userCreate, dateUpdate, userUpdate);
            }
            return null;


        }

        public int deleteWater(int id)
        {

            string sql = "Delete from Water where id_Water=@IdWater";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdWater", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }



    }
}