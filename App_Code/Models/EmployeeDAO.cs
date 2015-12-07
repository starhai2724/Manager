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
public class EmployeeDAO
{
    public EmployeeDAO()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //get list employee
    public static List<Employee> getEmployees()
    {
        string sql = "select * from Employee";
        SqlCommand cmd = GenericDataAccess.CreateCommand();
        cmd.CommandText = sql;
        DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
        Employee emp;
        int IdEmployee; string NameEmployee; double SalaryEmployee; int Sex; string OfficeEmployee; string Address; string IdentifiCard;
        string DateCreate; string UserCreate; string DateUpdate; string UserUpdate; string Status; string Birthday;
        List<Employee> lst = new List<Employee>();
        foreach (DataRow dr in dt.Rows)
        {
            IdEmployee = Convert.ToInt16(dr[0]);
            NameEmployee = dr[1] + "";
            SalaryEmployee = Convert.ToDouble(dr[2]);
            Sex = Convert.ToInt16(dr[3]);
            OfficeEmployee = dr[4] + "";
            Address = dr[5] + "";
            IdentifiCard = dr[6] + "";
            DateCreate = dr[7] + "";
            UserCreate = dr[8] + "";
            DateUpdate = dr[9] + "";
            UserUpdate = dr[10] + "";
            Status = dr[11] + "";
            Birthday = dr[12] + "";
            emp = new Employee(IdEmployee, NameEmployee, SalaryEmployee, Sex, OfficeEmployee, Address, IdentifiCard, DateCreate, UserCreate, DateUpdate, UserUpdate, Status, Birthday);
            lst.Add(emp);
        }
        return lst;

    }
    //get employee
    public static Employee getEmployee(int id)
    {
        
        int IdEmployee; string NameEmployee; double SalaryEmployee; int Sex; string OfficeEmployee; string Address;
        string IdentifiCard;
        string DateCreate; string UserCreate; string DateUpdate; string UserUpdate; string Status; string Birthday;
        string sql = "select * from Employee where id_emp=@Id";
        SqlCommand cmd = GenericDataAccess.CreateCommand();
        cmd.CommandText = sql;
        DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
        foreach(DataRow dr in dt.Rows)
        {
            IdEmployee = Convert.ToInt16(dr[0]);
            NameEmployee = dr[1] + "";
            SalaryEmployee = Convert.ToDouble(dr[2]);
            Sex = Convert.ToInt16(dr[3]);
            OfficeEmployee = dr[4] + "";
            Address = dr[5] + "";
            IdentifiCard = dr[6] + "";
            DateCreate = dr[7] + "";
            UserCreate = dr[8] + "";
            DateUpdate = dr[9] + "";
            UserUpdate = dr[10] + "";
            Status = dr[11] + "";
            Birthday = dr[12] + "";
            return new Employee(IdEmployee, NameEmployee, SalaryEmployee, Sex, OfficeEmployee, Address, IdentifiCard, DateCreate, UserCreate, DateUpdate, UserUpdate, Status, Birthday);


        }
        return null;


    }


}