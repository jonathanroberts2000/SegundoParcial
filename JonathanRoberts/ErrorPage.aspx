<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="JonathanRoberts.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 163px">
    <form id="form1" runat="server">
        <div style="position: center; height: 134px; text-align: center;">
            There was an error. Read the following message and try again.
            <br />
            <br />
            <br />

            <asp:Label ID="Label_Error" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Btn_ErrorRedirection" runat="server" Text="Try again" OnClick="Btn_ErrorRedirection_Click" />
        </div>
    </form>
</body>
</html>
