<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="Mukicik2.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Our Products</h1>
    <hr />
    <div>
        <asp:Label runat="server" Text="Category"></asp:Label>
        <asp:DropDownList ID="dropdownCategory" runat="server" OnSelectedIndexChanged="dropdownCategory_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="Button1_Click"/>
    </div>
    <%foreach (var prod in AllProducts)
        {%>
        <div>
            <p><%=prod.ProductName %></p>
            <p><%=prod.Category.CategoryName %></p>
            <p><%=prod.ProductRating %></p>
            <p><%=prod.ProductPrice %></p>
        </div>
    <%} %>
</asp:Content>
