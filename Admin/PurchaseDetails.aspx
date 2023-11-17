<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="PurchaseDetails.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Purchase_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            margin-left: 145px;
        }
        .auto-style2 {
            margin-left: 19px;
            margin-top: 12;
        }
    .auto-style3 {
        margin-top: 40px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <h3><asp:Label ID="errorMsg" CssClass="text-danger" runat="server" ></asp:Label></h3>

      <asp:TextBox ID="txt_search" runat="server" CssClass="auto-style1" Width="412px" OnTextChanged="txt_search_TextChanged" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Text="Search " Width="107px" OnClick="Button1_Click" />
    <asp:GridView ID="GV_Bill" runat="server" CssClass="auto-style3" Height="300px"  Width="939px" OnSelectedIndexChanged="GV_Stock_SelectedIndexChanged" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CaptionAlign="Top" CellPadding="4" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BorderStyle="Solid" BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
</asp:GridView>
</asp:Content>
