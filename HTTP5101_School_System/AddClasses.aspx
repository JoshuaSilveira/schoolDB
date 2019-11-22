<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddClasses.aspx.cs" Inherits="HTTP5101_School_System.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
     <asp:Label ID="classidLabel" Text="class id" AssociatedControlID="class_id" runat="server"></asp:Label>
    <asp:TextBox ID="class_id" runat="server"></asp:TextBox>

    <br />

    
    <asp:Label ID="classcodeLabel" Text="Class Code" AssociatedControlID="class_code" runat="server"></asp:Label>
    <asp:TextBox ID="class_code" runat="server"></asp:TextBox>
    

    <br />
    
    <asp:Label ID="teacheridLabel" Text="Teacher id" AssociatedControlID="teacher_id" runat="server"></asp:Label>
    <asp:TextBox ID="teacher_id" runat="server"></asp:TextBox>
    
    <br />

    <asp:Label ID="startdateLabel" Text="Start Date" AssociatedControlID="start_date" runat="server"></asp:Label>
    <asp:TextBox ID="start_date" runat="server"></asp:TextBox>
    
    <br />
    
    <asp:Label ID="finishdateLabel" Text="Finish Date" AssociatedControlID="finish_date" runat="server"></asp:Label>
    <asp:TextBox ID="finish_date" runat="server"></asp:TextBox>

    <br />
    
    <asp:Label ID="classnameLabel" Text="Class name" AssociatedControlID="class_name" runat="server"></asp:Label>
    <asp:TextBox ID="class_name" runat="server"></asp:TextBox>

    <br />

    <asp:Button runat="server" Text="submit"/>

    <a href ="ListClasses.aspx">List classes</a>

</asp:Content>
