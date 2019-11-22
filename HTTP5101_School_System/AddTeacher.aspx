<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddTeacher.aspx.cs" Inherits="HTTP5101_School_System.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div class="formbody">
    <div class="formfield">
    <h1>Add a Teacher</h1>
    <asp:Label ID="teacheridLabel" Text="Teacher ID" AssociatedControlID="teacher_id" runat="server"></asp:Label>
    <asp:TextBox ID="teacher_id" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="nameLabel" Text="Teacher First Name" AssociatedControlID="name" runat="server"></asp:Label>
    <asp:TextBox ID="name" runat="server"></asp:TextBox>

    <br />
    
    <asp:Label ID="lnameLabel" Text="Teacher Last Name" AssociatedControlID="lname" runat="server"></asp:Label>
    <asp:TextBox ID="lname" runat="server"></asp:TextBox>
    
    <br />

    <asp:Label ID="employeenumberLabel" Text="Employee Number" AssociatedControlID="teacher_employeenumber" runat="server"></asp:Label>
    <asp:TextBox ID="teacher_employeenumber" runat="server"></asp:TextBox>
    
    <br />
    
    <asp:Label ID="hiredateLabel" Text="Hire Date" AssociatedControlID="teacher_hiredate" runat="server"></asp:Label>
    <asp:TextBox ID="teacher_hiredate" runat="server"></asp:TextBox>

    <br />
    
    <asp:Label ID="salaryLabel" Text="Salary" AssociatedControlID="teacher_salary" runat="server"></asp:Label>
    <asp:TextBox ID="teacher_salary" runat="server"></asp:TextBox>

    <br />

    <asp:Button runat="server" Text="Submit"/>
    </div>
    </div>
</asp:Content>
