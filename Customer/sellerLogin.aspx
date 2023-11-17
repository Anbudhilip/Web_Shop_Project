<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sellerLogin.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.seller_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seller Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <div class="container-md mt-4  ">
                 <h3><asp:Label ID="errorMsg" CssClass="text-danger" runat="server" ></asp:Label></h3> 
            <div class="row">
                <div class="h1 text-center text-primary ">Login</div>
            </div>
            <div class="container  card col-md-4 mb-3">
                <form>
                    <div clas="row">

                        <p class=" col-md my-4" style="text-align: center;">Seller Login</p>
                    </div>
                    <div clas="row">
                        <asp:TextBox ID="txt_email" class="form-control  mb-3 col-md" Required="true" placeholder="user name" runat="server"></asp:TextBox>
                    </div>
                    <div clas="row">
                        <asp:TextBox ID="txt_pwd" class="form-control mb-3 col-md" Required="true" placeholder="Password" type="password"  runat="server" AutoCompleteType="Search"></asp:TextBox>

                    </div>
                    <div clas="row">
                        <asp:Button class="btn btn-primary form-control col-md mb-3" ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" />

                    </div>
                    <div class="row">
                        <asp:Button class="btn btn-warning  form-control col-md mb-3" ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
                    </div>
                    <div clas="row">
                        <p class="text-sm col-md">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Forgotten Account Contanct Admin . </p>
                    </div>
                </form>
            </div>
        </div>

        </div>
    </form>
    <script src="Content/bootstrap.bundle.js"></script>
</body>
</html>
