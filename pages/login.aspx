<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="pages_login" %>



<!DOCTYPE html>

<head>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Bootstrap Login Form Template</title>

    <!-- CSS -->
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500" />

    <!--CSS-->
    <link href="../fontend/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom Fonts -->
    <link href="../fontend/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="../fontend/dist/css/form-elements.css" rel="stylesheet" />
    <link href="../fontend/dist/css/style.css" rel="stylesheet" />

</head>

<body>

    <!-- Top content -->
    <div class="top-content">

        <div class="inner-bg">
            <div class="container">
                <div class="row">
                    <div class="col-sm-8 col-sm-offset-2 text">
                        <h1><strong>Bootstrap</strong> Login Form</h1>
                        <div class="description">
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6 col-sm-offset-3 form-box">
                        <div class="form-top">
                            <div class="form-top-left">
                                <h3>Login to our site</h3>
                                <p>Enter your username and password to log on:</p>
                            </div>
                            <div class="form-top-right">
                                <i class="fa fa-key"></i>
                            </div>
                        </div>
                        <div class="form-bottom">
                            <form role="form" action="" method="post" class="login-form">
                                <div class="form-group">
                                    <label class="sr-only" for="form-username">Username</label>
                                    <input type="text" name="form-username" placeholder="Username..." class="form-username form-control" id="form-username" />
                                </div>
                                <div class="form-group">
                                    <label class="sr-only" for="form-password">Password</label>
                                    <input type="password" name="form-password" placeholder="Password..." class="form-password form-control" id="form-password" />
                                </div>
                                <button type="submit" class="btn">Sign in!</button>
                            </form>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>


    <!-- Javascript -->
    <script src="../fontend/bower_components/jquery/dist/jquery.min.js"></script>
    <script src="../fontend/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="../fontend/js/scripts.js"></script>
    <script src="assets/js/scripts.js"></script>
    <script src="../fontend/js/jquery.backstretch.min.js"></script>


</body>

</html>
