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
        public static int addUser_Apartment(User_Apartment user_Apartment)
        {
            string sql = "insert into User_Apartment(username_Apartment, password_Apartment, id_cus, date_create, user_create, date_update, user_update, status, id_emp, [rule] ) values( @username_Apartment, @password_Apartment, @id_cus, @date_create, @user_create,@date_update, @user_update, @status, @idEmp, @rule)";

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
            cmd.Parameters.AddWithValue("@idEmp", user_Apartment.idEmp);
            cmd.Parameters.AddWithValue("@rule", user_Apartment.rule);
            cmd.Parameters.AddWithValue("@id_cus", user_Apartment.id_cus);
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
            int idEmp;
            string rule;
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
                idEmp = Convert.ToInt16(dr[8]);
                rule = dr[9].ToString();
                user_Apartment = new User_Apartment(username, password, id_cus, dateCreate, userCreate, dateUpdate, userUpdate, status,idEmp,rule);
                lst.Add(user_Apartment);
            }
            return lst;


        }
       // string sql = "insert into dbo.User_Apartment(username_Apartment, password_Apartment, id_cus,date_create, user_create,date_update, user_update, status)
       //     values( @username_Apartment, @password_Apartment, @id_cus,@date_create, @user_create,@date_update, @user_update, @status)";

        public int updateCustomer(User_Apartment user_Apartment)
        {
            string sql = "update User_Apartment set  password_Apartment=@password_Apartment, id_cus=@id_cus , date_update=@date_update, user_update=@user_update, status=@status, id_emp=@idEmp, [rule]=@rule Where username_Apartment=@username_Apartment";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@username_Apartment", user_Apartment.username);
            cmd.Parameters.AddWithValue("@password_Apartment", user_Apartment.password);
            cmd.Parameters.AddWithValue("@id_cus", user_Apartment.id_cus);
            cmd.Parameters.AddWithValue("@date_update", user_Apartment.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", user_Apartment.userUpdate);
            cmd.Parameters.AddWithValue("@status", user_Apartment.status);
            cmd.Parameters.AddWithValue("@idEmp", user_Apartment.idEmp);
            cmd.Parameters.AddWithValue("@rule", user_Apartment.rule);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
        public  User_Apartment getUser_Apartment(string username_Apartment)
        {
            string password;
            int id_cus;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;
            int idEmp;
            string rule;
            string sql = "select * from User_Apartment where  username_Apartment= @username_Apartment";
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
                idEmp = Convert.ToInt16(dr[8]);
                rule = dr[9].ToString();
                return  new User_Apartment(username_Apartment, password, id_cus, dateCreate, userCreate, dateUpdate, userUpdate, status, idEmp, rule);
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


        public int deleteUser_ApartmentByIdCustomer(string idCustomer)
        {

            string sql = "Delete from User_Apartment where id_cus=@idCus";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@idCus", idCustomer);
            return GenericDataAccess.ExecuteNoneQuery(cmd);

        }

        public int deleteUser_ApartmentByIdEmployee(string idEmployee)
        {

            string sql = "Delete from User_Apartment where id_emp=@idEmp";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@idEmp", idEmployee);
            return GenericDataAccess.ExecuteNoneQuery(cmd);

        }



        public  List<User_Apartment> findUser(string find)
        {
            string sql = "select * from User_Apartment where (username_Apartment LIKE '" + find + "%' OR ";
            sql += "id_cus LIKE '" + find + "%' OR ";
            sql += "user_create LIKE '" + find + "%' OR ";
            sql += "date_create LIKE '" + find + "%' OR ";
            sql += "date_update LIKE '" + find + "%' OR ";
            sql += "user_update LIKE '" + find + "%' OR ";
            sql += "status LIKE '" + find + "%' OR ";
            sql += "id_emp LIKE '" + find + "%' OR ";
            sql += "[rule] LIKE '" + find + "%')";
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
            int idEmp;
            string rule;
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
                idEmp = Convert.ToInt16(dr[8]);
                rule = dr[9].ToString();
                user_Apartment = new User_Apartment(username, password, id_cus, dateCreate, userCreate, dateUpdate, userUpdate, status, idEmp, rule);
                lst.Add(user_Apartment);
            }
            return lst;

        }


    }
}