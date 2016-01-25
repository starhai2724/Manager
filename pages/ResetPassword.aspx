<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="pages_ResetPassword" %>



<%@ Import Namespace="Manager.Models" %>


<!DOCTYPE html>

<head>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Quản lý chung cư</title>

    <!-- CSS -->
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500" />

    <!--CSS-->
    <link href="../fontend/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom Fonts -->
    <link href="../fontend/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="../fontend/dist/css/form-elements.css" rel="stylesheet" />
    <link href="../fontend/dist/css/style.css" rel="stylesheet" />

</head>
<%string rule = (string)Session["rule"];
    User_Apartment u = (User_Apartment)Session["user"];
    if (null != rule && null != u)
    {
        if (rule.Equals("2") || rule.Equals("3"))
        {


%>
<body>

    <!-- Top content -->
    <div class="top-content">

        <div class="inner-bg">
            <div class="container">
                <div class="row">
                    <div class="col-sm-8 col-sm-offset-2 text">
                        <h1><strong>Quản lý chung cư</strong>Đổi mật khẩu</h1>
                        <div class="description">
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6 col-sm-offset-3 form-box">
                        <div class="form-top">
                            <div class="form-top-left">
                                <h3>Quản lý chung cư</h3>
                                <p>Đổi mật khẩu</p>
                                <p id="error" style="color: red"></p>
                            </div>
                            <div class="form-top-right">
                                <i class="fa fa-key"></i>
                            </div>
                        </div>
                        <div class="form-bottom">

                            <div class="form-group">
                                <label class="sr-only" for="form-username">Mật khẩu cũ</label>
                                <input type="password" name="passwordold" placeholder="Mật khẩu cũ" class="form-username form-control" id="passwordold" />
                            </div>
                            <div class="form-group">
                                <label class="sr-only" for="form-password">Mật khẩu mới</label>
                                <input type="password" name="password" placeholder="Mật khẩu" class="form-password form-control" id="password" />
                            </div>
                            <div class="form-group">
                                <label class="sr-only" for="form-password">Nhập lại mật khẩu mới</label>
                                <input type="password" name="repassword" placeholder="Nhập lại mật khẩu mới" class="form-password form-control" id="repassword" />
                            </div>
                            <button type="button" class="btn" onclick="validation()">Đổi mật khẩu</button>

                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>


    <!-- Javascript -->
    <script src="../fontend/bower_components/jquery/dist/jquery.min.js"></script>
    <script src="../fontend/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

    <script src="../fontend/js/jquery.backstretch.min.js"></script>

    <script src="../js/resetPassword.js"></script>
</body>
<%    }

    }
    else
    {
         Response.Redirect("login.aspx");
    } %>
</html>

