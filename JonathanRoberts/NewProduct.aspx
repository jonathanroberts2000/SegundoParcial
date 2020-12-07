<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs" Inherits="JonathanRoberts.NewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
            <link href="Content/bootstrap.css" rel="stylesheet" /> 
    </head>
    <body>  
        <form id="form1" runat="server">

<<<<<<< HEAD
        <div>
            <asp:Label ID="Lbl_sku" runat="server" Text="Insert Sku: "></asp:Label>
            <asp:TextBox ID="Txb_sku" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_brand" runat="server" Text="Insert Product Brand: "></asp:Label>
            <asp:TextBox ID="Txb_brand" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_name" runat="server" Text="Insert Name: "></asp:Label>
            <asp:TextBox ID="Txb_name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_price" runat="server" Text="Insert Price: "></asp:Label>
            <asp:TextBox ID="Txb_price" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_enabled" runat="server" Text="Enabled: "></asp:Label>
            <asp:Label ID="Lbl_stateEnabled" runat="server" Text="Enabled"></asp:Label><asp:RadioButton ID="Rdb_enabled" runat="server" GroupName="MyGroup"/>
            <asp:Label ID="Lbl_stateDisabled" runat="server" Text="Disabled"></asp:Label><asp:RadioButton ID="Rdb_disabled" runat="server" GroupName="MyGroup"/>
            <br />
            <asp:Label ID="Lbl_min_quantity" runat="server" Text="Insert Min Quantity: "></asp:Label>
            <asp:TextBox ID="Txb_min_quantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_max_quantity" runat="server" Text="Insert Max Quantity: "></asp:Label>
            <asp:TextBox ID="Txb_max_quantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_product_type" runat="server" Text="Insert Product Type Id: "></asp:Label>
            <asp:TextBox ID="Txb_product_type" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_license" runat="server" Text="Id: 0, Product Type: License"></asp:Label>
            <br />
            <asp:Label ID="Lbl_software" runat="server" Text="Id: 1, Product Type: Software"></asp:Label>
            <br />
            <asp:Label ID="Lbl_hardware" runat="server" Text="Id: 2, Product Type: Hardware"></asp:Label>
            <br />
            <asp:Label ID="Lbl_cloud" runat="server" Text="Id: 3, Product Type: Cloud"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Btn_ConfirmNewProduct" runat="server" Text="Insert New Product" OnClick="Btn_ConfirmNewProduct_Click" />
            <br />
            <br />
            <asp:Button ID="Btn_Cancel" runat="server" Text="Cancel" OnClick="Btn_Cancel_Click" />
        </div>
    </form>
</body>
=======
            <div style="height: 72px; background-color:cornflowerblue" >
                <asp:Label ID="Lbl_UserName" runat="server" Text="" CssClass="font-weight-bold"></asp:Label>
                <br />
                <asp:Label ID="Lbl_UserType" runat="server" Text="" CssClass="font-weight-bold"></asp:Label>
                <br />
                <asp:Label ID="Lbl_UserFullName" runat="server" Text="" CssClass="font-weight-bold"></asp:Label>
            </div>
            <br />
            <div>
                <div class="form-group">
                        <asp:Label ID="Lbl_id" runat="server" Text="Insert Id: "></asp:Label>
                        <asp:TextBox ID="Txb_id" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                </div>
                <div class="form-group">
                        <asp:Label ID="Lbl_sku" runat="server" Text="Insert Sku: "></asp:Label>
                        <asp:TextBox ID="Txb_sku" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                </div>
                <div class="form-group">
                        <asp:Label ID="Lbl_brand" runat="server" Text="Insert Product Brand: "></asp:Label>
                        <asp:TextBox ID="Txb_brand" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                </div>
                <div class="form-group">                 
                        <asp:Label ID="Lbl_name" runat="server" Text="Insert Name: "></asp:Label>
                        <asp:TextBox ID="Txb_name" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                </div>
                <div class="form-group">
                        <asp:Label ID="Lbl_price" runat="server" Text="Insert Price: "></asp:Label>
                        <asp:TextBox ID="Txb_price" runat="server" CssClass="form-control" type ="number"></asp:TextBox>
                        <br />
                </div>
                <div class="form-group">
                        <asp:Label ID="Lbl_enabled" runat="server" Text="Enabled: "></asp:Label>
                        <br /> 
                        <asp:Label ID="Lbl_stateEnabled" runat="server" Text="Enabled"></asp:Label><asp:RadioButton ID="Rdb_enabled" runat="server" GroupName="MyGroup"/>
                        <asp:Label ID="Lbl_stateDisabled" runat="server" Text="Disabled"></asp:Label><asp:RadioButton ID="Rdb_disabled" runat="server" GroupName="MyGroup"/>
               </div>
                <div class="form-group">                 
                        <asp:Label ID="Lbl_min_quantity" runat="server" Text="Insert Min Quantity: "></asp:Label>
                        <asp:TextBox ID="Txb_min_quantity" runat="server" CssClass="form-control" type ="number"></asp:TextBox>
                        <br />
                </div>
                <div class="form-group">
                        <asp:Label ID="Lbl_max_quantity" runat="server" Text="Insert Max Quantity: "></asp:Label>
                        <asp:TextBox ID="Txb_max_quantity" runat="server" CssClass="form-control" type ="number"></asp:TextBox>
                        <br />
                </div>
                <div class="form-group">
                        <asp:Label ID="Lbl_product_type" runat="server" Text="Insert Product Type Id: "></asp:Label>
                        <asp:TextBox ID="Txb_product_type" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Label ID="Lbl_license" runat="server" Text="Id: 0, Product Type: License"></asp:Label>
                        <br />
                        <asp:Label ID="Lbl_software" runat="server" Text="Id: 1, Product Type: Software"></asp:Label>
                        <br />
                        <asp:Label ID="Lbl_hardware" runat="server" Text="Id: 2, Product Type: Hardware"></asp:Label>
                        <br />
                        <asp:Label ID="Lbl_cloud" runat="server" Text="Id: 3, Product Type: Cloud"></asp:Label>
                        <br />
                        <br />
                </div>
                <div class="form-group">
                    <asp:Button ID="Btn_ConfirmNewProduct" CssClass="btn btn-primary" runat="server" Text="Insert New Product" OnClick="Btn_ConfirmNewProduct_Click" />
                    <asp:Button ID="Btn_Cancel" CssClass="btn btn-danger" runat="server" Text="Cancel" OnClick="Btn_Cancel_Click" />
               </div>
            </div>
            
        </form>
    </body>
>>>>>>> origin/branch_bck
</html>
