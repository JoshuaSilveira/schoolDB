﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowStudent.aspx.cs" Inherits="HTTP5101_School_System.ShowStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
     <div id="student" runat="server">
        <h2>Details for <span id="student_title_fname" runat="server"></span></h2>
        First Name: <span id="student_fname" runat="server"></span><br />
        Last Name: <span id="student_lname" runat="server"></span><br />
        Student Number: <span id="student_number" runat="server"></span><br />
        Enrolment Date: <span id="enrolment_date" runat="server"></span><br /> 
        <asp:Button runat="server" id="deleteStudent" Text="Remove This Student" OnClick="deleteStudent_Click" />
    </div>
   
</asp:Content>
