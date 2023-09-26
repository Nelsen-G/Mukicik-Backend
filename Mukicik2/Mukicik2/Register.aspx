<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Mukicik2.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Register</h1>
    <hr />
    <div>
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="tbEmail" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter your email" ControlToValidate="tbEmail"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter your name" ControlToValidate="tbName"></asp:RequiredFieldValidator>

    </div>
    <div>
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter your password" ControlToValidate="tbPassword"></asp:RequiredFieldValidator>

    </div>
    <div>
        <asp:Label ID="lblConfPassword" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="tbConfPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter confirm password" ControlToValidate="tbConfPassword"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Enter the same password" ControlToCompare="tbPassword" ControlToValidate="tbConfPassword"></asp:CompareValidator>
    </div>
    <div>
        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <div>
        <asp:Label ID="lblDOB" runat="server" Text="Date Of Birth"></asp:Label>
        <asp:Calendar ID="calendarDOB" runat="server" OnSelectionChanged="calendarDOB_SelectionChanged"></asp:Calendar>
        <asp:TextBox ID="tbDOB" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Choose DOB!" ControlToValidate="tbDOB"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblProfile" runat="server" Text="Profile Picture"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </div>
    <div>
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="I agree to tnc"></asp:Label >
    </div>
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label> 
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

</asp:Content>