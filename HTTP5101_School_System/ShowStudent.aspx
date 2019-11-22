<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowStudent.aspx.cs" Inherits="HTTP5101_School_System.ShowStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
     <div id="student" runat="server">
        <h2>Details for <span id="student_title_fname" runat="server"></span></h2>
        First Name: <span id="student_fname" runat="server"></span><br />
        Last Name: <span id="student_lname" runat="server"></span><br />
        Student Number: <span id="student_number" runat="server"></span><br />
        Enrolment Date: <span id="enrolment_date" runat="server"></span><br /> 
        <asp:Button runat="server" id="deleteStudent" Text="Remove This Student" OnClick="deleteStudent_Click" />
        
        <br />
        <asp:Label ID="updatefnamelabel" Text="First Name" AssociatedControlID="update_student_first_name" runat="server"></asp:Label>
        <asp:TextBox ID="update_student_first_name" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="updatelnamelabel" Text="Last Name" AssociatedControlID="update_student_last_name" runat="server"></asp:Label>
        <asp:TextBox ID="update_student_last_name" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="studentnumlabel" Text="Student Number" AssociatedControlID="update_student_num" runat="server"></asp:Label>
        <asp:TextBox ID="update_student_num" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="updateenrolllabel" Text="Enrollment Date" AssociatedControlID="update_enrollment_date" runat="server"></asp:Label>
        <asp:TextBox ID="update_enrollment_date" runat="server"></asp:TextBox>
        <asp:Button runat="server" id="updateStudent" Text="Update This Student" OnClick="updateStudent_Click" />


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
