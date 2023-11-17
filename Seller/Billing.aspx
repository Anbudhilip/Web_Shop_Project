<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Billing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-6">
                    <div class="card">
                        <div class="card-header">
                            Customer Billing System
                        </div>
                        <div class="card-body">

                            <div class="mb-3 row">
                                <label class="col-sm-2 col-form-label">Medicine Code</label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txt_code" class="form-control" AutoComplete="off" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="mb-3 row">
                                <label class="col-sm-2 col-form-label">Medicine Name</label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txt_name" class="form-control" AutoComplete="off" runat="server"></asp:TextBox>
                                </div>
                            </div>

                            <div class="mb-3 row">
                                <label class="col-sm-2 col-form-label">Medicine Price</label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txt_Price" class="form-control" AutoComplete="off" runat="server"></asp:TextBox>
                                </div>

                            </div>
                            <div class="mb-3 row">
                                <label class="col-sm-2 col-form-label">Medicine Quantity</label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txt_quantity" AutoComplete="off" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                                </div>

                            </div>
                            <div class="mb-3 row">
                                <label class="col-sm-2 col-form-label">Billing Date</label>
                                <div class="col-sm-10">

                                    <asp:TextBox ID="txt_date" AutoComplete="off" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                            <div class="card-footer">
                                <div class=" row">
                                    <div class="col w-3 ">
                                        <asp:Button ID="btn_reset" CssClass="btn btn-warning mr-3" runat="server" Text="Clear" />
                                    </div>
                                    <div class="col w-3">
                                        <div class=" row">
                                            <div class="col w-3 ">
                                                <asp:Button ID="txt_addbill" CssClass="btn btn-primary" runat="server" Text="Add Bill" OnClick="txt_addbill_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    ---

              <div class="card">
                  <div class="card-body">
                      <asp:GridView ID="GridView2" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="516px" BackColor="White" BorderColor="#FF33CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Caption="Medicines List" CaptionAlign="Top" Height="300px">
                        <AlternatingRowStyle BackColor="White" />
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                            </div>
                   
                </div>

                    </div>

                <div class="col-6" style="float: right;">
                    <div class="card">
                        <div class="card-header">
                            Client Bill
                        </div>
                        <div class="card-body h-50">
                             <asp:GridView ID="MedList" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="525px">
                                <AlternatingRowStyle BackColor="White" />
                                <FooterStyle BackColor="#CCCC99" />
                                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#F7F7DE" />
                                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                <SortedAscendingHeaderStyle BackColor="#848384" />
                                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                <SortedDescendingHeaderStyle BackColor="#575357" />
                            </asp:GridView>
                      </div>
                     <div class="card-header ">
                            <asp:Label ID="lblcost" CssClass="h-3 p-3" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div class="card-footer">
                               

                            <asp:Button ID="Button2" runat="server" Text="Pay" OnClick="Button2_Click" />

                            </div>
                                  
                        </div>
                       
                    </div>
               
               
                        <%--  bill ammunt--%>
                    
            </div>
                </div>
            
        --------------------------------------------------------------
</form>
    <a href="../Home.aspx">Home page</a>

    /script>
</body>
</html>
