﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyProduct.aspx.cs" Inherits="JonathanRoberts.ModifyProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 52px; background-color:cornflowerblue">
            <asp:Label ID="Lbl_UserName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Lbl_UserType" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Lbl_UserFullName" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />
        <div>
            <asp:Label ID="Lbl_id" runat="server" Text="Id: "></asp:Label>
            <br />
            <asp:Label ID="Lbl_sku" runat="server" Text="Sku: "></asp:Label>
            <br />
            <asp:Label ID="Lbl_brand" runat="server" Text="Insert New Product Brand: "></asp:Label>
            <asp:TextBox ID="Txb_brand" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_name" runat="server" Text="Insert New Name: "></asp:Label>
            <asp:TextBox ID="Txb_name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_price" runat="server" Text="Insert New Price: "></asp:Label>
            <asp:TextBox ID="Txb_price" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_enabled" runat="server" Text="Enabled New Status: "></asp:Label>
            <br />
            <asp:Label ID="Lbl_stateEnabled" runat="server" Text="Enabled"></asp:Label><asp:RadioButton ID="Rdb_enabled" runat="server" GroupName="MyGroup"/>
            <asp:Label ID="Lbl_stateDisabled" runat="server" Text="Disabled"></asp:Label><asp:RadioButton ID="Rdb_disabled" runat="server" GroupName="MyGroup"/>
            <br />
            <asp:Label ID="Lbl_min_quantity" runat="server" Text="Insert New Min Quantity: "></asp:Label>
            <asp:TextBox ID="Txb_min_quantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_max_quantity" runat="server" Text="Insert New Max Quantity: "></asp:Label>
            <asp:TextBox ID="Txb_max_quantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_product_type" runat="server" Text="Product Type: "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Btn_SaveChanges" runat="server" Text="Save Changes" OnClick="Btn_SaveChanges_Click" />
        </div>
    </form>
</body>
</html>
