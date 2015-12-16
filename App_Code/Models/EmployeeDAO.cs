using Manager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EmployeeDAO
/// </summary>
/// 
namespace Manager.Models
{
    public class EmployeeDAO
    {
        public EmployeeDAO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        //add employee
        public int addEmployee(Employee employee)
        {
            string sql = "insert into dbo.Employee(name_emp, salary_emp, sex_emp, office_emp, address_emp, identyfi_card_emp,date_create, user_create,date_update, user_update, status, birthday) values( @name_emp, @salary_emp, @sex_emp, @office_emp, @address_emp, @identyfi_card_emp, @date_create, @user_create, @date_update, @user_update, @status, @birthday)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
        
            cmd.Parameters.AddWithValue("@name_emp", employee.nameEmployee);
            cmd.Parameters.AddWithValue("@salary_emp", employee.salaryEmployee);
            cmd.Parameters.AddWithValue("@sex_emp", employee.sex);
            cmd.Parameters.AddWithValue("@office_emp", employee.officeEmployee);
            cmd.Parameters.AddWithValue("@address_emp", employee.address);
            cmd.Parameters.AddWithValue("@identyfi_card_emp", employee.identifiCard);
            cmd.Parameters.AddWithValue("@date_create", employee.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", employee.userCreate);
            cmd.Parameters.AddWithValue("@date_update", employee.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", employee.userUpdate);
            cmd.Parameters.AddWithValue("@status", employee.status);
            cmd.Parameters.AddWithValue("@birthday", employee.birthday);
            return GenericDataAccess.ExecuteNoneQuery(cmd);


        }
        //update Employee
        public int updateEmployee(Employee employee)
        {
            string sql = "update Employee set name_emp=@name_emp, salary_emp=@salary_emp, sex_emp=@sex_emp, office_emp=@office_emp, address_emp=@address_emp, identyfi_card_emp=@identyfi_card_emp ,date_update=@date_update, user_update=@user_update, status=@status, birthday=@birthday "
    + "Where id_emp=@IDEmployee";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DateTime birthday = DateTime.Now;

            cmd.Parameters.AddWithValue("@name_emp", employee.nameEmployee);
            cmd.Parameters.AddWithValue("@salary_emp", employee.salaryEmployee);
            cmd.Parameters.AddWithValue("@sex_emp", employee.sex);
            cmd.Parameters.AddWithValue("@office_emp", employee.officeEmployee);
            cmd.Parameters.AddWithValue("@address_emp", employee.address);
            cmd.Parameters.AddWithValue("@identyfi_card_emp", employee.identifiCard);
            
            cmd.Parameters.AddWithValue("@date_update", employee.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", employee.userUpdate);
            cmd.Parameters.AddWithValue("@status", employee.status);
            cmd.Parameters.AddWithValue("@birthday", employee.birthday);
            cmd.Parameters.AddWithValue("@IDEmployee", employee.idEmployee);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
        //delete Employee
        public int deleteEmployee(int id)
        {

            string sql = "Delete from Employee where id_emp=@IdEmployee";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdEmployee", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
        //get list employee
        public static List<Employee> getEmployees()
        {
            string sql = "select * from Employee";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Employee emp;
            int idEmployee; string nameEmployee; double salaryEmployee; string sex; string officeEmployee; string address; string identifiCard;
            string dateCreate; string userCreate; string dateUpdate; string userUpdate; string status; string birthday;
            List<Employee> lst = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                idEmployee = Convert.ToInt16(dr[0]);
                nameEmployee = dr[1] + "";
                salaryEmployee = Convert.ToDouble(dr[2]);
                sex = dr[3] + "";
                officeEmployee = dr[4] + "";
                address = dr[5] + "";
                identifiCard = dr[6] + "";
                dateCreate = dr[7] + "";
                userCreate = dr[8] + "";
                dateUpdate = dr[9] + "";
                userUpdate = dr[10] + "";
                status = dr[11] + "";
                birthday = dr[12] + "";
                emp = new Employee(idEmployee, nameEmployee, salaryEmployee, sex, officeEmployee, address, identifiCard, dateCreate, userCreate, dateUpdate, userUpdate, status, birthday);
                lst.Add(emp);
            }
            return lst;

        }
        //get employee
        public static Employee getEmployee(int id)
        {

            int idEmployee; string nameEmployee; double salaryEmployee; 
            string sex; string officeEmployee; string address; string identifiCard;
            string dateCreate; string userCreate; string dateUpdate;
            string userUpdate; string status; string birthday;
            string sql = "select * from Employee where id_emp=@IdEmployee";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdEmployee", id);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idEmployee = Convert.ToInt16(dr[0]);
                nameEmployee = dr[1] + "";
                salaryEmployee = Convert.ToDouble(dr[2]);
                sex = dr[3] + "";
                officeEmployee = dr[4] + "";
                address = dr[5] + "";
                identifiCard = dr[6] + "";
                dateCreate = dr[7] + "";
                userCreate = dr[8] + "";
                dateUpdate = dr[9] + "";
                userUpdate = dr[10] + "";
                status = dr[11] + "";
                birthday = dr[12] + "";
                return new Employee(idEmployee, nameEmployee, salaryEmployee, sex, officeEmployee, address, identifiCard, dateCreate, userCreate, dateUpdate, userUpdate, status, birthday);


            }
            return null;


        }


          // search
        public static List<Employee> findEmployees(string find)
        {
            int idEmployee; string nameEmployee; double salaryEmployee;
            string sex; string officeEmployee; string address; string identifiCard;
            string dateCreate; string userCreate; string dateUpdate;
            string userUpdate; string status; string birthday;

            List<Employee> lst = new List<Employee>();
            Employee a;
          //  , , , , ,
            //,, ,, , status, birthday
            string sql = "select * from Employee where (id_emp LIKE '" + find + "%' OR ";
            sql += "name_emp LIKE '" + find + "%' OR ";
            sql += "salary_emp LIKE '" + find + "%' OR ";
            sql += "sex_emp LIKE '" + find + "%' OR ";
            sql += "office_emp LIKE '" + find + "%' OR ";
            sql += "address_emp LIKE '" + find + "%' OR ";
            sql += "identyfi_card_emp LIKE '" + find + "%' OR ";
            sql += "date_create LIKE '" + find + "%' OR ";
            sql += "user_create LIKE '" + find + "%' OR ";
            sql += "date_update LIKE '" + find + "%' OR ";
            sql += "user_update LIKE '" + find + "%' OR ";
            sql += "status LIKE '" + find + "%' OR ";
            sql += "birthday LIKE '" + find + "%')";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                idEmployee = Convert.ToInt16(dr[0]);
                nameEmployee = dr[1] + "";
                salaryEmployee = Convert.ToDouble(dr[2]);
                sex = dr[3] + "";
                officeEmployee = dr[4] + "";
                address = dr[5] + "";
                identifiCard = dr[6] + "";
                dateCreate = dr[7] + "";
                userCreate = dr[8] + "";
                dateUpdate = dr[9] + "";
                userUpdate = dr[10] + "";
                status = dr[11] + "";
                birthday = dr[12] + "";
                a= new Employee(idEmployee, nameEmployee, salaryEmployee, sex, officeEmployee, address, identifiCard, dateCreate, userCreate, dateUpdate, userUpdate, status, birthday);
                
                lst.Add(a);
                
            }
            
            return lst;



        }
    }
}