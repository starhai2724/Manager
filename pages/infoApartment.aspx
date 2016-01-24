<%@ Page Language="C#" AutoEventWireup="true" CodeFile="infoApartment.aspx.cs" Inherits="pages_infoApartment" %>

<%@ Import Namespace="Manager.Models" %>
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
    <script src="../js/infomation_Apartment.js"></script>
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
    <form id="form1" runat="server">
        <%
            string rule = (string)Session["rule"];
            User_Apartment u = (User_Apartment)Session["user"];
            CustomerDAO dao = new CustomerDAO();
            Customer cus = (Customer)dao.getCustomer(u.id_cus);
            Apartment apartment = ApartmentDAO.getApartment(cus.idApartment);
            if (u != null && rule.Equals("2"))
            {
        %>

    <section class="hero">
        <header>
            <div class="wrapper">
                <a href="#">
                    <img src="img/logo.png" class="logo" alt=""  /></a>
                <a href="#" class="hamburger"></a>
                <nav>
                 
                    
                     <ul>
                        <li><a href="#">Chào </a>&nbsp;<label style="color:red"><%=cus.nameCustomer %></label></li>
                    </ul>
                    
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

                           
                 </div>

                <div class="col col-sm-9 col-md-9 col-lg-9">
                       <h2 class="ss-form-entry" style="text-align: center;"><span style="color: #ff0000;">
                         <label class="ss-q-item-label" for="entry_1025472522">
                             <label class="ss-q-item-label" for="entry_1025472522">Thông tin căn hộ</label>&nbsp;<%=apartment.nameApartment %>
                         </label></span></h2>
                    <div class="row">
                         <div class="col col-sm-5 col-md-5 col-lg-5">
                          <div class="form-group">
                              <p>Hóa đơn từ ngày</p>
                              <input min="2010-01-01"type="date" id="date_start" value=""
                                    class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày tạo"/>
                          </div>
                         </div>
                        <div class="col col-sm-5 col-md-5 col-lg-5">
                          <div class="form-group">
                              <p>Đến ngày</p>
                              <input min="2010-01-01"type="date" id="date_end" value=""
                                    class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày tạo"/>
                          </div>
                             
                              <input type="hidden" id="id_Cus" value=<%=cus.idCustomer %>/>
                          
                         </div>
                    </div>
                     <div class="row">
                    <div class="more_listing" style="margin-top:20px">
				<button type="button" class="more_listing_btn" onclick="xem()">Xem thông tin</button>
			    </div>
                          <div class="row" id="divtable_bill">
                </div>
                 </div>
                 </div>
            </div>
           
        </div>
    </section>
    <!--  end listing section  -->

    <footer style="margin-top:-100px">
       
        <div class="copyrights wrapper" style="margin-top:-100px">
         
                   <h4>Địa chỉ : 39 Hải Thượng Lãn Ông, Quận 5, HCM</h4>
                                <h4><span style="color: #ff0000;">Trưởng nhóm kinh doanh &#8211; Trần Thành An</span></h4>
                                 <h4><span style="color: #ff0000;">Hotline : 0919 26 79 26 &#8211; 0904 86 88 77</span></h4>
           
        </div>
    </footer>
              
    <!--  end footer  -->
        <%}
            else
            { %>

        Ban khong co quyen!
        <%} %>
    </form>
</body>
</html>
