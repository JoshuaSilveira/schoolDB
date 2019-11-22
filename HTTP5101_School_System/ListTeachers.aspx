<%@Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Layout.Master"  CodeBehind="ListTeachers.aspx.cs" Inherits="HTTP5101_School_System.WebForm1" %>

<asp:Content ID="teachers_list" ContentPlaceHolderID="body" runat="server">
    <h1>Teachers</h1>
    <div><asp:TextBox ID="search" runat="server"></asp:TextBox>
        <asp:Button runat="server" Text="Search"/></div>
    <div class="_table" runat="server">
        
            <div class="listitem">
                <div class="col5">FIRST NAME</div>
                <div class="col5">LAST NAME</div>
                <div class="col5">EMPLOYEE NUMBER</div>
                <div class="col5">HIRED DATE</div>
                <div class="col5last">SALARY</div>
            </div>
        <div id="teachers_result" runat="server"></div>
        
        </div>
</asp:Content>
