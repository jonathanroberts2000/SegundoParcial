<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JonathanRoberts.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Bienvenido</title>
        <link href="Content/bootstrap.css" rel="stylesheet" /> 
    </head>
    <body class="text-center">
        <form id="form1" runat="server">   
            <div class="form-group text-center">
                <div class="input-group" style="margin:auto">

                    <h1 class="h3 mb-3 font-weight-normal">Bienvenido</h1>
 
                    <asp:Label ID="Lbl_userText" runat="server" Text="User Name"  Width="200px" ></asp:Label>
                    <br />

                    <asp:TextBox ID="UserNameTbx" runat="server" BorderStyle="Double"  placeholder="Username" CssClass="form-control"  Width="200px" ></asp:TextBox>
                    <br />
                    <br />
            
                    <asp:Label ID="Lbl_PasswordText" runat="server" Text="Password"  Width="200px" ></asp:Label>
                    <br />

                    <asp:TextBox ID="PasswordTbx" runat="server" BorderStyle="Double" placeholder="Password" TextMode="Password" CssClass="form-control" Width="200px" ></asp:TextBox>
                    <br />
                    <br />

                    <asp:Button ID="LoginButton" runat="server" Text="Login"  OnClick="LoginButton_Click" Width="200px" CssClass="btn btn-primary btn-lg" />               
               
                
                  </div>
              </div>
        </form>  
    </body>
</html>
