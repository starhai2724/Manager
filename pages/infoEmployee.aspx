<%@ Page Language="C#" AutoEventWireup="true" CodeFile="infoEmployee.aspx.cs" Inherits="pages_infoEmployee" %>

<%@ Import Namespace="Manager.Models" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <%
            string rule = (string)Session["rule"];
            User_Apartment u = (User_Apartment)Session["user"];
            if (u != null && (rule.Equals("3")))
            {
        %>
        <div>
            Xem thong tin nhan vien
        </div>
        <%}
            else
            
            { Response.Redirect("index.aspx");
                 %>

        
        <%} %>
    </form>
</body>
</html>
