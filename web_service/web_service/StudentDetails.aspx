<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs" Inherits="web_service.StudentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Enter Student ID</h2>
    <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
    <asp:Button ID="btnGetDetails" runat="server" Text="Get Details" OnClick="btnGetDetails_Click" />

    <h3>Student Details</h3>
    <asp:GridView ID="gvStudentDetails" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
