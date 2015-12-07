<%@ Page Language="C#" AutoEventWireup="true" CodeFile="facebookTest.aspx.cs" Inherits="Default2" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <!--#############################-->
    <!-- Facebook generated Java Script Code-->
    <script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/all.js#xfbml=1";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
    <!--End Facebook JS-->
    <!--#############################-->

    <form id="form1" runat="server">
        <div>

            <!--#############################-->
            <!--Like Button Code-->
            <div class="fb-like" data-href="http://localhost:65338/Default2.aspx" data-layout="standard" data-action="like" data-show-faces="true" data-share="true"></div>
            <!--#############################-->

            <h1>Hello C-Sharp Corner</h1>

            <!--#############################-->
            <!--Comment Box Code-->
            <div class="fb-comments" data-href="http://localhost:65338/Default2.aspx" data-numposts="5" data-colorscheme="light"></div>
            <!--#############################-->
        </div>
    </form>
</body>
</html>
