<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowClass.aspx.cs" Inherits="HTTP5101_School_System.ShowClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
        <div id="course" runat="server">
            <h2>Details for <span id="class_name" runat="server"></span></h2>
            Class Code: <span id="class_code" runat="server"></span><br />
            Teacher Id: <span id="teacher_id" runat="server"></span><br />
            Start Date: <span id="start_date" runat="server"></span><br />
            Finish: <span id="finish_date" runat="server"></span><br />
            
            <asp:Button runat="server" id="deleteClass" Text="Remove This Class" OnClick="deleteClass_Click" />

        </div>

</asp:Content>
