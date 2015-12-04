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
            string sql = "insert into dbo.Price(price_electric, price_water, price_internet, price_Trash, price_management, price_moto, price_car, date_create, user_create, date_update, user_update, status, price_service) values(@price_electric, @price_water, @price_internet, @price_Trash, @price_management, @price_moto, @price_car, @date_create, @user_create, @date_update, @user_update, @status, @price_service)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            //, @address_cus, , , , ,,
            //@user_create,@date_update, @user_update, , @status, @email, @sdt

            cmd.Parameters.AddWithValue("@price_electric", price.priceElectric);
            cmd.Parameters.AddWithValue("@price_water", price.priceWater);
            cmd.Parameters.AddWithValue("@price_internet", price.priceInternet);
            cmd.Parameters.AddWithValue("@price_Trash", price.priceTrash);
            cmd.Parameters.AddWithValue("@price_management", price.priceManagement);
            cmd.Parameters.AddWithValue("@price_moto", price.priceMoto);
            cmd.Parameters.AddWithValue("@price_car", price.priceCar);
            cmd.Parameters.AddWithValue("@date_create", price.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", price.userCreate);
            cmd.Parameters.AddWithValue("@date_update", price.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", price.userUpdate);
            cmd.Parameters.AddWithValue("@status", price.status);
            cmd.Parameters.AddWithValue("@price_service", price.priceService);
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
            double priceManagement;
            double priceMoto;
            double priceCar;
            double priceService;
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
                priceManagement = Convert.ToDouble(dr[5]);
                priceMoto = Convert.ToDouble(dr[5]);
                priceCar = Convert.ToDouble(dr[6]);
                dateCreate = dr[6].ToString();
                userCreate = dr[7].ToString();
                dateUpdate = dr[8].ToString();
                userUpdate = dr[9].ToString();
                status = dr[10].ToString();
                priceService = Convert.ToDouble(dr[11]);

                price = new Price(idPrice, priceElectric, priceWater, priceInternet, priceTrash, priceManagement, priceMoto, priceCar, priceService, dateCreate, userCreate, dateUpdate, userUpdate, status);
                lst.Add(price);
            }
            return lst;


        }

        //type_Apartment,name_Apartment,size,priceSale,priceRent,
        //status_Apartment,date_create,user_create,date_update,user_update
        public int updatePrice(Price price)
        {
            string sql = "update Price set price_electric=@price_electric, price_water=@price_water, price_internet=@price_internet, price_Trash=@price_Trash, price_management=@price_management, price_moto=@price_moto, price_car=@price_car, date_create=@date_create, user_create=@user_create, date_update=@date_update, user_update=@user_update, status=@status, price_service=@price_service "
+ "Where id_Price=@IDPrice";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@price_electric", price.priceElectric);
            cmd.Parameters.AddWithValue("@price_water", price.priceWater);
            cmd.Parameters.AddWithValue("@price_internet", price.priceInternet);
            cmd.Parameters.AddWithValue("@price_Trash", price.priceTrash);
            cmd.Parameters.AddWithValue("@price_management", price.priceManagement);
            cmd.Parameters.AddWithValue("@price_moto", price.priceMoto);
            cmd.Parameters.AddWithValue("@price_car", price.priceCar);
            cmd.Parameters.AddWithValue("@date_create", price.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", price.userCreate);
            cmd.Parameters.AddWithValue("@date_update", price.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", price.userUpdate);
            cmd.Parameters.AddWithValue("@status", price.status);
            cmd.Parameters.AddWithValue("@price_service", price.priceService);
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
            double priceManagement;
            double priceMoto;
            double priceCar;
            double priceService;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;
            string sql = "select * from Price where id_cus=@IdPrice";
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
                priceManagement = Convert.ToDouble(dr[5]);
                priceMoto = Convert.ToDouble(dr[5]);
                priceCar = Convert.ToDouble(dr[6]);
                dateCreate = dr[6].ToString();
                userCreate = dr[7].ToString();
                dateUpdate = dr[8].ToString();
                userUpdate = dr[9].ToString();
                status = dr[10].ToString();
                priceService = Convert.ToDouble(dr[11]);
                return new Price(idPrice, priceElectric, priceWater, priceInternet, priceTrash, priceManagement, priceMoto, priceCar, priceService, dateCreate, userCreate, dateUpdate, userUpdate, status);

            }
            return null;


        }

        public int deletePrice(int id)
        {

            string sql = "Delete from Price where id_cus=@IdPrice";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdPrice", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }

    }
    }
