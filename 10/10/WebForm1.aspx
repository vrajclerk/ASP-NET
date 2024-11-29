<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <div>
            <label for="txtStudentId">Enter Student ID:</label>
            <asp:TextBox ID="txtStudentId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFetch" runat="server" Text="Fetch Details" OnClick="btnFetch_Click" />
        </div>
        <asp:GridView ID="gvStudentDetails" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </form>
</body>
</html>
