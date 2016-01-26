<!DOCTYPE html>
<html lang="en">
<head>
    <title>La Casa - Real Estate HTML5 Home Page Template</title>
    <meta charset="utf-8">
    <meta name="author" content="pixelhint.com">
    <meta name="description" content="La casa free real state fully responsive html5/css3 home page website template" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0" />

    <link rel="stylesheet" type="text/css" href="css/reset.css">
    <link rel="stylesheet" type="text/css" href="css/responsive.css">
        <!-- CSS -->
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500" />

    <!--CSS-->
    <link href="../fontend/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom Fonts -->
    <link href="../fontend/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="../fontend/dist/css/form-elements.css" rel="stylesheet" />
    <link href="../fontend/dist/css/style.css" rel="stylesheet" />
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/main.js"></script>
     <style>
         .posa {
             position: absolute;
         }

         .logoh {
             top: 80px;
             left: 50px;
         }

             .logoh h1 a {
                 color: #900 !important;
                 font-size: 26px;
                 font-weight: 700;
                 text-decoration: none;
                 text-shadow: 2px 0 0 #fff, -2px 0 0 #fff, 0 2px 0 #fff, 0 -2px 0 #fff, 1px 1px #fff, -1px -1px 0 #fff, 1px -1px 0 #fff, -1px 1px 0 #fff;
             }

         .sloganh {
             top: 100px;
             left: 450px;
             color: #F00 !important;
             font-size: 30px;
             font-weight: 700;
             text-decoration: none;
             text-shadow: 2px 0 0 #fff, -2px 0 0 #fff, 0 2px 0 #fff, 0 -2px 0 #fff, 1px 1px #fff, -1px -1px 0 #fff, 1px -1px 0 #fff, -1px 1px 0 #fff;
         }

         .fotterh {
             bottom: 10px;
             left: 0px;
             width: 1130px;
             text-align: center;
             color: #FFF !important;
             line-height: 160%;
         }

             .fotterh h3 {
                 padding: 0px;
                 margin: 0px;
             }

         .projectContent {
             -moz-border-bottom-colors: none;
             -moz-border-left-colors: none;
             -moz-border-right-colors: none;
             -moz-border-top-colors: none;
             border-bottom: 1px solid #dadada;
             border-image: none;
             border-left: medium none !important;
             border-right: 1px solid #dadada;
             border-top: 1px solid #dadada;
             overflow: hidden;
         }

             .projectContent .item {
                 border-left: 1px solid #dadada;
                 float: left;
                 height: 360px;
                 width: 245px;
                 padding: 10px 5px;
             }

             .projectContent .last {
                 border-right: 1px solid #dadada;
             }

             .projectContent .item .box {
                 margin: 0 auto;
                 width: 190px !important;
             }

             .projectContent .item img {
                 border: 5px solid #fff;
                 box-shadow: 1px 1px 3px 1px #ccc;
             }

             .projectContent .item .title {
                 color: #0083cb;
                 height: 60px;
                 margin: 0px 0 0;
                 overflow: hidden;
             }

             .projectContent .item a {
                 color: #000;
                 text-decoration: none;
                 font-size: 14px;
             }

             .projectContent .item .desc {
                 color: #444444;
                 height: 50px;
                 line-height: 20px;
             }

                 .projectContent .item .desc p {
                     margin: 0;
                     padding: 0;
                 }

             .projectContent .item .note {
                 margin: 20px 0;
             }
         /* =WordPress Core
-------------------------------------------------------------- */
         .alignnone {
             margin: 5px 20px 20px 0;
         }

         .aligncenter,
         div.aligncenter {
             display: block;
             margin: 5px auto 5px auto;
         }

         .alignright {
             float: right;
             margin: 5px 0 20px 20px;
         }

         .alignleft {
             float: left;
             margin: 5px 20px 20px 0;
         }

         a img.alignright {
             float: right;
             margin: 5px 0 20px 20px;
         }

         a img.alignnone {
             margin: 5px 20px 20px 0;
         }

         a img.alignleft {
             float: left;
             margin: 5px 20px 20px 0;
         }

         a img.aligncenter {
             display: block;
             margin-left: auto;
             margin-right: auto;
         }

         .wp-caption {
             background: #fff;
             border: 1px solid #f0f0f0;
             max-width: 96%; /* Image does not overflow the content area */
             padding: 5px 3px 10px;
             text-align: center;
         }

             .wp-caption.alignnone {
                 margin: 5px 20px 20px 0;
             }

             .wp-caption.alignleft {
                 margin: 5px 20px 20px 0;
             }

             .wp-caption.alignright {
                 margin: 5px 0 20px 20px;
             }

             .wp-caption img {
                 border: 0 none;
                 height: auto;
                 margin: 0;
                 max-width: 98.5%;
                 padding: 0;
                 width: auto;
             }

             .wp-caption p.wp-caption-text {
                 font-size: 11px;
                 line-height: 17px;
                 margin: 0;
                 padding: 0 4px 5px;
             }

         /* Text meant only for screen readers. */
         .screen-reader-text {
             clip: rect(1px, 1px, 1px, 1px);
             position: absolute !important;
             height: 1px;
             width: 1px;
             overflow: hidden;
         }

             .screen-reader-text:focus {
                 background-color: #f1f1f1;
                 border-radius: 3px;
                 box-shadow: 0 0 2px 2px rgba(0, 0, 0, 0.6);
                 clip: auto !important;
                 color: #21759b;
                 display: block;
                 font-size: 14px;
                 font-size: 0.875rem;
                 font-weight: bold;
                 height: auto;
                 left: 5px;
                 line-height: normal;
                 padding: 15px 23px 14px;
                 text-decoration: none;
                 top: 5px;
                 width: auto;
                 z-index: 100000; /* Above WP toolbar. */
             }
     </style>
