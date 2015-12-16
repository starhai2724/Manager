<%@ Page Language="C#" AutoEventWireup="true" CodeFile="price.aspx.cs" Inherits="pages_price" MasterPageFile="~/masterPage/HomePage.master" %>

<%@ Import Namespace="Manager.Models" %>
<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <script src="../js/price.js"></script>
        <div class="row">
            <div class="col-lg-12">
                <h3 class="page-header" style="margin: 15px 0 20px;">Giá</h3>
                <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 65px" onclick="add()">Thêm</button>
                <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px;" onclick="edit()">Lưu</button>
                 <button type="button" class="btn btn-primary pull-right"  style="margin-top: -64px; margin-right: 140px" onclick="exportFile()">In</button>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
        <!-- add apartment -->
        <div class="row">
            <div class="row">
                <div class="col col-sm-4 col-md-4 col-lg-4">
                    <div class="form-group">
                        <p>Mã giá</p>
                        <input disabled="disabled" type="text" class="form-control" style="margin-top: -10px;" id="text_idPrice" placeholder="" />
                    </div>
                </div>
                <div class="col col-sm-4 col-md-4 col-lg-4">
                    <div class="form-group">
                        <p>Giá điện/ký</p>
                        <input type="text" class="form-control" style="margin-top: -10px;" id="text_priceElectric" placeholder="Nhập giá điện" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col col-sm-4 col-md-4 col-lg-4">
                    <div class="form-group">
                        <p>Giá nước/ký</p>
                        <input type="text" class="form-control" style="margin-top: -10px;" id="text_priceWater" placeholder="Nhập giá nước" />
                    </div>
                </div>
                <div class="col col-sm-4 col-md-4 col-lg-4">
                    <div class="form-group">
                        <p>Giá internet/tháng</p>
                        <input type="text" class="form-control" style="margin-top: -10px;" id="text_priceInternet" placeholder="Nhập giá internet" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col col-sm-4 col-md-4 col-lg-4">
                    <div class="form-group">
                        <p>Giá rác/tháng</p>
                        <input type="text" class="form-control" style="margin-top: -10px;" id="text_priceTrash" placeholder="Nhập giá rác" />
                    </div>
                </div>
                <div class="col col-sm-4 col-md-4 col-lg-4">
                    <div class="form-group">
                        <p>Tình trạng</p>
                        <select class="form-control" style="margin-top: -10px;" id="text_status">
                            <option>Đang hoạt động</option>
                            <option>Không hoạt động</option>
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
                                <input type="text" class="form-control" placeholder="Tìm kiếm" name="srch-term" id="srch"/>
                            <div class="input-group-btn">
                               <button class="btn btn-primary"  type="button" onclick="search()" id="btn_search"><i class="glyphicon glyphicon-search"></i></button>
                            </div>
                            </div>
                        </div>
                    </div>
                    <br/>
                   
                     <div class="row" id="divtable_price">
                </div>
                    <!-- <table class="table table-striped table-bordered table-hover" id="dataTables-example" style="margin-top: -13px;">
                        <thead>
                            <tr class="info">
                                <th>Mã giá </th>
                                <th>Giá điện</th>
                                <th>Giá nước</th>
                                <th>Giá internet</th>
                                <th>Giá rác</th>
                                <th>Tình trạng </th>
                                <th class=" no-link last"><span class="nobr">Thao tác</span>
                                </th>
                            </tr>
                        </thead>

                        <tbody>
                            <tr class="even pointer">
                                <td class=" ">001</td>
                                <td class=" ">2500</td>
                                <td class=" ">5000</td>
                                <td class=" ">150,000</td>
                                <td class=" ">30,000</td>
                                <td class="a-right a-right ">Đang hoạt động</td>
                                <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                                </td>
                            </tr>
                            <tr class="even pointer">
                                <td class=" ">003</td>
                                <td class=" ">2500</td>
                                <td class=" ">5000</td>
                                <td class=" ">150,000</td>
                                <td class=" ">30,000</td>
                                <td class="a-right a-right ">Đang hoạt động</td>
                                <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                                </td>
                            </tr>
                            <tr class="even pointer">
                                <td class=" ">004</td>
                                <td class=" ">2500</td>
                                <td class=" ">5000</td>
                                <td class=" ">150,000</td>
                                <td class=" ">30,000</td>
                                <td class="a-right a-right ">Đang hoạt động</td>
                                <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                                </td>
                            </tr>
                            <tr class="even pointer">
                                <td class=" ">005</td>
                                <td class=" ">2500</td>
                                <td class=" ">5000</td>
                                <td class=" ">150,000</td>
                                <td class=" ">30,000</td>
                                <td class="a-right a-right ">Đang hoạt động</td>
                                <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                                </td>
                            </tr>
                            <tr class="odd pointer">
                                <td class=" ">002</td>
                                <td class=" ">2500</td>
                                <td class=" ">5000</td>
                                <td class=" ">150,000</td>
                                <td class=" ">30,000</td>
                                <td class="a-right a-right ">Không hoạt động</td>
                                <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>|  <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                                </td>
                                <script>
                                    $(document).ready(function () {
                                        $('[data-toggle="tooltip"]').tooltip();
                                    });
                            </script>
                            </tr>

                        </tbody>

                    </table>-->


                </div>
            </div>


            <br />

            <!--footer -->
            <hr/>
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
