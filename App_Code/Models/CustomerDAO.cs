using System;
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
    public class CustomerDAO
    {
        public CustomerDAO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        //
        public  int addCustomer(Customer customer)
        {
            string sql = "insert into dbo.Customer(name_cus, address_cus, birthday, sex_cus, identifi_card_cus, id_Apartment, date_create, user_create, date_update, user_update, holder, status, email, sdt) values( @name_cus, @address_cus, @birthday_cus, @sex_cus, @identifi_card_cus, @id_Apartment,@date_create, @user_create,@date_update, @user_update, @holder, @status, @email, @sdt)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            //, @address_cus, , , , ,,
            //@user_create,@date_update, @user_update, , @status, @email, @sdt

            cmd.Parameters.AddWithValue("@name_cus", customer.nameCustomer);
            cmd.Parameters.AddWithValue("@address_cus", customer.addressCustomer);
            cmd.Parameters.AddWithValue("@birthday_cus", customer.birthday);
            cmd.Parameters.AddWithValue("@sex_cus", customer.sex);
            cmd.Parameters.AddWithValue("@identifi_card_cus", customer.identifiCardCustomer);
            cmd.Parameters.AddWithValue("@id_Apartment", customer.idApartment);
            cmd.Parameters.AddWithValue("@date_create", customer.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", customer.userCreate);
            cmd.Parameters.AddWithValue("@date_update", customer.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", customer.userUpdate);
            cmd.Parameters.AddWithValue("@holder", customer.holder);
            cmd.Parameters.AddWithValue("@status", customer.status);
            cmd.Parameters.AddWithValue("@email", customer.email);
            cmd.Parameters.AddWithValue("@sdt", customer.sdt);
            return GenericDataAccess.ExecuteNoneQuery(cmd);


        }
        public  List<Customer> getCustomers()
        {
            string sql = "select * from Customer";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Customer customer;
            int idCustomer;
            int idApartment;
            string nameCustomer;
            string addressCustomer;
            string birthday;
            string sex;
            string identifiCardCustomer;
            string holder;
            string status;
            string email;
            string sdt;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;

            List<Customer> lst = new List<Customer>();
            foreach (DataRow dr in dt.Rows)
            {
                idCustomer = Convert.ToInt16(dr[0]);
                nameCustomer = dr[1].ToString();
                addressCustomer = dr[2].ToString();

                sex = dr[3].ToString();
                identifiCardCustomer = dr[4].ToString();
                idApartment = Convert.ToInt16(dr[5]);
                dateCreate = dr[6].ToString();
                userCreate = dr[7].ToString();
                dateUpdate = dr[8].ToString();
                userUpdate = dr[9].ToString();
                holder = dr[10].ToString();
                status = dr[11].ToString();
                email = dr[12].ToString();
                sdt = dr[13].ToString();
                birthday = dr[14].ToString();
                customer = new Customer(idCustomer, idApartment, nameCustomer, addressCustomer, birthday, sex, identifiCardCustomer, holder, status, email, sdt, dateCreate, userCreate, dateUpdate, userUpdate);
                lst.Add(customer);
            }
            return lst;


        }


        public  List<Customer> getCustomersByHolder()
        {
            string sql = "select * from Customer ";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Customer customer;
            int idCustomer;
            int idApartment;
            string nameCustomer;
            string addressCustomer;
            string birthday;
            string sex;
            string identifiCardCustomer;
            string holder;
            string status;
            string email;
            string sdt;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;

            List<Customer> lst = new List<Customer>();
            foreach (DataRow dr in dt.Rows)
            {
                idCustomer = Convert.ToInt16(dr[0]);
                nameCustomer = dr[1].ToString();
                addressCustomer = dr[2].ToString();

                sex = dr[3].ToString();
                identifiCardCustomer = dr[4].ToString();
                idApartment = Convert.ToInt16(dr[5]);
                dateCreate = dr[6].ToString();
                userCreate = dr[7].ToString();
                dateUpdate = dr[8].ToString();
                userUpdate = dr[9].ToString();
                holder = dr[10].ToString();
                status = dr[11].ToString();
                email = dr[12].ToString();
                sdt = dr[13].ToString();
                birthday = dr[14].ToString();
                customer = new Customer(idCustomer, idApartment, nameCustomer, addressCustomer, birthday, sex, identifiCardCustomer, holder, status, email, sdt, dateCreate, userCreate, dateUpdate, userUpdate);
                lst.Add(customer);
            }
            return lst;


        }

        //type_Apartment,name_Apartment,size,priceSale,priceRent,
        //status_Apartment,date_create,user_create,date_update,user_update
        public  int updateCustomer(Customer customer)
        {
            string sql = "update Customer set name_cus=@name_cus, address_cus=@address_cus, birthday=@birth_day, sex_cus=@sex_cus, identifi_card_cus=@identifi_card_cus, id_Apartment=@id_Apartment, date_update=@date_update, user_update=@user_update, holder=@holder, status=@status, email=@email, sdt=@sdt "
+ "Where id_cus=@IDCustomer";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@name_cus", customer.nameCustomer);
            cmd.Parameters.AddWithValue("@address_cus", customer.addressCustomer);
            cmd.Parameters.AddWithValue("@birth_day", customer.birthday);
            cmd.Parameters.AddWithValue("@sex_cus", customer.sex);
            cmd.Parameters.AddWithValue("@identifi_card_cus", customer.identifiCardCustomer);
            cmd.Parameters.AddWithValue("@id_Apartment", customer.idApartment);
            cmd.Parameters.AddWithValue("@date_update", customer.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", customer.userUpdate);
            cmd.Parameters.AddWithValue("@holder", customer.holder);
            cmd.Parameters.AddWithValue("@status", customer.status);
            cmd.Parameters.AddWithValue("@email", customer.email);
            cmd.Parameters.AddWithValue("@sdt", customer.sdt);
            cmd.Parameters.AddWithValue("@IDCustomer", customer.idCustomer);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
        public  Customer getCustomer(int id)
        {
            int idCustomer;
            int idApartment;
            string nameCustomer;
            string addressCustomer;
            string birthday;
            string sex;
            string identifiCardCustomer;
            string holder;
            string status;
            string email;
            string sdt;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string sql = "select * from Customer where id_cus=@IdCustomer";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdCustomer", id);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idCustomer = Convert.ToInt16(dr[0]);
                nameCustomer = dr[1].ToString();
                addressCustomer = dr[2].ToString();

                sex = dr[3].ToString();
                identifiCardCustomer = dr[4].ToString();
                idApartment = Convert.ToInt16(dr[5]);
                dateCreate = dr[6].ToString();
                userCreate = dr[7].ToString();
                dateUpdate = dr[8].ToString();
                userUpdate = dr[9].ToString();
                holder = dr[10].ToString();
                status = dr[11].ToString();
                email = dr[12].ToString();
                sdt = dr[13].ToString();
                birthday = dr[14].ToString();

                return new Customer(idCustomer, idApartment, nameCustomer, addressCustomer, birthday, sex, identifiCardCustomer, holder, status, email, sdt, dateCreate, userCreate, dateUpdate, userUpdate);

            }
            return null;


        }

        public Customer getCustomerByIdApartment(int id)
        {
            int idCustomer;
            int idApartment;
            string nameCustomer;
            string addressCustomer;
            string birthday;
            string sex;
            string identifiCardCustomer;
            string holder;
            string status;
            string email;
            string sdt;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string sql = "select * from Customer where id_Apartment=@idApartment and holder=@Holder";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@idApartment", id);
            cmd.Parameters.AddWithValue("@Holder", "Chủ");
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idCustomer = Convert.ToInt16(dr[0]);
                nameCustomer = dr[1].ToString();
                addressCustomer = dr[2].ToString();

                sex = dr[3].ToString();
                identifiCardCustomer = dr[4].ToString();
                idApartment = Convert.ToInt16(dr[5]);
                dateCreate = dr[6].ToString();
                userCreate = dr[7].ToString();
                dateUpdate = dr[8].ToString();
                userUpdate = dr[9].ToString();
                holder = dr[10].ToString();
                status = dr[11].ToString();
                email = dr[12].ToString();
                sdt = dr[13].ToString();
                birthday = dr[14].ToString();

                return new Customer(idCustomer, idApartment, nameCustomer, addressCustomer, birthday, sex, identifiCardCustomer, holder, status, email, sdt, dateCreate, userCreate, dateUpdate, userUpdate);

            }
            return null;


        }

        public  int deleteCustomer(int id)
        {

            string sql = "Delete from Customer where id_cus= @IdCustomer";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdCustomer", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);
        }

        public int deleteCustomerByApartment(int id)
        {

            string sql = "Delete from Customer where id_cus= @IdCustomer";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdCustomer", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);
        }

        //search
        public  List<Customer> searchCustomers(string find)
        {
            string sql = "select * from Customer where (id_Apartment LIKE '" + find + "%' OR ";
            sql += "name_cus LIKE '" + find + "%' OR ";
            sql += "address_cus LIKE '" + find + "%' OR ";
            sql += "birthday LIKE '" + find + "%' OR ";
            sql += "sex_cus LIKE '" + find + "%' OR ";
            sql += "identifi_card_cus LIKE '" + find + "%' OR ";
            sql += "id_Apartment LIKE '" + find + "%' OR ";
            sql += "date_create LIKE '" + find + "%' OR ";
            sql += "user_create LIKE '" + find + "%' OR ";
            sql += "date_update LIKE '" + find + "%' OR ";
            sql += "user_update LIKE '" + find + "%' OR ";
            sql += "holder LIKE '" + find + "%' OR ";
            sql += "status LIKE '" + find + "%' OR ";
            sql += "email LIKE '" + find + "%' OR ";
            sql += "sdt LIKE '" + find + "%')";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Customer customer;
            int idCustomer;
            int idApartment;
            string nameCustomer;
            string addressCustomer;
            string birthday;
            string sex;
            string identifiCardCustomer;
            string holder;
            string status;
            string email;
            string sdt;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            List<Customer> lst = new List<Customer>();
            foreach (DataRow dr in dt.Rows)
            {
                idCustomer = Convert.ToInt16(dr[0]);
                nameCustomer = dr[1].ToString();
                addressCustomer = dr[2].ToString();
                sex = dr[3].ToString();
                identifiCardCustomer = dr[4].ToString();
                idApartment = Convert.ToInt16(dr[5]);
                dateCreate = dr[6].ToString();
                userCreate = dr[7].ToString();
                dateUpdate = dr[8].ToString();
                userUpdate = dr[9].ToString();
                holder = dr[10].ToString();
                status = dr[11].ToString();
                email = dr[12].ToString();
                sdt = dr[13].ToString();
                birthday = dr[14].ToString();
                customer = new Customer(idCustomer, idApartment, nameCustomer, addressCustomer, birthday, sex, identifiCardCustomer, holder, status, email, sdt, dateCreate, userCreate, dateUpdate, userUpdate);
                lst.Add(customer);
            }
            return lst;
        }

    }
}