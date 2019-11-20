<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="HTTP5101_School_System.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    
    <asp:Label ID="nameLabel" Text="student first name" AssociatedControlID="name" runat="server"></asp:Label>
    <asp:TextBox ID="name" runat="server"></asp:TextBox>

    <br />
    
    <asp:Label ID="lnameLabel" Text="student last name" AssociatedControlID="lname" runat="server"></asp:Label>
    <asp:TextBox ID="lname" runat="server"></asp:TextBox>
    
    <br />

    <asp:Label ID="studentnumberLabel" Text="student number" AssociatedControlID="student_number" runat="server"></asp:Label>
    <asp:TextBox ID="student_number" runat="server"></asp:TextBox>
    
    <br />
    
    <asp:Label ID="enrolldateLabel" Text="Enroll Date" AssociatedControlID="studentenrolldate" runat="server"></asp:Label>
    <asp:TextBox ID="studentenrolldate" runat="server"></asp:TextBox>

    <br />
    
    <asp:Button runat="server" Text="submit"/>

    <a href ="ListStudents.aspx">List Student</a>
</asp:Content>
