<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestDB.aspx.cs" Inherits="pages_TestDB" %>


<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SQL Authentication</title>
</head>
<script type="text/javascript">
    function loadData() {
        var a = "TEST"
        alert("abc");
        alert("name" + a);
        $.ajax({

            type: "POST",
            url: "TestDB.aspx/testJson",
            data: "{'name':'" + a + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: OnSeccess,
            
            error: function (result) {
                alert("Error");
            }
        });


    }
    function OnSeccess(data) {
        var 


    }


</script>




<body>

    <form id="form1" runat="server">
        <button onclick="loadData();">TEST</button>
        <asp:Button ID="test" runat="server" OnClick="test_Click" />


        <table>
            <tr>
                <td id="t"></td>
            </tr>



        </table>




    </form>

</body>

</html>



