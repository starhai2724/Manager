<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgetPassword.aspx.cs" Inherits="pages_forgetPassword" %>



<%@ Import Namespace="Manager.Models" %>


<!DOCTYPE html>

<head>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Quan ly chung cu</title>

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
    // User_Apartment u = (User_Apartment)Session["user"];
   // if (null != rule)
   // {
  //      if (rule.Equals("2"))
      //  {
       //     Response.Redirect("infoApartment.aspx");
       // }
//}
%>
<body>

    <!-- Top content -->
    <div class="top-content">

        <div class="inner-bg">
            <div class="container">
                <div class="row">
                    <div class="col-sm-8 col-sm-offset-2 text">
                        <h1><strong>Quản lý chung cư</strong> Login Form</h1>
                        <div class="description">
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6 col-sm-offset-3 form-box">
                        <div class="form-top">
                            <div class="form-top-left">
                                <h3>Quản lý chung cư</h3>
                                <p>Nhập email</p>
                                <p id="error" style="color: red"></p>
                            </div>
                            <div class="form-top-right">
                                <i class="fa fa-key"></i>
                            </div>
                        </div>
                        <div class="form-bottom">

                            <div class="form-group">
                                <label class="sr-only" for="form-username">Email</label>
                                <input type="text" name="email" placeholder="Email" class="form-username form-control" id="email" />
                            </div>                            
                            <button type="submit" class="btn" onclick="forgetPassword()">Đồng ý</button>
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
    <script src="../js/login.js"></script>

</body>

</html>
