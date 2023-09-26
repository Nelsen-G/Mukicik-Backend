<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="UpdateDeleteProduct.aspx.cs" Inherits="Mukicik2.UpdateDeleteProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Modify Products</h1>
    <hr />
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" OnRowDeleting="GridView1_RowDeleting" >
        <Columns>
            <asp:CommandField ButtonType="Button" HeaderText="Select" ShowHeader="True" ShowSelectButton="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
    <div>
        <asp:Label ID="lblID" runat="server" Text="Product ID"></asp:Label>
        <asp:TextBox ID="tbID" runat="server" Enabled="false"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblName" runat="server" Text="Product Name"></asp:Label>
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblPrice" runat="server" Text="Product Price"></asp:Label>
        <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblImage" runat="server" Text="Product Image"></asp:Label>
        <asp:TextBox ID="tbImage" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblRating" runat="server" Text="Product Rating"></asp:Label>
        <asp:TextBox ID="tbRating" runat="server"></asp:TextBox>
    </div>
    <asp:DropDownList ID="dropdownCategory" runat="server"></asp:DropDownList>
    <<asp:Button ID="btnUpdate" runat="server" Text="Update Data" OnClick="btnUpdate_Click" />
</asp:Content>
