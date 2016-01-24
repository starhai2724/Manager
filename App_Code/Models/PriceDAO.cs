using Manager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PriceDAO
/// </summary>
/// 

namespace Manager.Models
{
    public class PriceDAO
    {
        public PriceDAO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        //
        public int addPrice(Price price)
        {
            string sql = "insert into dbo.Price(price_electric, price_water, price_internet, price_Trash, date_create, user_create, date_update, user_update, status) values(@price_electric, @price_water, @price_internet, @price_Trash, @date_create, @user_create, @date_update, @user_update, @status)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            //, , , @price_Trash

            cmd.Parameters.AddWithValue("@price_electric", price.priceElectric);
            cmd.Parameters.AddWithValue("@price_water", price.priceWater);
            cmd.Parameters.AddWithValue("@price_internet", price.priceInternet);
            cmd.Parameters.AddWithValue("@price_Trash", price.priceTrash);
            cmd.Parameters.AddWithValue("@date_create", price.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", price.userCreate);
            cmd.Parameters.AddWithValue("@date_update", price.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", price.userUpdate);
            cmd.Parameters.AddWithValue("@status", price.status);
            return GenericDataAccess.ExecuteNoneQuery(cmd);


        }
        public static List<Price> getPrices()
        {
            string sql = "select * from Price";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Price price;
            int idPrice;
            double priceElectric;
            double priceWater;
            double priceInternet;
            double priceTrash;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;
            List<Price> lst = new List<Price>();
            foreach (DataRow dr in dt.Rows)
            {
                idPrice = Convert.ToInt16(dr[0]);
                priceElectric = Convert.ToDouble(dr[1]);
                priceWater = Convert.ToDouble(dr[2]);
                priceInternet = Convert.ToDouble(dr[3]);
                priceTrash = Convert.ToDouble(dr[4]);
                dateCreate = dr[5].ToString();
                userCreate = dr[6].ToString();
                dateUpdate = dr[7].ToString();
                userUpdate = dr[8].ToString();
                status = dr[9].ToString();

                price = new Price(idPrice, priceElectric, priceWater, priceInternet, priceTrash, dateCreate, userCreate, dateUpdate, userUpdate, status);
                lst.Add(price);
            }
            return lst;


        }

        //type_Apartment,name_Apartment,size,priceSale,priceRent,
        //status_Apartment,date_create,user_create,date_update,user_update
        public int updatePrice(Price price)
        {
            string sql = "update Price set price_electric=@price_electric, price_water=@price_water, price_internet=@price_internet, price_Trash=@price_Trash, date_update=@date_update, user_update=@user_update, status=@status "
+ "Where id_Price=@IDPrice";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@price_electric", price.priceElectric);
            cmd.Parameters.AddWithValue("@price_water", price.priceWater);
            cmd.Parameters.AddWithValue("@price_internet", price.priceInternet);
            cmd.Parameters.AddWithValue("@price_Trash", price.priceTrash);
            cmd.Parameters.AddWithValue("@date_update", price.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", price.userUpdate);
            cmd.Parameters.AddWithValue("@status", price.status);
            cmd.Parameters.AddWithValue("@IDPrice", price.idPrice);
            return GenericDataAccess.ExecuteNoneQuery(cmd);

        }

        public int updatePriceByStatus(Price price)
        {
            string sql = "update Price set status=@status "
+ "Where id_Price=@IDPrice";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@status", price.status);
            cmd.Parameters.AddWithValue("@IDPrice", price.idPrice);
            return GenericDataAccess.ExecuteNoneQuery(cmd);

        }



        public static Price getPrice(int id)
        {
            int idPrice;
            double priceElectric;
            double priceWater;
            double priceInternet;
            double priceTrash;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;
            string sql = "select * from Price where id_Price=@IdPrice";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@IdPrice", id);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idPrice = Convert.ToInt16(dr[0]);
                priceElectric = Convert.ToDouble(dr[1]);
                priceWater = Convert.ToDouble(dr[2]);
                priceInternet = Convert.ToDouble(dr[3]);
                priceTrash = Convert.ToDouble(dr[4]);
                dateCreate = dr[5].ToString();
                userCreate = dr[6].ToString();
                dateUpdate = dr[7].ToString();
                userUpdate = dr[8].ToString();
                status = dr[9].ToString();
                return new Price(idPrice, priceElectric, priceWater, priceInternet, priceTrash, dateCreate, userCreate, dateUpdate, userUpdate, status);

            }
            return null;


        }

        public int deletePrice(int id)
        {

            string sql = "Delete from Price where id_Price=@IdPrice";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdPrice", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }


        // search
        public static List<Price> findPrices(string find)
        {
            int idPrice;
            double priceElectric;
            double priceWater;
            double priceInternet;
            double priceTrash;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;
            // price_internet, price_Trash, date_create, user_create, date_update, user_update, status
            List<Price> lst = new List<Price>();
            Price a;
            string sql = "select * from Price where (id_Price LIKE '" + find + "%' OR ";
            sql += "price_electric LIKE '" + find + "%' OR ";
            sql += "price_water LIKE '" + find + "%' OR ";
            sql += "price_internet LIKE '" + find + "%' OR ";
            sql += "price_Trash LIKE '" + find + "%' OR ";
            sql += "date_create LIKE '" + find + "%' OR ";
            sql += "user_create LIKE '" + find + "%' OR ";
            sql += "date_update LIKE '" + find + "%' OR ";
            sql += "user_update LIKE '" + find + "%' OR ";
            sql += "status LIKE '" + find + "%')";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idPrice = Convert.ToInt16(dr[0]);
                priceElectric = Convert.ToDouble(dr[1]);
                priceWater = Convert.ToDouble(dr[2]);
                priceInternet = Convert.ToDouble(dr[3]);
                priceTrash = Convert.ToDouble(dr[4]);
                dateCreate = dr[5].ToString();
                userCreate = dr[6].ToString();
                dateUpdate = dr[7].ToString();
                userUpdate = dr[8].ToString();
                status = dr[9].ToString();
                a = new Price(idPrice, priceElectric, priceWater, priceInternet, priceTrash, dateCreate, userCreate, dateUpdate, userUpdate, status);

                lst.Add(a);

            }

            return lst;



        }

        //get price status="Hoat dong"

        public List<Price> getPriceApply()
        {
            int idPrice;
            double priceElectric;
            double priceWater;
            double priceInternet;
            double priceTrash;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;
            string sql = "select * from Price";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            List<Price> lst = new List<Price>();
            foreach (DataRow dr in dt.Rows)
            {
                idPrice = Convert.ToInt16(dr[0]);
                priceElectric = Convert.ToDouble(dr[1]);
                priceWater = Convert.ToDouble(dr[2]);
                priceInternet = Convert.ToDouble(dr[3]);
                priceTrash = Convert.ToDouble(dr[4]);
                dateCreate = dr[5].ToString();
                userCreate = dr[6].ToString();
                dateUpdate = dr[7].ToString();
                userUpdate = dr[8].ToString();
                status = dr[9].ToString();
                lst.Add(new Price(idPrice, priceElectric, priceWater, priceInternet, priceTrash, dateCreate, userCreate, dateUpdate, userUpdate, status));

            }
            return lst;



        }


    }

}
