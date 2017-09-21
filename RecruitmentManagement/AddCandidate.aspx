<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddCandidate.aspx.cs" Inherits="RecruitmentManagement.AddCandidate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
         
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="PAN"></asp:Label> 
            </td>
            <td>
                <asp:TextBox ID="PAN" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="PAN"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="InterviewDate"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="InterviewDate" TextMode="Date" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="InterviewDate"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Levels"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Levels" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Levels"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Status" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Status"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="AddedBy"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="AddedBy" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="AddedBy"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
