﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="infoApartment.aspx.cs" Inherits="pages_infoApartment" %>

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
            if (u != null && rule.Equals("2"))
            {
        %>
        <div>
            Xem thong tin can ho
        </div>
        <%}
            else
            { %>

        Ban khong co quyen!
        <%} %>
    </form>
</body>
</html>
