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
    public string sex { get; set; }
    public string officeEmployee { get; set; }
    public string address { get; set; }
    public string identifiCard { get; set; }
    public string dateCreate { get; set; }
    public string userCreate { get; set; }
    public string dateUpdate { get; set; }
    public string userUpdate { get; set; }
    public string status { get; set; }
    public string birthday { get; set; }

    public Employee(int idEmployee, string nameEmployee, double salaryEmployee, string sex, string officeEmployee, string address, string identifiCard,
        string dateCreate, string userCreate, string dateUpdate, string userUpdate, string status, string birthday)
    {
        this.idEmployee = idEmployee;
        this.nameEmployee = nameEmployee;
        this.salaryEmployee = salaryEmployee;
        this.sex = sex;
        this.officeEmployee = officeEmployee;
        this.address = address;
        this.identifiCard = identifiCard;
        this.dateCreate = dateCreate;
        this.userCreate = userCreate;
        this.dateUpdate = dateUpdate;
        this.userUpdate = userUpdate;
        this.status = status;
        this.birthday = birthday;

    }






    
}