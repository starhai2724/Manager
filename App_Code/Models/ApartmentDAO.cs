using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ApartmentDAO
/// </summary>
/// 

namespace Manager.Models
{
    public class ApartmentDAO
    {
        public ApartmentDAO()
        {




        }

        public static int addAparment(Apartment apartment)
        {
            string sql = "insert into dbo.Apartment(type_Apartment,name_Apartment,size,priceSale,priceRent,status_Apartment,date_create,user_create,date_update,user_update)values( @type_Apartment, @name_Apartment,@size, @priceSale, @priceRent, @status_Apartment, @date_create, @user_create, @date_update, @user_update)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@type_Apartment", apartment.typeApartment);
            cmd.Parameters.AddWithValue("@name_Apartment", apartment.nameApartment);
            cmd.Parameters.AddWithValue("@size", apartment.size);
            cmd.Parameters.AddWithValue("@priceSale", apartment.priceSale);
            cmd.Parameters.AddWithValue("@priceRent", apartment.priceRent);
            cmd.Parameters.AddWithValue("@status_Apartment", apartment.statusApartment);
            cmd.Parameters.AddWithValue("@date_create", apartment.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", apartment.userCreate);
            cmd.Parameters.AddWithValue("@date_update", apartment.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", apartment.userUpdate);
            return GenericDataAccess.ExecuteNoneQuery(cmd);


        }
        public static List<Apartment> getApartments()
        {
            string sql = "select * from Apartment";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Apartment apartment;
            int idApartment;
            string nameApartment;
            string typeApartment;
            string size;
            double priceSale;
            double priceRent;
            int statusApartment;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;

            List<Apartment> lst = new List<Apartment>();
            foreach (DataRow dr in dt.Rows)
            {
                idApartment = Convert.ToInt16(dr[0]);
                typeApartment = dr[1].ToString();
                nameApartment = dr[2].ToString();
                size = dr[3].ToString();
                priceSale = Convert.ToDouble(dr[4]);
                priceRent = Convert.ToDouble(dr[5]);
                statusApartment = Convert.ToInt16(dr[6]);
                dateCreate = dr[7].ToString();
                userCreate = dr[8].ToString();
                dateUpdate = dr[9].ToString();
                userUpdate = dr[10].ToString();
                apartment = new Apartment(idApartment, nameApartment, typeApartment, size, priceSale, priceRent, statusApartment, dateCreate, userCreate, dateUpdate, userUpdate);
                lst.Add(apartment);
            }
            return lst;


        }

        //type_Apartment,name_Apartment,size,priceSale,priceRent,
        //status_Apartment,date_create,user_create,date_update,user_update
        public static int updateApartment(Apartment apartment)
        {
            string sql = "update Apartment set type_Apartment=@Type_Apartment,name_Apartment=@Name_Apartment,size=@Size,priceSale=@PriceSale,priceRent=@PriceRent,status_Apartment=@Status_Apartment,date_update=@DateUpdate, user_update=@UserUpdate "
+ "Where id_Apartment=@IDApartment";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Type_Apartment", apartment.typeApartment);
            cmd.Parameters.AddWithValue("@Name_Apartment", apartment.nameApartment);
            cmd.Parameters.AddWithValue("@Size", apartment.size);
            cmd.Parameters.AddWithValue("@PriceSale", apartment.priceSale);
            cmd.Parameters.AddWithValue("@PriceRent", apartment.priceRent);
            cmd.Parameters.AddWithValue("@Status_Apartment", apartment.statusApartment);
            cmd.Parameters.AddWithValue("@DateUpdate", apartment.dateUpdate);
            cmd.Parameters.AddWithValue("@UserUpdate", apartment.userUpdate);
            cmd.Parameters.AddWithValue("@IDApartment", apartment.idApartment);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
        public static Apartment getApartment(int id)
        {
            int idApartment;
            string nameApartment;
            string typeApartment;
            string size;
            double priceSale;
            double priceRent;
            int statusApartment;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string sql = "select * from Apartment where id_Apartment=@IdApartment";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdApartment", id);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idApartment = Convert.ToInt16(dr[0]);
                typeApartment = dr[1].ToString();
                nameApartment = dr[2].ToString();
                size = dr[3].ToString();
                priceSale = Convert.ToDouble(dr[4]);
                priceRent = Convert.ToDouble(dr[5]);
                statusApartment = Convert.ToInt16(dr[6]);
                dateCreate = dr[7].ToString();
                userCreate = dr[8].ToString();
                dateUpdate = dr[9].ToString();
                userUpdate = dr[10].ToString();
                return new Apartment(idApartment, nameApartment, typeApartment, size, priceSale, priceRent, statusApartment, dateCreate, userCreate, dateUpdate, userUpdate);
            }
            return null;


        }

        public static int deleteApartment(int id)
        {

            string sql = "Delete from Apartment where id_Apartment=@IdApartment";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdApartment", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);
            


        }





    }
}
