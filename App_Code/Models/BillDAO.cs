using System;
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
            string sql = "insert into dbo.Bill(date_Bill,total_electricity,total_water,total_trash,total_internet,total,id_Apartment,id_Price,user_create,date_update,user_update,status,total_car_moto,total_service,total_another,date_create) values(@date_Bill, @total_electricity, @total_water, @total_trash, @total_internet, @total, @id_Apartment, @id_Price, @user_create, @date_update, @user_update, @status, @total_car_moto, @total_service, @total_another,@date_create)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
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
            cmd.Parameters.AddWithValue("@total_car_moto", bill.totalCarOrMoto);
            cmd.Parameters.AddWithValue("@total_service", bill.totalService);
            cmd.Parameters.AddWithValue("@total_another", bill.totalAnother); 
            cmd.Parameters.AddWithValue("@date_create", bill.dateCreate); 
            return GenericDataAccess.ExecuteNoneQuery(cmd);
            
        }
        public static List<Bill> getBills()
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
            double totalCarOrMoto;
            double totalService;
            double totalAnother;
            double total;
            string status;
            string dateBill;
            string dateCreate;
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
                totalCarOrMoto = Convert.ToDouble(dr[13]);
                totalService = Convert.ToDouble(dr[14]);
                totalAnother = Convert.ToDouble(dr[15]);
                dateCreate = dr[16].ToString();

                bill = new Bill( idBill, idApartment, idPrice, totalElectric, totalWater, totalTrash,totalInternet, totalCarOrMoto,
                    totalService, totalAnother,total,status,dateBill,dateCreate,userCreate,dateUpdate,userUpdate);
                lst.Add(bill);
            }
            return lst;
        }
        public int updateBill(Bill bill)
        {
            string sql = "update Bill set date_Bill=@date_Bill,total_electricity=@total_electricity, total_electricity = @total_electricity , total_water = @total_water, total_trash = @total_trash , total_internet = @total_internet , total = @total, id_Apartment = @id_Apartment, id_Price = @id_Price, user_create = @user_create, date_update = @date_update, status = @status, user_update = @user_update, total_car_moto = @total_car_moto , total_service = @total_service , total_another = @total_another, date_create = @date_create "
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
            cmd.Parameters.AddWithValue("@total_car_moto", bill.totalCarOrMoto);
            cmd.Parameters.AddWithValue("@total_service", bill.totalService);
            cmd.Parameters.AddWithValue("@total_another", bill.totalAnother);
            cmd.Parameters.AddWithValue("@date_create", bill.dateCreate);
            return GenericDataAccess.ExecuteNoneQuery(cmd);
        }
        public static Bill getBill(int id)
        {
            Bill bill;
            int idBill;
            int idApartment;
            int idPrice;
            double totalElectric;
            double totalWater;
            double totalTrash;
            double totalInternet;
            double totalCarOrMoto;
            double totalService;
            double totalAnother;
            double total;
            string status;
            string dateBill;
            string dateCreate;
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
                totalCarOrMoto = Convert.ToDouble(dr[13]);
                totalService = Convert.ToDouble(dr[14]);
                totalAnother = Convert.ToDouble(dr[15]);
                dateCreate = dr[16].ToString();
                return new Bill(idBill, idApartment, idPrice, totalElectric, totalWater, totalTrash, totalInternet, totalCarOrMoto, totalService, totalAnother, total, status, dateBill, dateCreate, userCreate, dateUpdate, userUpdate);
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


    }
}