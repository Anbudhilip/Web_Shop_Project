<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <h3><asp:Label ID="errorMsg" CssClass="text-danger" runat="server" ></asp:Label></h3> 
        <div class="container-md mt-4  ">
            <div class="row">
                <div class="h1 text-center text-primary ">Login</div>
            </div>
            <div class="container  card col-md-4 mb-3">
                <form>
                     
                    <div clas="row">

                        <p class=" col-md my-4" style="text-align: center;">Admin Login</p>
                    </div>
                    <div clas="row">
                        <asp:TextBox ID="txt_email" class="form-control  mb-3 col-md" Autocomplete="off" Required="true" placeholder="user name" runat="server"></asp:TextBox>
                    </div>
                    <div clas="row">
                        <asp:TextBox ID="txt_pwd" class="form-control mb-3 col-md"  Autocomplete="off" Required="true" placeholder="Password" runat="server" AutoCompleteType="Search" TextMode="Password"></asp:TextBox>

                    </div>
                    
                    <div clas="row">
                        <asp:Button class="btn btn-primary form-control col-md mb-3" ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" />

                    </div>
                    <div class="row">
                        <asp:Button class="btn btn-warning  form-control col-md mb-3" ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
                    </div>
                    <div clas="row">
                        <p class="text-sm col-md text-center">Forgotten Account Contanct Admin . </p>
                    </div>
                </form>
            </div>
        </div>

    </form>

</body>
</html>
