<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="NewSeller.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Admin.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">






    
        <div class="card">
            <div class="card-header text-center">
        <h4 class="r align-content-center  m-3">Add New Seller </h4>
                </div>
     <h3><asp:Label ID="errorMsg" CssClass="text-danger" AutoComplete="off" runat="server" ></asp:Label></h3>
            <div class="mb-3 mt-3 card-body">
                <div>
            <label for="name" class="form-label">Seller ID</label>
             <asp:TextBox ID="id" class="form-control disable" AutoComplete="off" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3 mt-3">
            <label for="name" class="form-label">Full Name</label>
             <asp:TextBox ID="name" class="form-control" AutoComplete="off" placeholder="Full Name " runat="server"></asp:TextBox>
        </div>
        <div class="container=md mt-3">
        <legend class="col-form-label col-sm-2 pt-0 ">Gender</legend>
      <div class="form-check ml-3 ">
          <asp:RadioButtonList runat="server" CssClass="auto-style1" ID="gender">
              <asp:ListItem>Male</asp:ListItem>
              <asp:ListItem>Female</asp:ListItem>
              <asp:ListItem>Transgender</asp:ListItem>
          </asp:RadioButtonList>
      </div>
        </div>
        <div class="mb-3">
  <label for="address" class="form-label">Permanent Address</label>
   <asp:TextBox ID="address" AutoComplete="off" class="form-control"  row="3" runat="server"></asp:TextBox>
</div>
        <div class="mb-3 ">
            <label for="email" class="form-label">Email</label>
       <asp:TextBox ID="email" class="form-control" AutoComplete="off" placeholder="Email" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="phoneNo" class="form-label">Mobile Number</label>
   <asp:TextBox ID="phoneNo" class="form-control"  AutoComplete="off" placeholder="Mobile Number" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="password" class="form-label">Password</label>
             <asp:TextBox ID="pwd" class="form-control" AutoComplete="off" placeholder=" Password " runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for=" confirmpassword" class="form-label"> Confirm Password</label>
            <asp:TextBox ID="cpwd" class="form-control"  placeholder="Confirm Password " runat="server"></asp:TextBox>
        </div>
            

            <div class="row card-footer">
                <div class="col-md">
                    <asp:Button ID="Cancel" class="form-control btn btn-warning" runat="server" Text="Cancel" OnClick="Cancel_Click" />
                </div>
                <div class="  col-md">

                    <asp:Button ID="btn_update" class="form-control btn btn-warning" runat="server" Text="Update" OnClick="Button1_Click" Visible="False" />
                </div>

                <div class="col-md">
                    <asp:Button ID="submit" runat="server" class="form-control btn btn-primary" Text="Submit" OnClick="submit_Click" />
                </div>
                <div class="col-md">
                    <asp:Button ID="delete" runat="server" class="form-control btn btn-primary" Text="Delete" OnClick="delete_Click" Visible="False"  />
                </div>
                
            </div>
       
        </div>
            </div>
               

   

</asp:Content>
