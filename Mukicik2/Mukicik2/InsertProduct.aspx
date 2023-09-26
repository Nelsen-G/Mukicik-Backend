<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="Mukicik2.InsertProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert New Product</h1>
    <hr />
    <div>
        <asp:Label ID="lblName" runat="server" Text="Product Name"></asp:Label>
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Product Name!" ControlToValidate="tbName"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblPrice" runat="server" Text="Product Price"></asp:Label>
        <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Product Price!" ControlToValidate="tbPrice"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblImage" runat="server" Text="Product Image"></asp:Label>
        <asp:TextBox ID="tbImage" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Product Image!" ControlToValidate="tbImage"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblRating" runat="server" Text="Product Rating"></asp:Label>
        <asp:TextBox ID="tbRating" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Product Rating!" ControlToValidate="tbRating"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Rating must be between 0 and 5!" MaximumValue="5" MinimumValue="0" ControlToValidate="tbRating"></asp:RangeValidator>
    </div>
    <div>
        <asp:Label ID="lblCategory" runat="server" Text="Product Category"></asp:Label>
        <asp:DropDownList ID="dropdownCategory" runat="server"></asp:DropDownList>
    </div>
    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
</asp:Content>
