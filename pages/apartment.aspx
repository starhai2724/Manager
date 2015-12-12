<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apartment.aspx.cs" Inherits="_apartment" MasterPageFile="~/masterPage/HomePage.master" %>



<%@ Import Namespace="Manager.Models" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <script src="../js/apartment.js"></script>

    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Căn hộ</h3>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 65px" onclick="add()" id="btnAdd">Thêm</button>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px;" onclick="edit()">Lưu</button>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 140px" onclick="exportFile()">In</button>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <!-- add apartment -->
    <div class="row">
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Mã căn hộ</p>
                    <input disabled="disabled" type="text" class="form-control" style="margin-top: -10px;" id="text_idApartment" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tên căn hộ</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_nameApartment" placeholder="Nhập tên căn hộ" />
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giá bán</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_priceSale" placeholder="Nhập giá bán" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giá thuê</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_priceRent" placeholder="Nhập giá thuê" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Kích thước</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_size" placeholder="Kích thước" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tình trạng</p>
                    <select class="form-control" style="margin-top: -10px;" id="status">
                        <option value="0">Trống</option>
                        <option value="1">Đang thuê</option>
                        <option value="2">Đã bán</option>
                    </select>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group" style="margin-top: -10px;">
                    <p>Loại căn hộ</p>
                    <select class="form-control" id="type" name="type">
                        <option value="1">VIP</option>
                        <option value="0">Bình thường</option>
                    </select>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tầng</p>
                    <select class="form-control" style="margin-top: -10px;">
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                        <option>6</option>
                        <option>7</option>
                        <option>8</option>
                    </select>
                </div>
            </div>
        </div>
    </div>


    <div class="row">
        <div class="x_panel">
            <div class="x_content" style="margin-top: -20px;">
                <div class="row">
                    <div class="col col-sm-3 col-md-3 col-lg-3 pull-right">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Tìm kiếm" name="srch" id="srch" />
                            <div class="input-group-btn">
                                <button class="btn btn-primary" type="button" onclick="search()" id="btn_search"><i class="glyphicon glyphicon-search"></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                </br>
                <div class="row" id="divtable">
                </div>





            </div>
        </div>


        <br />

        <!--footer -->
        </hr>
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

    <script type="text/javascript">
        

    </script>
    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
</asp:Content>

