using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
public partial class pages_login : System.Web.UI.Page
{
    static User_ApartmentDAO dao = new User_ApartmentDAO();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Services.WebMethod]
    public static User_Apartment checkUsernameAndPassword(string username, string password)
    {
        User_Apartment user = dao.getUser_Apartment(username);
        if (null != user)
        {
            if (user.password.Equals(Encode.GetMd5Hash(password)))
            {
                Page p = new Page();
                p.Session["user"] = "OK";
                if (user.rule.Equals("Quản lý"))
                {
                    p.Session["user"] = user;
                    p.Session["rule"] = "1";
                    //p.Response.Redirect("home.aspx");
                }
                else if (user.rule.Equals("Xem thông tin căn hộ"))
                {
                    p.Session["user"] = user;
                    p.Session["rule"] = "2";
                    // p.Response.Redirect("infoApartment.aspx");
                }
                else if (user.rule.Equals("Xem thông tin nhân viên"))
                {
                    p.Session["user"] = user;
                    p.Session["rule"] = "3";
                    // p.Response.Redirect("infoEmployee.aspx");
                }

                // p.Response.Redirect("home.aspx");




                return user;

            }


        }

        return null;



    }
    [System.Web.Services.WebMethod]
    public static string fogetPassword(string email)
    {
        Random rnd = new Random();
        int num = rnd.Next(1000,9999);
        string result = "false";
        User_ApartmentDAO userDAO = new User_ApartmentDAO();
        User_Apartment user;
        CustomerDAO cusDao = new CustomerDAO();
        List<Customer> lstCustomer = cusDao.getCustomers();
        foreach (Customer c in lstCustomer)
        {
            if (c.email.Equals(email))
            {
                user = userDAO.getUser_ApartmentByIdCustomer(Convert.ToInt16(c.idCustomer));
                if (null != user)
                {
                    userDAO.resetPassword(user.username, Encode.GetMd5Hash(num+""));
                    sendEmail(email,c.nameCustomer,num+"");
                    result = "true";
                    return result;
                }

            }
            else
            {
                result = "false";
            }


        }
        return result;
    }


    public static void sendEmail(string email,string nameCustomer,string pass)
    {

        var fromAddress = new MailAddress("hai2724@gmail.com", "Quản lý chung cư");
        var toAddress = new MailAddress(email, "To Name");
        const string fromPassword = "272404237";
        const string subject = "Quên mật khẩu";
         string body = "Cám ơn bạn bạn đã được đổi password: "+pass;
        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        };
        using (var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        })
        {
            smtp.Send(message);
        }

    }


}