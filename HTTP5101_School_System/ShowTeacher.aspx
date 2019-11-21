<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowTeacher.aspx.cs" Inherits="HTTP5101_School_System.ShowTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="teacher" runat="server">
        <h2>Details for <span id="teacher_title_fname" runat="server"></span></h2>
        First Name: <span id="teacher_fname" runat="server"></span><br />
        Last Name: <span id="teacher_lname" runat="server"></span><br />
        Student Number: <span id="employee_number" runat="server"></span><br />
        Salary: <span id="teacher_salary" runat="server"></span><br />
        Enrolment Date: <span id="hire_date" runat="server"></span><br />

        <asp:Button runat="server" id="deleteteacher" Text="Remove This Teacher" OnClick="deleteTeacher_Click" />

        <div id="classes_result" class="_table" runat="server">
        
            <div class="listitem">
                <div class="col4">CLASS CODE</div>
                <div class="col4">START DATE</div>
                <div class="col4">FINISH DATE</div>
                <div class="col4last">CLASSNAME</div>
            </div>
    </div>
    </div>

</asp:Content>
