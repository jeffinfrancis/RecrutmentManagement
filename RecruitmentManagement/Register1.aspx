<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register1.aspx.cs" Inherits="RecruitmentManagement.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
   <div class="col-md-8">
           <h4>Register </h4>
             <asp:Label ID="Label1" runat="server" Text="Name "></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email "></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="UserName "></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
            <br />
             <asp:Label ID="Label4" runat="server" Text="Password "></asp:Label>
             <br />
             <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
              <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
             <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
            <br />
</asp:Content>
