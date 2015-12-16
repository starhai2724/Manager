using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Manager.Models;

public partial class pages_employee : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //add
   [System.Web.Services.WebMethod]
    public static void add(string name_emp, string salary_emp, string sex_emp, string office_emp, string address_emp, string identify_card_emp, string status, string birthday_emp)
    {
        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        Employee a = new Employee(0, name_emp, Double.Parse(salary_emp), sex_emp, office_emp, address_emp,identify_card_emp, dateCreate, "", "", "", status, birthday_emp);
       
        EmployeeDAO dao = new EmployeeDAO();
        dao.addEmployee(a);

    }
    //del
    [System.Web.Services.WebMethod]
    public static void delete(string id)
    {
        EmployeeDAO dao = new EmployeeDAO();
        dao.deleteEmployee(Convert.ToInt16(id));
    }


    //get data
    [System.Web.Services.WebMethod]
    public static List<Employee> getEmployees()
    {
        return EmployeeDAO.getEmployees();


    }

    //get id

    [System.Web.Services.WebMethod]
    public static Employee getEmployee(string id)
    {
        int numid = Convert.ToInt16(id);
        Employee a = EmployeeDAO.getEmployee(numid);

        return a;

    }


    //edit 
    [System.Web.Services.WebMethod]
    public static void editEmployee(string id, string name_emp, string salary_emp, string sex_emp, string office_emp, string address_emp, string identify_card_emp, string status, string birthday_emp)
    {
        DateTime dateTime = DateTime.Now;
        string dateUpdate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        Employee a = new Employee(Convert.ToInt16(id), name_emp, Double.Parse(salary_emp), sex_emp, office_emp, address_emp,identify_card_emp, "", "", dateUpdate, "", status, birthday_emp);
        EmployeeDAO dao = new EmployeeDAO();
        dao.updateEmployee(a);
    }

    //search
    [System.Web.Services.WebMethod]
    public static List<Employee> search(string st)
    {

        return EmployeeDAO.findEmployees(st);


    }


}