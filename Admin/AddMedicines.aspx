<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="AddMedicines.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="card">
        <div class="card-header">
            Add Medicines
        </div>
        <div class="card-body mt-2">
              <h3><asp:Label ID="errorMsg" CssClass="text-danger" runat="server" ></asp:Label></h3> 
              <div class="mb-3 row ">
                <label class="col-sm-2 col-form-label ">Medicine ID</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_id" class="form-control disabled" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row ">
                <label class="col-sm-2 col-form-label">Medicine Code</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_code" class="form-control" AutoComplete="off" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row ">
                <label class="col-sm-2 col-form-label">Medicine Name</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_name" class="form-control" AutoComplete="off" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <label class="col-sm-2 col-form-label">Categories</label>
                <div class="col-sm-10">
                   <asp:DropDownList ID="txt_category" class="form-control"  runat="server">
                      
                    </asp:DropDownList>
                </div>
               
            </div>
            <div class="mb-3 row">
                <label class="col-sm-2 col-form-label">Expire Date</label>
                <div class="col-sm-10" id="tx">
                    <asp:TextBox ID="txt_date" class="form-control" AutoComplete="off" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <label class="col-sm-2 col-form-label">
                    Medicine Price
                </label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_price" class="form-control" AutoComplete="off" runat="server" TextMode="Number"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <label class="col-sm-2 col-form-label">Medicine Stock</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_stock" class="form-control" AutoComplete="off" runat="server" TextMode="Number"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row align-content-center">
                 <asp:Button ID="Button3" class="btn btn-warning col-2 mx-3" runat ="server" Text="Cancel" OnClick="Button3_Click" />
                <asp:Button ID="btn_update" class="btn btn-primary col-2 mx-3" runat ="server" Text="Update" Visible="False" OnClick="btn_update_Click" />
                <asp:Button ID="btn_save" class="btn  btn-primary  col-2 mx-3" runat ="server" Text="Save" OnClick="btn_save_Click"  />
                <asp:Button ID="btn_delete" class="btn btn-warning col-2 mx-3" runat="server" Text="Delete" OnClick="btn_delete_Click" Visible="False" />
            </div>
        </div>
    </div>
  
  

</asp:Content>
