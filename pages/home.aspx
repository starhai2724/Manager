<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="pages_home" MasterPageFile="~/masterPage/HomePage.master" %>


<asp:Content ContentPlaceHolderID="CPH1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Trang chủ</h3>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px">Thêm căn hộ</button>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <!-- list apartment -->
    <div class="row">
        <div class="col col-sm-2 col-md-2 col-lg-2 pull-center">
        </div>
        <div class="col col-sm-10 col-md-10 col-lg-10 ">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="col col-sm-2 col-md-2 col-lg-2 ">
                    <button type="button" class="btn btn-success"></button>
                </div>
                <div class="col col-sm-9 col-md-9 col-lg-9 ">
                    <p>Đã thuê(28)</p>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="col col-sm-2 col-md-2 col-lg-2 ">
                    <button type="button" class="btn btn-danger "></button>
                </div>
                <div class="col col-sm-9 col-md-9 col-lg-9 ">
                    <p>Đã bán(27)</p>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="col col-sm-2 col-md-2 col-lg-2 ">
                    <button type="button" class="btn btn-info pull-center"></button>
                </div>
                <div class="col col-sm-9 col-md-9 col-lg-9 ">
                    <p>Trống(19)</p>
                </div>
            </div>
        </div>


    </div>

    <div class="row">

        <div class="row">
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn" style="height: 50px; width: 90px;">Tầng 1</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A001</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A002</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A003</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A004</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A005</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A006</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A007</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A008</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A009</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">A0010</button>
            </div>
        </div>


        <!-- Modal -->
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">Chi tiết căn hộ</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col col-sm-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <a>Mã căn hộ : </a>001
               
                                </div>
                            </div>

                            <div class="col col-sm-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <a>Tên căn hộ  : </a>A001
               
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col col-sm-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <a>Giá bán : </a>92,000,000
               
                                </div>
                            </div>

                            <div class="col col-sm-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <a>Giá thuê  : </a>4,000,000
               
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col col-sm-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <a>Loại căn hộ : </a>VIP
               
                                </div>
                            </div>

                            <div class="col col-sm-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <a>Kích thước  : </a>20x20
               
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col col-sm-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <a>Tình trạng : </a>Đang thuê
               
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col col-sm-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <a>Danh sách khách hàng :</a>
                                </div>
                            </div>
                            <div class="col col-sm-8 col-md-8 col-lg-8">
                                <div class="form-group">
                                    <p>Nguyễn Thị A</p>
                                    <br>
                                    <p style="margin-top: -26px;">Nguyễn Thị B</p>
                                    <p style="margin-top: -6px;">Nguyễn Văn C</p>
                                </div>
                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </div>






        <div class="row" style="margin-top: 2px;">
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn" style="height: 50px; width: 90px;">Tầng 2</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B001</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B002</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B003</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B004</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B005</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B006</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B007</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B008</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B009</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">B0010</button>
            </div>
        </div>
        <div class="row" style="margin-top: 2px;">
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn" style="height: 50px; width: 90px;">Tầng 3</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C001</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C002</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C003</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C004</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C005</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C006</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C007</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C008</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C009</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">C0010</button>
            </div>
        </div>
        <div class="row" style="margin-top: 2px;">
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">Tầng 4</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D001</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D002</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D003</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D004</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D005</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D006</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D007</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D008</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D009</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">D0010</button>
            </div>
        </div>
        <div class="row" style="margin-top: 2px;">
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn" style="height: 50px; width: 90px;">Tầng 5</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E001</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E002</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E003</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E004</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E005</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E006</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E007</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E008</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E009</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">E0010</button>
            </div>
        </div>
        <div class="row" style="margin-top: 2px;">
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn" style="height: 50px; width: 90px;">Tầng 6</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F001</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F002</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F003</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F004</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F005</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F006</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F007</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F008</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F009</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">F0010</button>
            </div>
        </div>
        <div class="row" style="margin-top: 2px;">
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn" style="height: 50px; width: 90px;">Tầng 7</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G001</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G002</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G003</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G004</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-info" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G005</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G006</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G007</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G008</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">G009</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;">G0010</button>
            </div>
        </div>
        <div class="row" style="margin-top: 2px;">
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn" style="height: 50px; width: 90px;">Tầng 8</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H001</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H002</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H003</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H004</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-success" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H005</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H006</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H007</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H008</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H009</button>
            </div>
            <div class="col col-sm-1 col-md-1 col-lg-1">
                <button type="button" class="btn btn-danger" style="height: 50px; width: 90px;" data-toggle="modal" data-target="#myModal">H0010</button>
            </div>
        </div>

    </div>
    
    <div class="row">

        <br />

        <!--footer -->
        <hr>
        <address class="text-center">
            <strong>Tên Công Ty</strong><br />
            Linh Trung
                   
            <br />
            Quận Thủ Đức
                   
            <br />
            Phone : 097800000
               
        </address>
        <address class="text-center">
            <strong>Phạm Thị Ngọc Thư</strong><br />
            <a href="#">thu225656294@gmail.com</a>
        </address>

        <!--/. footer  -->

    </div>



</asp:Content>
