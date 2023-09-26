<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Mukicik2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Mukicik</h1>
    <p>An innovative music selling store with competitive prices</p>
    <p>It's never this cheap to shop in music!</p>
    <br />
    <%if(Session["user"] == null){ %>
        <asp:Button ID="btnRegister" runat="server" Text="Be a new member" />
    <%} %>
    <hr />
    <h1>Top products</h1>
    <%for (int i = 0; i < 6 && i < topProducts.Count(); i++)
        {  %>
    <div>
        <p><%=topProducts[i].ProductName %></p>
        <p><%=topProducts[i].ProductRating %></p>
        <p><%=topProducts[i].ProductPrice %></p>
    </div>
    <%} %>

</asp:Content>
