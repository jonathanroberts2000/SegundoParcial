<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="JonathanRoberts.MainPage" EnableEventValidation="true" %>

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
        <asp:DropDownList ID="DropOptionList" runat="server" OnSelectedIndexChanged="DropOptionList_OnChange" AutoPostBack="true">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem Value="NewProduct.aspx">Add Product</asp:ListItem>
            <asp:ListItem Value="ModifyProduct.aspx">Modify Product</asp:ListItem>
            <asp:ListItem Value="DeleteProduct.aspx">Delete Product</asp:ListItem>
            <asp:ListItem Value="ordId1">Order By Product Name</asp:ListItem>
            <asp:ListItem Value="ordId2">Order By Product Type</asp:ListItem>
        </asp:DropDownList>
        <br />
        <div>
            <%--<asp:GridView ID="GridProducts" runat="server" HorizontalAlign="Center" Width="631px" Height="158px"></asp:GridView>--%>
            <asp:GridView ID="GridProducts" OnRowCommand="Grilla_RowCommand" AutoGenerateColumns="false" runat="server" HorizontalAlign="Center" >
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="id" />
                    <asp:BoundField DataField="Sku" HeaderText="sku" />
                    <asp:BoundField DataField="Brand" HeaderText="brand" />
                    <asp:BoundField DataField="Name" HeaderText="name" />
                    <asp:BoundField DataField="Price" HeaderText="price" />
                    <asp:BoundField DataField="IsEnabled" HeaderText="enabled" />
                    <asp:BoundField DataField="MinQuantity" HeaderText="minQuantity" />
                    <asp:BoundField DataField="MaxQuantity" HeaderText="maxQuantity" />
                    <asp:BoundField DataField="ProductType" HeaderText="productType" />

                   <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"  HeaderStyle-Width="70px"  ShowHeader="False" HeaderStyle-BorderStyle="None" ControlStyle-BorderStyle="None" ItemStyle-BorderStyle="None">
                    <ItemTemplate>
                        <asp:ImageButton OnClientClick="return confirm('¿Confirma la eliminación del item?'); this.disabled = true" 
                         CommandName="DeleteProduct" CommandArgument='<%#Eval("Sku")%>' runat="server" Text="Delete Product" CausesValidation="false"
                            UseSubmitBehavior="false"/>
                    </ItemTemplate>
                   </asp:TemplateField>
                </Columns>
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