</head>
<body>

    <section class="hero">
        <header>
            <div class="wrapper">
                <a href="#">
                    <img src="img/logo.png" class="logo" alt="" titl="" /></a>
                <a href="#" class="hamburger"></a>
                <nav>
                    <ul>
                       
                    </ul>
                    <a href="login.aspx" class="login_btn">Đăng nhập</a>
                   
                </nav>
            </div>
        </header>
        <!--  end header section  -->

        <section class="caption">
            <h2 class="caption">Find You Dream Home</h2>
            <h3 class="properties">Appartements - Houses - Mansions</h3>
        </section>
    </section>
    <!--  end hero section  -->


    
    <section class="listings" style="    margin-top: -86px;"">
        <div class="wrapper">
            <div class="row">
                 <div class="col col-sm-3 col-md-3 col-lg-3">
                      <div>
                            <div style="margin:0px;padding:0px;border-top-left-radius:8px;border-top-right-radius:8px;width:100%;height:30px;line-height:20px;background:none 0px 0px repeat scroll rgb(13,63,93)">
                              <div style="margin:0px 0px 30px;padding:5px 0px 0px;font-weight:bold;text-transform:uppercase" align="center">
                                <h3 style="margin:0px;padding:0px"><font color="#ffffff" face="arial, sans-serif" size="2">liên hệ phòng kinh doanh</font></h3>
                              </div>
                            </div>
                            <div style="margin:0px;padding:0px 0px 4px 4px;border:1px solid rgb(215,215,215)">
                              <div style="margin:0px;padding:0px">
                                <div><br>
                                </div>
                                <div></div>
                                <div>
                                  <div style="font-family:arial,sans-serif">
                                    <div>
                                      <div style="display:inline!important"><b style="color:rgb(0,85,150)"><b><b><b><b><font color="#0b5394">
                                        <div style="display:inline!important"><b><font color="#0b5394">
                                          <div style="display:inline!important"><b><font color="#0b5394">
                                            <div style="display:inline!important"><b><font color="#0b5394">
                                              <div style="display:inline;margin:5px 10px 0px 0px;float:left"><b style="color:rgb(0,85,150);text-align:center"><font color="#ff0000" size="5">
                                                <div style="text-align:left"><a href="#/home/tuvan.png?attredirects=0" imageanchor="1"><img src="img/img/tuvan.png"  border="0"></a></div>
                                                </font></b></div>
                                              </font></b></div>
                                            </font></b></div>
                                          </font></b></div>
                                        </font></b></b></b></b></b>
                                        <div style="color:rgb(0,85,150)"></div>
                                        <div style="color:rgb(0,85,150)"></div>
                                        <div style="text-align:center">
                                          <div style="display:inline!important">
                                            <div style="display:inline!important">
                                              <div style="display:inline!important"><b><b><b><b><b>
                                                <div style="display:inline!important"><b>
                                                  <div style="display:inline!important"><b>
                                                    <div style="display:inline!important"><b><font style="color:rgb(0,85,150)" color="#0b5394">&nbsp; </font><font color="#ff0000">HOTLINE 1</font></b></div>
                                                    </b></div>
                                                  </b></div>
                                                </b></b></b></b></b></div>
                                            </div>
                                          </div>
                                        </div>
                                        <font style="color:rgb(0,85,150)" color="#444444">
                                        <div style="text-align:center">
                                          <div style="font-size:13px;display:inline!important"><b><b>&nbsp;&nbsp;</b></b></div>
                                          <font size="6">&nbsp;</font><b><font color="#ff0000" size="5">0904 86 88 77</font></b></div>
                                        </font></div>
                                    </div>
                                  </div>
                                </div>
                              </div>
                            </div>
                          </div>

                          <div><br>
                          </div>
                          <div>
                            <div style="margin:0px;padding:0px;border-top-left-radius:8px;border-top-right-radius:8px;width:100%;height:30px;line-height:20px;background:none 0px 0px repeat scroll rgb(13,63,93)">
                              <div style="margin:0px 0px 30px;padding:5px 0px 0px;font-weight:bold;text-transform:uppercase" align="center">
                                <h3 style="margin:0px;padding:0px"><font color="#ffffff" face="arial, sans-serif" size="2">contact business offical</font></h3>
                              </div>
                            </div>
                            <div style="margin:0px;padding:0px 0px 4px 4px;border:1px solid rgb(215,215,215)">
                              <div style="margin:0px;padding:0px">
                                <div><br>
                                </div>
                                <div></div>
                                <div>
                                  <div>
                                    <div>
                                      <div style="display:inline!important"><b style="font-family:arial,sans-serif;color:rgb(0,85,150)"><b><b><b><b><font color="#0b5394">
                                        <div style="display:inline!important"><b><font color="#0b5394">
                                          <div style="display:inline!important"><b><font color="#0b5394">
                                            <div style="display:inline!important"><b><font color="#0b5394">
                                              <div style="display:inline;margin:5px 10px 0px 0px;float:left"><b style="color:rgb(0,85,150);text-align:center"><font color="#ff0000" size="5">
                                                <div style="text-align:left"><a href="#/home/tu%20van%20vinhomes%202.png?attredirects=0" imageanchor="1" style="font-family:Arial,Verdana,sans-serif;font-size:13px;font-weight:normal"><img src="img/img/tu van vinhomes 2.png"  border="0"></a></div>
                                                </font></b></div>
                                              </font></b></div>
                                            </font></b></div>
                                          </font></b></div>
                                        </font></b></b></b></b></b>
                                        <div style="font-family:arial,sans-serif;color:rgb(0,85,150)"></div>
                                        <div style="font-family:arial,sans-serif;color:rgb(0,85,150)"></div>
                                        <div style="font-family:arial,sans-serif;text-align:center">
                                          <div style="display:inline!important">
                                            <div style="display:inline!important">
                                              <div style="display:inline!important"><b><b><b><b><b>
                                                <div style="display:inline!important"><b>
                                                  <div style="display:inline!important"><b>
                                                    <div style="display:inline!important"><b><font color="#ff0000">HOTLINE 2 (For English Contact)</font></b></div>
                                                    </b></div>
                                                  </b></div>
                                                </b></b></b></b></b></div>
                                            </div>
                                          </div>
                                        </div>
                                        <font>
                                        <div style="color:rgb(0,85,150);font-family:arial,sans-serif;text-align:center"><b><font color="#ff0000" size="5">(+84)&nbsp;</font></b></div>
                                        <div style="color:rgb(0,85,150);font-family:arial,sans-serif;text-align:center"><b style="color:rgb(255,0,0);font-size:x-large">0919 26 79 26</b></div>
                                        </font></div>
                                    </div>
                                  </div>
                                </div>
                              </div>
                            </div>
                          </div>

                            <div xmlns="http://www.w3.org/1999/xhtml" id="COMP_031448606168851256" class="sites-embed" role="complementary">
                      <h4 class="sites-embed-title"></h4>
                      <div class="sites-embed-content sites-embed-content-sidebar-textbox">
                       <div dir="ltr">
                          <div style="margin:0px;padding:0px;border-top-left-radius:8px;border-top-right-radius:8px;width:100%;height:30px;line-height:20px;background:none 0px 0px repeat scroll rgb(13,63,93)">
                            <div style="margin:0px 0px 30px;padding:5px 0px 0px;font-weight:bold;text-transform:uppercase" align="center">
                              <h3 style="margin:0px;padding:0px"><font color="#ffffff" face="arial, sans-serif" size="2">KÍCH THƯỚC CĂN HỘ</font></h3>
                            </div>
                          </div>
                          <div style="margin:0px;padding:0px 0px 4px;border:1px solid rgb(215,215,215)">
                            <div style="margin:0px;padding:0px">
                              <ul style="margin:0px;padding:0px">
                                <li style="font-family:Tahoma;line-height:18px;font-size:12px;margin:0px;padding:5px 7px 2px 2px;list-style-type:none;background-image:url();background-repeat:no-repeat"></li>
                                
                                        
                                
                                
                                <li style="font-family:Tahoma;line-height:18px;text-align:left;padding:0px;margin:0px;list-style:none;border-bottom-width:1px;border-bottom-color:rgb(204,204,204);border-bottom-style:dashed;width:100%;background-image:url()"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="font-weight:bold;color:rgb(51,51,51);font-size:13px;line-height:28px">&nbsp;</span></font>
                                  <div style="display:inline!important">
                                    <div style="display:inline!important">
                                      <div style="display:inline!important"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none">
                                        <div style="display:inline!important">
                                          <div style="text-align:center;display:inline!important"><span style="text-align:left">
                                            <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="font-weight:bold;color:rgb(51,51,51);font-size:13px">
                                              <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="color:rgb(0,0,0);font-size:small"><b style="font-size:13px">
                                                <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none" color="#b45f06"><a href="#"  imageanchor="1"><img src="img/img/ico-mini.png"  border="0"></a></font></font></span></div>
                                                </b></b></font></span></div>
                                              &nbsp;</b><a href="canHo1x55.aspx" style="margin:0px;padding:0px;text-decoration:none;outline:none;" title="Căn hộ 1 phòng ngủ 55m2"><font color="#b45f06" size="3">Căn hộ 1 phòng ngủ 55m2</font><font color="#005596">&nbsp;</font> </a></font></span> <span style="color:#F00;font-weight:700;"></span></div>
                                            </span></div>
                                        </div>
                                        </font></span></font></div>
                                    </div>
                                  </div>
                                </li>
                                
                            
                                                 
                                
                                
                                <li style="font-family:Tahoma;line-height:18px;text-align:left;padding:0px;margin:0px;list-style:none;border-bottom-width:1px;border-bottom-color:rgb(204,204,204);border-bottom-style:dashed;width:100%;background-image:url()"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="font-weight:bold;color:rgb(51,51,51);font-size:13px;line-height:28px">&nbsp;</span></font>
                                  <div style="display:inline!important">
                                    <div style="display:inline!important">
                                      <div style="display:inline!important"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none">
                                        <div style="display:inline!important">
                                          <div style="text-align:center;display:inline!important"><span style="text-align:left">
                                            <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="font-weight:bold;color:rgb(51,51,51);font-size:13px">
                                              <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="color:rgb(0,0,0);font-size:small"><b style="font-size:13px">
                                                <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none" color="#b45f06"><a href="#"  imageanchor="1"><img src="img/img/ico-mini.png"  border="0"></a></font></font></span></div>
                                                </b></b></font></span></div>
                                              &nbsp;</b><a href="canHo2x71.aspx"  style="margin:0px;padding:0px;text-decoration:none;outline:none;" title="Căn hộ 2 phòng ngủ 71m2"><font color="#b45f06" size="3">Căn hộ 2 phòng ngủ 71m2</font><font color="#005596">&nbsp;</font> </a></font></span> <span style="color:#F00;font-weight:700;"></span></div>
                                            </span></div>
                                        </div>
                                        </font></span></font></div>
                                    </div>
                                  </div>
                                </li>
                                
                            
                                                 
                                
                                
                                <li style="font-family:Tahoma;line-height:18px;text-align:left;padding:0px;margin:0px;list-style:none;border-bottom-width:1px;border-bottom-color:rgb(204,204,204);border-bottom-style:dashed;width:100%;background-image:url()"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="font-weight:bold;color:rgb(51,51,51);font-size:13px;line-height:28px">&nbsp;</span></font>
                                  <div style="display:inline!important">
                                    <div style="display:inline!important">
                                      <div style="display:inline!important"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none">
                                        <div style="display:inline!important">
                                          <div style="text-align:center;display:inline!important"><span style="text-align:left">
                                            <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="font-weight:bold;color:rgb(51,51,51);font-size:13px">
                                              <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="color:rgb(0,0,0);font-size:small"><b style="font-size:13px">
                                                <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none" color="#b45f06"><a href="#"  imageanchor="1"><img src="img/img/ico-mini.png"  border="0"></a></font></font></span></div>
                                                </b></b></font></span></div>
                                              &nbsp;</b><a href="canHo2x77.aspx
                                                  "  style="margin:0px;padding:0px;text-decoration:none;outline:none;" title="Căn hộ 2 phòng ngủ 77m2"><font color="#b45f06" size="3">Căn hộ 2 phòng ngủ 77m2</font><font color="#005596">&nbsp;</font> </a></font></span> <span style="color:#F00;font-weight:700;"></span></div>
                                            </span></div>
                                        </div>
                                        </font></span></font></div>
                                    </div>
                                  </div>
                                </li>
                                
                            
                                                 
                                
                                
                                <li style="font-family:Tahoma;line-height:18px;text-align:left;padding:0px;margin:0px;list-style:none;border-bottom-width:1px;border-bottom-color:rgb(204,204,204);border-bottom-style:dashed;width:100%;background-image:url()"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="font-weight:bold;color:rgb(51,51,51);font-size:13px;line-height:28px">&nbsp;</span></font>
                                  <div style="display:inline!important">
                                    <div style="display:inline!important">
                                      <div style="display:inline!important"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none">
                                        <div style="display:inline!important">
                                          <div style="text-align:center;display:inline!important"><span style="text-align:left">
                                            <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="font-weight:bold;color:rgb(51,51,51);font-size:13px">
                                              <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="color:rgb(0,0,0);font-size:small"><b style="font-size:13px">
                                                <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none" color="#b45f06"><a href="#" imageanchor="1"><img src="img/img/ico-mini.png" tppabs="http://chudautunovaland.com/wp-content/themes/c0m.vn/static/ico-mini.png" border="0"></a></font></font></span></div>
                                                </b></b></font></span></div>
                                              &nbsp;</b><a href="canHo2x79.aspx"  style="margin:0px;padding:0px;text-decoration:none;outline:none;" title="Căn hộ 2 phòng ngủ 79m2"><font color="#b45f06" size="3">Căn hộ 2 phòng ngủ 79m2</font><font color="#005596">&nbsp;</font> </a></font></span> <span style="color:#F00;font-weight:700;"></span></div>
                                            </span></div>
                                        </div>
                                        </font></span></font></div>
                                    </div>
                                  </div>
                                </li>
                                
                            
                                                 
                                
                                
                                <li style="font-family:Tahoma;line-height:18px;text-align:left;padding:0px;margin:0px;list-style:none;border-bottom-width:1px;border-bottom-color:rgb(204,204,204);border-bottom-style:dashed;width:100%;background-image:url()"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="font-weight:bold;color:rgb(51,51,51);font-size:13px;line-height:28px">&nbsp;</span></font>
                                  <div style="display:inline!important">
                                    <div style="display:inline!important">
                                      <div style="display:inline!important"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none">
                                        <div style="display:inline!important">
                                          <div style="text-align:center;display:inline!important"><span style="text-align:left">
                                            <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="font-weight:bold;color:rgb(51,51,51);font-size:13px">
                                              <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="color:rgb(0,0,0);font-size:small"><b style="font-size:13px">
                                                <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none" color="#b45f06"><a href="#"  imageanchor="1"><img src="img/img/ico-mini.png"  border="0"></a></font></font></span></div>
                                                </b></b></font></span></div>
                                              &nbsp;</b><a href="canHo3x95.aspx" style="margin:0px;padding:0px;text-decoration:none;outline:none;" title="Căn hộ 3 phòng ngủ 94.9m2"><font color="#b45f06" size="3">Căn hộ 3 phòng ngủ 94.9m2</font><font color="#005596">&nbsp;</font> </a></font></span> <span style="color:#F00;font-weight:700;"></span></div>
                                            </span></div>
                                        </div>
                                        </font></span></font></div>
                                    </div>
                                  </div>
                                </li>
                                
                            
                                                 
                                
                                
                                <li style="font-family:Tahoma;line-height:18px;text-align:left;padding:0px;margin:0px;list-style:none;border-bottom-width:1px;border-bottom-color:rgb(204,204,204);border-bottom-style:dashed;width:100%;background-image:url()"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="font-weight:bold;color:rgb(51,51,51);font-size:13px;line-height:28px">&nbsp;</span></font>
                                  <div style="display:inline!important">
                                    <div style="display:inline!important">
                                      <div style="display:inline!important"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none">
                                        <div style="display:inline!important">
                                          <div style="text-align:center;display:inline!important"><span style="text-align:left">
                                            <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="font-weight:bold;color:rgb(51,51,51);font-size:13px">
                                              <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="color:rgb(0,0,0);font-size:small"><b style="font-size:13px">
                                                <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none" color="#b45f06"><a href="#"  imageanchor="1"><img src="img/img/ico-mini.png"  border="0"></a></font></font></span></div>
                                                </b></b></font></span></div>
                                              &nbsp;</b><a href="canHo3x99.aspx"  style="margin:0px;padding:0px;text-decoration:none;outline:none;" title="Căn hộ 3 phòng ngủ 99m2"><font color="#b45f06" size="3">Căn hộ 3 phòng ngủ 99m2</font><font color="#005596">&nbsp;</font> </a></font></span> <span style="color:#F00;font-weight:700;"></span></div>
                                            </span></div>
                                        </div>
                                        </font></span></font></div>
                                    </div>
                                  </div>
                                </li>
                                
                            
                                <li style="font-family:Tahoma;line-height:18px;text-align:left;padding:0px;margin:0px;list-style:none;border-bottom-width:1px;border-bottom-color:rgb(204,204,204);border-bottom-style:dashed;width:100%;background-image:url()"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="font-weight:bold;color:rgb(51,51,51);font-size:13px;line-height:28px">&nbsp;</span></font>
                                  <div style="display:inline!important">
                                    <div style="display:inline!important">
                                      <div style="display:inline!important"><font style="font-family:arial,sans-serif;line-height:normal;margin:0px;padding:0px;outline:none"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none">
                                        <div style="display:inline!important">
                                          <div style="text-align:center;display:inline!important"><span style="text-align:left">
                                            <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="font-weight:bold;color:rgb(51,51,51);font-size:13px">
                                              <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><b style="color:rgb(0,0,0);font-size:small"><b style="font-size:13px">
                                                <div style="display:inline!important"><span style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none"><font style="margin:0px;padding:0px;outline:none" color="#b45f06"><a href="#"  imageanchor="1"><img src="img/img/ico-mini.png"  border="0"></a></font></font></span></div>
                                                </b></b></font></span></div>
                                              &nbsp;</b><a href="canHo3x109.aspx"  style="margin:0px;padding:0px;text-decoration:none;outline:none;" title="Căn hộ 3 phòng ngủ 109m2"><font color="#b45f06" size="3">Căn hộ 3 phòng ngủ 109m2</font><font color="#005596">&nbsp;</font> </a></font></span> <span style="color:#F00;font-weight:700;"></span></div>
                                            </span></div>
                                        </div>
                                        </font></span></font></div>
                                    </div>
                                  </div>
                                </li>
                                
                                 
                                
                              
                          
                           
                           
                           
                               
                              </ul>
                              <div><font color="#333333" face="arial, sans-serif"><br>
                                </font></div>
                              <ul style="font-family:Tahoma;line-height:18px;margin:0px;padding:0px">
                               
                               
                                  
                                
                                
                                
                                
                                
                                  
                                  
                                   
                                  
                                  
                                  
                              </ul>
                            </div>
                          </div>
                        </div>

                      </div>
                    </div>
                 </div>

                <div class="col col-sm-9 col-md-9 col-lg-9">
                    <table style="border-collapse: collapse; border-color: rgb(136,136,136); border-width: 0px" border="0" bordercolor="#888" cellspacing="0">
                <tbody>
                    <tr>
                        <td>
                            <div class="content">
                                <h3 style="text-align: center;"><a name="
                                     &#8211; Đẳng cấp của căn hộ hạng sang"></a><span style="color: #b45f06; font-family: trebuchet ms,sans-serif; font-size: x-large;">Căn hộ The Park Avenue &#8211; Đẳng cấp của căn hộ hạng sang                                        
                                </span></h3>


                                <div style="display: none" class="mgs">
                                    KHÁCH HÀNG XIN LƯU Ý: Trước khi tới tham quan nhà mẫu, quý khách nên gọi điện lại số hotline để nhân viên kiểm tra xem còn vị trí những căn mà khách hàng lựa chọn hay không! (đã có nhiều khách hàng đến nhưng không còn vị trí mình chọn nên chưa mua được).
                                </div>

                                <ul style="color: rgb(0,85,150); margin: 30px 0px 0px; padding: 0px; list-style: none; text-align: center; font-family: Arial,Helvetica,sans-serif; line-height: 18px; background-color: rgb(255,255,255)">
                                    <h3 style="font-size: 12px; line-height: normal"><a name=""></a><font size="5" face="trebuchet ms, sans-serif" color="#b45f06"></font></h3>
                                    <p><font size="4" face="trebuchet ms, sans-serif" color="#b45f06"></font></p>
                                </ul>


                                <div style="clear: both"></div>

                                <h1><span style="color: #ff0000;">Căn hộ The Park Avenue tiện nghi vượt trội</span></h1>
                                <p>Trong thời buổi hiện đại mà thị trường bất động sản đang phát triển sôi động như hiện nay,việc lựa chọn cho mình một căn hộ sang trọng tọa lạc ở những mảnh đất vàng của thành phố thật không phải dễ dàng. Hiểu được nổi lo đó, <strong>Tập đoàn bất động sản Novaland</strong> chúng tôi xin giới thiệu <strong>căn hộ hạng sang The Park Avenue</strong> tọa lạc tại quận 11 với những tiện ích vượt trội nhất.</p>
                                <figure id="attachment_335" style="width: 708px;" class="wp-caption aligncenter">
                                    <img class="wp-image-335 size-full" src="img/img/h1.jpg" alt="Can ho The Park Avenue" width="708" height="450" /><figcaption class="wp-caption-text"><em>Nhà mẫu Căn hộ The Park Avenue</em></figcaption>
                                </figure>
                                <p><strong><span style="color: #ff0000;"><em><a style="color: #ff0000;" href="#" >Căn hộ The Park Avenue</a></em></span></strong> của chúng tôi được xây dựng với mục đích đem đến những ngôi nhà sang trọng cho bạn cảm giác thỏa mái nhất sau một ngày làm việc mệt mỏi.</p>
                                <p>
                                    <img class="aligncenter size-full wp-image-338" src="img/img/h2.jpg"  alt="Dự án The Park Avenue" width="677" height="510" /><br />
                                    Sự khác biệt của <span style="color: #339966;"><em>căn hộ The Park Avenue</em></span> so với các căn hộ khác trong thành phố không chỉ ở vị trí trung tâm thuận lợi của mình mà còn là những tiện ích tuyệt vời của một không gian nghĩ dưỡng hoàn hảo.
                                </p>
                                <figure id="attachment_336" style="width: 676px;" class="wp-caption aligncenter">
                                    <img class="wp-image-336" src="img/img/h3.jpg"  alt="Căn hộ The Park Avenue" width="676" height="448" /><figcaption class="wp-caption-text"><em>Căn hộ The Park Avenue của Novaland</em></figcaption>
                                </figure>
                                <p>Những cư dân sinh sống tại <strong>dự án The Park Avenue</strong> được tận hưởng không gian của phòng tập gym-yoga cao cấp Califonia, nhà sách Phương Nam, trường quốc tế Việt Úc , trung tâm thương mại, mua sắm: Lotte Mark, Parkson, nhà trẻ, hồ bơi, quán cà phê, và hơn 20 ngân hàng cách chưa đầy 500m trên tuyến đường Lê Đại Hành. Những trung tâm chăm sóc sức khỏe cùng hệ thống an ninh nghiêm ngặt cho cư dân cảm giác hoàn toàn yên tâm khi sinh sống tại đây.</p>
                                <figure id="attachment_337" style="width: 708px;" class="wp-caption aligncenter">
                                    <img class="wp-image-337 size-full" src="img/img/h4.jpg"  alt="thiet ke can ho the park avenue" width="708" height="450" /><figcaption class="wp-caption-text"><em>Thiết kế căn hộ The Park Avenue thoáng mát, tân dụng diện tích</em></figcaption>
                                </figure>
                                <p>Hãy để căn hộ The Park Avenue chăm sóc cuộc sống của bạn và gia đình. Những phút giây ấm ấp, những khoảnh khắc hạnh phúc của gia đình bạn tại dự án The Park Avenue là sự thành công của tập đoàn Novaland chúng tôi.</p>
                                <p><em><span style="color: #ff0000;"><strong>Xem chi tiết</strong> <strong><a href="#" >can ho The Park Avenue </a></strong></span></em></p>
                                <p>&nbsp;</p>
                               
                                <h2><span style="color: #339966;">LIÊN HỆ NGAY &#8211; Phòng kinh doanh Chủ đầu tư Novaland :</span></h2>
                                <h3>Địa chỉ : 39 Hải Thượng Lãn Ông, Quận 5, HCM</h3>
                                <h2><span style="color: #ff0000;">Trưởng nhóm kinh doanh &#8211; Trần Thành An</span></h2>
                                <h2><span style="color: #ff0000;">Hotline : 0919 26 79 26 &#8211; 0904 86 88 77</span></h2>
                                <h4><span style="color: #3366ff;">Email : an.tranthanh@novaland.com.vn</span></h4>
                                <h4><span style="color: #3366ff;">Website: www.Chudautunovaland.com</span></h4>
                                <p>&nbsp;</p>




                                <!-- Go to www.addthis.com/dashboard to customize your tools -->
                                <div style="padding-top: 40px; width: 500px; margin: 0 auto" class="addthis_native_toolbox"></div>


                            </div>

                        </td>
                    </tr>
                </tbody>
            </table>
                 </div>
            </div>
           
        </div>
    </section>
    <!--  end listing section  -->

    <footer style="margin-top:-170px">
       
        <div class="copyrights wrapper" style="margin-top:-100px">
         
                   <h4>Địa chỉ : 39 Hải Thượng Lãn Ông, Quận 5, HCM</h4>
                                <h4><span style="color: #ff0000;">Trưởng nhóm kinh doanh &#8211; Trần Thành An</span></h4>
                                 <h4><span style="color: #ff0000;">Hotline : 0919 26 79 26 &#8211; 0904 86 88 77</span></h4>
           
        </div>
    </footer>
    <!--  end footer  -->

</body>
</html>
