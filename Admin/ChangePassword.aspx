<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Change_Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            flex: 1 0 0%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <div class="card align-middle mt-5 ">
        <div class="card-header ">
          Change Password
        </div>
        <div class="card-body mt-2">
           <h3><asp:Label ID="errorMsg" CssClass="text-danger" runat="server" ></asp:Label></h3> 

             <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label disable">User Name</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_uname" class="form-control"    runat="server"></asp:TextBox>
                </div>
                 </div>

            <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label">Password</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_password" class="form-control"  AutoComplete="off" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label">Confirm Password</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_cpassword" class="form-control"  AutoComplete="off" value="" runat="server"></asp:TextBox>
                </div>
                </div>

     <div class="row mt-5 card-footer">
             <div class="row mt-5">
                <div class="col-md">
                    <asp:Button ID="update" runat="server" class="form-control btn btn-primary" Text="Update" OnClick="update_Click"  />
                    </div>
            </div>
               <div class="row mt-5">
                <div class="auto-style1">
                    <asp:Button ID="Cancel" class="form-control btn btn-warning" runat="server" Text="Cancel" OnClick="Cancel_Click"  />
                </div>
            </div>
           

          
         </div>
         </div>

  



</asp:Content>
