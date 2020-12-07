<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="JonathanRoberts.MainPage" EnableEventValidation="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" /> 
</head>
<body>
    <form id="form1" runat="server">

        <div style="height: 72px; background-color:cornflowerblue" >
            <asp:Label ID="Lbl_UserName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Lbl_UserType" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Lbl_UserFullName" runat="server" Text=""></asp:Label>
        </div>
        <br />
      
        <asp:DropDownList ID="DropOptionList" runat="server" OnSelectedIndexChanged="DropOptionList_OnChange" AutoPostBack="true" CssClass= "dropdown">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem Value="NewProduct.aspx">Add Product</asp:ListItem>
            <asp:ListItem Value="ordId1">Order By Product Name</asp:ListItem>
            <asp:ListItem Value="ordId2">Order By Product Type</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />
<<<<<<< HEAD
        <br />
        <asp:Label ID="lbl_search_name" runat="server" Text="write product name: "></asp:Label>
        <asp:TextBox ID="Txb_search_name" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_search_sku" runat="server" Text="write product sku: "></asp:Label>
        <asp:TextBox ID="Txb_search_sku" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_search_brand" runat="server" Text="write product brand: "></asp:Label>
        <asp:TextBox ID="Txb_search_brand" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Btn_search" runat="server" Text="Search products" OnClick="Btn_search_Click" />
        <br />
=======

>>>>>>> origin/branch_bck
        <div>
            <asp:GridView ID="GridProducts" OnRowCommand="Grilla_RowCommand" AutoGenerateColumns="false" runat="server" HorizontalAlign="Center"  CssClass="table table-hover">
                <Columns>
<<<<<<< HEAD
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Sku" HeaderText="Sku" />
                    <asp:BoundField DataField="Brand" HeaderText="Brand" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="IsEnabled" HeaderText="Enabled" />
                    <asp:BoundField DataField="MinQuantity" HeaderText="Minimum Quantity" />
                    <asp:BoundField DataField="MaxQuantity" HeaderText="Maximum Quantity" />
                    <asp:BoundField DataField="ProductType" HeaderText="Product Type" />
=======
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Sku" HeaderText="SKU" />
                    <asp:BoundField DataField="Brand" HeaderText="BRAND" />
                    <asp:BoundField DataField="Name" HeaderText="NAME" />
                    <asp:BoundField DataField="Price" HeaderText="PRICE" />
                    <asp:BoundField DataField="IsEnabled" HeaderText="ENABLED" />
                    <asp:BoundField DataField="MinQuantity" HeaderText="MIN QUANTITY" />
                    <asp:BoundField DataField="MaxQuantity" HeaderText="MAX QUANTITY" />
                    <asp:BoundField DataField="ProductType" HeaderText="PRODUCT TYPE" />
>>>>>>> origin/branch_bck

                   <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"  HeaderStyle-Width="70px"  ShowHeader="False" HeaderStyle-BorderStyle="Ridge" ControlStyle-BorderStyle="None" ItemStyle-BorderStyle="None">
                    <ItemTemplate>
                        <asp:ImageButton OnClientClick="return confirm('¿Confirma la eliminación del producto?'); this.disabled = true" 
                         CommandName="DeleteProduct" CommandArgument='<%#Eval("Sku")%>' runat="server" Text="Delete Product" CausesValidation="false"
                            UseSubmitBehavior="false" ImageUrl="img/delete.png"/>
                    </ItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"  HeaderStyle-Width="70px"  ShowHeader="False" HeaderStyle-BorderStyle="Ridge" ControlStyle-BorderStyle="None" ItemStyle-BorderStyle="None">
                    <ItemTemplate>
                        <asp:ImageButton OnClientClick="return confirm('¿Desea modificar el producto?'); this.disabled = true" 
                         CommandName="ModifyProduct" CommandArgument='<%#Eval("Sku")%>' runat="server" Text="Delete Product" CausesValidation="false"
                            UseSubmitBehavior="false" ImageUrl="img/modify.png"/>
                    </ItemTemplate>
                   </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
