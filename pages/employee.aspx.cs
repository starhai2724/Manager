using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Manager.Models;

public partial class pages_employee : System.Web.UI.Page
{
    static User_ApartmentDAO userDAO = new User_ApartmentDAO();
    static EmployeeDAO empDAO = new EmployeeDAO();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //add
   [System.Web.Services.WebMethod]
    public static void add(string name_emp, string salary_emp, string sex_emp, string office_emp, string address_emp, string identify_card_emp, string status, string birthday_emp)
    {
        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userCreate = user.username;
        DateTime dateTime = DateTime.Now;
        string dateCreate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        salary_emp = salary_emp.Replace(",", "");
        salary_emp = salary_emp.Replace("VND", "");
        Employee a = new Employee(0, name_emp, Double.Parse(salary_emp), sex_emp, office_emp, address_emp,identify_card_emp, dateCreate, userCreate, "", "", status, birthday_emp);
       
        EmployeeDAO dao = new EmployeeDAO();
        dao.addEmployee(a);

    }
    //del
    [System.Web.Services.WebMethod]
    public static void delete(string id)
    {
        EmployeeDAO dao = new EmployeeDAO();
        int idNum = Convert.ToInt16(id);
        Employee emp = empDAO.getEmployee(idNum);
        if (null != emp)
        {
            userDAO.deleteUser_ApartmentByIdEmployee(emp.idEmployee+"");
            dao.deleteEmployee(idNum);
        }
       



      
    }


    //get data
    [System.Web.Services.WebMethod]
    public static List<Employee> getEmployees()
    {
        return empDAO.getEmployees();


    }

    //get id

    [System.Web.Services.WebMethod]
    public static Employee getEmployee(string id)
    {
        int numid = Convert.ToInt16(id);
        Employee a = empDAO.getEmployee(numid);

        return a;

    }


    //edit 
    [System.Web.Services.WebMethod]
    public static void editEmployee(string id, string name_emp, string salary_emp, string sex_emp, string office_emp, string address_emp, string identify_card_emp, string status, string birthday_emp)
    {

        Page p = new Page();
        User_Apartment user = (User_Apartment)p.Session["user"];
        string userUpdate = user.username;
        DateTime dateTime = DateTime.Now;
        string dateUpdate = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        salary_emp = salary_emp.Replace(",", "");
        salary_emp = salary_emp.Replace("VND", "");
        Employee a = new Employee(Convert.ToInt16(id), name_emp, Double.Parse(salary_emp), sex_emp, office_emp, address_emp,identify_card_emp, "", "", dateUpdate, userUpdate, status, birthday_emp);
        EmployeeDAO dao = new EmployeeDAO();
        dao.updateEmployee(a);
    }

    //search
    [System.Web.Services.WebMethod]
    public static List<Employee> search(string st)
    {
        

        return empDAO.findEmployees(st);


    }


}