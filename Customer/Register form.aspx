<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register form.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Register_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 45px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-md my-5 w-50 mx-auto card">
        <div class="card-body">
        <h4 class="text-center align-content-center m-3">Register Form </h4>
        <div class="mb-3 mt-3">
            <label for="name" class="form-label">Full Name</label>
             <asp:TextBox ID="name" class="form-control" placeholder="Full Name " runat="server"></asp:TextBox>
        </div>
        <div class="container=md mt-3">
        <legend class="col-form-label col-sm-2 pt-0 ">Gender</legend>
      <div class="form-check ml-3 ">
          <asp:RadioButtonList runat="server" CssClass="auto-style1">
              <asp:ListItem>Male</asp:ListItem>
              <asp:ListItem>Female</asp:ListItem>
              <asp:ListItem>Transgender</asp:ListItem>
          </asp:RadioButtonList>
      </div>
        </div>
        <div class="mb-3">
  <label for="address" class="form-label">Permanent Address</label>
   <asp:TextBox ID="address" class="form-control" row="3" runat="server"></asp:TextBox>
</div>
        <div class="mb-3 ">
            <label for="email" class="form-label">Email</label>
       <asp:TextBox ID="email" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="phoneNo" class="form-label">Mobile Number</label>
   <asp:TextBox ID="phoneNo" class="form-control" placeholder="Mobile Number" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="password" class="form-label">Password</label>
             <asp:TextBox ID="pwd" class="form-control" placeholder=" Password " runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for=" confirmpassword" class="form-label"> Confirm Password</label>
            <asp:TextBox ID="cpwd" class="form-control" placeholder="Confirm Password " runat="server"></asp:TextBox>
        </div>
            

            <div class="row">
                 <div class="  col-md mb-3 ml-3">
             <asp:Button ID="Cancel"   class="form-control btn btn-warning"   runat="server" Text="Cancel" />
        </div>
       <div class="  col-md mb-3">
             <asp:Button ID="submit" runat="server"  class="form-control btn btn-primary"   Text="Submit" />
                </div>
        </div>
               
</div >
    </div >
   
    


</asp:Content>

