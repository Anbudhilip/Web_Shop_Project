<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="AddCategories.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="card align-middle mt-5 ">
        <div class="card-header ">
            Add Catagries List
        </div>
        <div class="card-body mt-2">
           <h3><asp:Label ID="errorMsg" CssClass="text-danger" runat="server" ></asp:Label></h3> 

             <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label disable">Catagroy ID</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_med_id" class="form-control"  ReadOnly="True" Text="Auto Genrate" runat="server"></asp:TextBox>
                </div>
                 </div>

            <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label">Medicine Code</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_med_code" class="form-control disabled " AutoComplete="off" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label">Medicine Catagory</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_med_cat" class="form-control" AutoComplete="off" value="" runat="server"></asp:TextBox>
                </div>
                </div>

             
            
            <div class="row mt-5">
                <div class="  col-md">
                    <asp:Button ID="btn_submit" class="form-control btn btn-primary" runat="server" Text="Submit" OnClick="Button1_Click" />
                </div>
                </div>

             <div class="row mt-5">
                <div class="col-md">
                    <asp:Button ID="btn_update" runat="server" class="form-control btn btn-primary" OnClick="cat_edit" Text="Update" Visible="False" />
                    </div>
            </div>
               <div class="row mt-5">
                <div class="col-md">
                    <asp:Button ID="Cancel" class="form-control btn btn-warning" runat="server" Text="Cancel" OnClick="Cancel_Click" />
                </div>
            </div>
            <div class="row mt-5">
                <div class="col-md">
                    <asp:Button ID="btn_del"  class="form-control btn btn-warning" runat="server" Text="Delete" OnClick="btn_del_Click" Visible="False" />
     
                </div>
            </div>

          
         </div>
         </div>

  
    
   <%-- <script>
    
        Button1_Click()
        {
            var url;
            var data;
            var method;

            if (isNew == true) {
                url = 'index.aspx/add';
                data = "{cat_code:'" + $('#txt_med_code').val() + "' ,cat_name: '" + $('# txt_med_cat').val() + "'}";
                method = 'POST';
            }



            $.ajax({

                type: method,
                url: url,
                datatype: 'JSON',
                contentType: 'application/json; charset =utf-8',
                data: data,



                success: function (data) {

                    var msg;

                    if (isNew) {
                        msg = "Successfully Added Well Done Anbu";
                    }
                    else {
                        msg = "Successfully Added Well Done Anbu";
                    }



                    $.alert({
                        title: 'Success!',
                        content: msg,
                        type: 'green',
                        theme: 'light',
                        useBootstrap: false,
                        autoClose: 'ok|2000'
                    });

                }
            });
        }--%>
</asp:Content>
