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
    public class User_ApartmentDAO
    {
        public User_ApartmentDAO()
        {
            
        }
        public int addUser_Apartment(User_Apartment user_Apartment)
        {
            string sql = "insert into dbo.User_Apartment(username_Apartment, password_Apartment, id_cus,date_create, user_create,date_update, user_update, status)values( @username_Apartment, @password_Apartment, @id_cus,@date_create, @user_create,@date_update, @user_update, @status)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
           // @username_Apartment, @password_Apartment, @id_cus,@date_create, @user_create,@date_update, @user_update, @status

            cmd.Parameters.AddWithValue("@username_Apartment", user_Apartment.username);
            cmd.Parameters.AddWithValue("@password_Apartment", user_Apartment.password);
            cmd.Parameters.AddWithValue("@date_create", user_Apartment.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", user_Apartment.userCreate);
            cmd.Parameters.AddWithValue("@date_update", user_Apartment.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", user_Apartment.userUpdate);
            cmd.Parameters.AddWithValue("@status", user_Apartment.status);
            return GenericDataAccess.ExecuteNoneQuery(cmd);


        }
        public static List<User_Apartment> getUser_Apartments()
        {
            string sql = "select * from User_Apartment";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            User_Apartment user_Apartment;
            string username;
            string password;
            int id_cus;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;

        List<User_Apartment> lst = new List<User_Apartment>();
            foreach (DataRow dr in dt.Rows)
            {
                username = dr[0].ToString();
                password = dr[1].ToString();
                id_cus = Convert.ToInt16(dr[2]);
                dateCreate = dr[3].ToString();
                userCreate = dr[4].ToString();
                dateUpdate = dr[5].ToString();
                userUpdate = dr[6].ToString();
                status = dr[7].ToString();
                user_Apartment = new User_Apartment(username, password, id_cus, dateCreate, userCreate, dateUpdate, userUpdate, status);
                lst.Add(user_Apartment);
            }
            return lst;


        }
       // string sql = "insert into dbo.User_Apartment(username_Apartment, password_Apartment, id_cus,date_create, user_create,date_update, user_update, status)
       //     values( @username_Apartment, @password_Apartment, @id_cus,@date_create, @user_create,@date_update, @user_update, @status)";

        public int updateCustomer(User_Apartment user_Apartment)
        {
            string sql = "update User_Apartment set username_Apartment=@username_Apartment, password_Apartment=@password_Apartment, id_cus=@id_cus,date_create=@date_create, user_create=@user_create,date_update=@date_update, user_update=@user_update, status=@status"
+ "Where username_Apartment=@username_Apartment";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@username_Apartment", user_Apartment.username);
            cmd.Parameters.AddWithValue("@password_Apartment", user_Apartment.password);
            cmd.Parameters.AddWithValue("@date_create", user_Apartment.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", user_Apartment.userCreate);
            cmd.Parameters.AddWithValue("@date_update", user_Apartment.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", user_Apartment.userUpdate);
            cmd.Parameters.AddWithValue("@status", user_Apartment.status);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
        public static User_Apartment getUser_Apartment(string username_Apartment)
        {
            string password;
            int id_cus;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;
            string sql = "select * from User_Apartment where  username_Apartment=@username_Apartment";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@username_Apartment", username_Apartment);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                password = dr[1].ToString();
                id_cus = Convert.ToInt16(dr[2]);
                dateCreate = dr[3].ToString();
                userCreate = dr[4].ToString();
                dateUpdate = dr[5].ToString();
                userUpdate = dr[6].ToString();
                status = dr[7].ToString();
                return  new User_Apartment(username_Apartment, password, id_cus, dateCreate, userCreate, dateUpdate, userUpdate, status);
            }
            return null;


        }

        public int deleteUser_Apartment(string username_Apartment)
        {

            string sql = "Delete from User_Apartment where username_Apartment=@username_Apartment";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@username_Apartment", username_Apartment);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
    }
}