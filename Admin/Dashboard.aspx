<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <div class="card-header ">
            Pharmacy Prograss
        </div>
        <div class="card-body mt-2">
            <h3>
                <asp:Label ID="errorMsg" CssClass="text-danger" runat="server"></asp:Label></h3>

            <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label disable">No of Employees</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_empNo" class="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label">No of Catagory</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_catagory" class="form-control disabled " ReadOnly="true" AutoComplete="off" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label">No of Medicines</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_medicines" class="form-control" ReadOnly="true" AutoComplete="off" value="" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label">
                    No of Purchases

                </label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_purchases" class="form-control" ReadOnly="true" AutoComplete="off" value="" runat="server"></asp:TextBox>
                </div>
            </div>
             <div class="mb-3 row mt-5">
                <label class="col-sm-2 col-form-label">
                   Total Income

                </label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txt_amount" class="form-control" ReadOnly="true" AutoComplete="off" value="" runat="server"></asp:TextBox>
                </div>
            </div>
            

     </div>
        </div>

           
</asp:Content>
