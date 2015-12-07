using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee
{
    public int idEmployee { get; set; }
    public string nameEmployee { get; set; }
    public double salaryEmployee { get; set; }
    public int sex { get; set; }
    public string officeEmployee { get; set; }
    public string address { get; set; }
    public string identifiCard { get; set; }
    public string dateCreate { get; set; }
    public string userCreate { get; set; }
    public string dateUpdate { get; set; }
    public string userUpdate { get; set; }
    public string status { get; set; }
    public string birthday { get; set; }

    public Employee(int IdEmployee, string NameEmployee, double SalaryEmployee, int Sex, string OfficeEmployee, string Address, string IdentifiCard,
        string DateCreate, string UserCreate, string DateUpdate, string UserUpdate, string Status, string Birthday)
    {
        this.idEmployee = IdEmployee;
        this.nameEmployee = NameEmployee;
        this.salaryEmployee = SalaryEmployee;
        this.sex = Sex;
        this.officeEmployee = OfficeEmployee;
        this.address = Address;
        this.identifiCard = IdentifiCard;
        this.dateCreate = DateCreate;
        this.userCreate = UserCreate;
        this.dateUpdate = DateUpdate;
        this.userUpdate = UserUpdate;
        this.status = Status;
        this.birthday = Birthday;




    }



    
}