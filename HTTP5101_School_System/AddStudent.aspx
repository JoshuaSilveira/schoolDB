<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="HTTP5101_School_System.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div class="formbody">
    <div class="formfield">
    <h1>Add A Student</h1>
    <asp:Label ID="nameLabel" Text="Student First Name" AssociatedControlID="name" runat="server" ></asp:Label>
    <asp:TextBox ID="name" runat="server"></asp:TextBox>

    <br />
    
    <asp:Label ID="lnameLabel" Text="Student Last Name" AssociatedControlID="lname" runat="server" ></asp:Label>
    <asp:TextBox ID="lname" runat="server"></asp:TextBox>
    
    <br />

    <asp:Label ID="studentnumberLabel" Text="Student Number" AssociatedControlID="student_number" runat="server" ></asp:Label>
    <asp:TextBox ID="student_number" runat="server"></asp:TextBox>
    
    <br />
    
    <asp:Label ID="enrolldateLabel" Text="Enroll Date" AssociatedControlID="studentenrolldate" runat="server" ></asp:Label>
    <asp:TextBox ID="studentenrolldate" runat="server"></asp:TextBox>

    <br />
    
    <asp:Button runat="server" Text="Submit"/>
    </div>
   </div>
</asp:Content>
