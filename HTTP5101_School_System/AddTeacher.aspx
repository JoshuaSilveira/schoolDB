<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddTeacher.aspx.cs" Inherits="HTTP5101_School_System.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <asp:TextBox ID="teacher_id" runat="server"></asp:TextBox>
    <asp:TextBox ID="name" runat="server"></asp:TextBox>
    <asp:TextBox ID="lname" runat="server"></asp:TextBox>
    <asp:TextBox ID="teacher_employeenumber" runat="server"></asp:TextBox>
    <asp:TextBox ID="teacher_hiredate" runat="server"></asp:TextBox>
    <asp:TextBox ID="teacher_salary" runat="server"></asp:TextBox>
    <asp:Button runat="server" Text="submit"/>
</asp:Content>
