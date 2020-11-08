<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JonathanRoberts.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bienvenido</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">Bienvenido</div>
        <div style="height: 161px">
            <asp:Label ID="Lbl_userText" runat="server" Text="User Name"></asp:Label>
            <br />

            <asp:TextBox ID="UserNameTbx" runat="server" BorderStyle="Double"></asp:TextBox>
            <br />
            <br />
            
            <asp:Label ID="Lbl_PasswordText" runat="server" Text="Password"></asp:Label>
            <br />

            <asp:TextBox ID="PasswordTbx" runat="server" BorderStyle="Double" TextMode="Password"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="LoginButton" runat="server" Text="Login" Height="27px" OnClick="LoginButton_Click" Width="129px" />
        </div>
    </form>
</body>
</html>
