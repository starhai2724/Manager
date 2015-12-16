<%@ Page Language="C#" AutoEventWireup="true" CodeFile="employee.aspx.cs" Inherits="pages_employee" MasterPageFile="~/masterPage/HomePage.master" %>

<%@ Import Namespace="Manager.Models" %>
<asp:Content ContentPlaceHolderID="CPH1" runat="server">
        <script src="../js/employee.js"></script>
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Nhân viên</h3>
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
                    <p>Mã nhân viên</p>
                    <input disabled="disabled" type="text" class="form-control" style="margin-top: -10px;" id="text_idEmployee" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tên nhân viên</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_nameEmployee" placeholder="Nhập tên nhân viên" />
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Quê quán</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_addressEmployee" placeholder="Nhập quê quán" />
                </div>
            </div>
              <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Chức vụ</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_officeEmployee" placeholder="Nhập chức vụ" />
                </div>
               
            </div>
           
        </div>
     <div class="row">
           
             <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Chứng minh nhân dân</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_identyfi_card_emp" placeholder="Nhập chứng minh nhân dân" />
                </div>
            </div>
          <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Lương</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="text_salaryEmployee" placeholder="Nhập lương" />
                </div>
            </div>
          

        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giới tính</p>
                    <select class="form-control" style="margin-top: -10px;" id="text_sexEmployee">
                        <option>Nam</option>
                        <option>Nữ</option>
                    </select>
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

        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Ngày sinh</p>
                    <input min="2010-01-01"
                        type="date" name="txtTGTu" value="" id="birthday_emp"
                        class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày sinh"/>
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



                 <div class="row" id="divtable_emp">
                 </div>
              
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
