<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q2.aspx.cs" Inherits="Sessional2.Q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;Id :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;<br />
            Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;<br />
            Desg :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;<br />
            Dept :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            &nbsp;<br />
            Salary :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Get Emplyee Details" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Average Salary" OnClick="Button5_Click" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="163px" Width="247px">
        </asp:GridView>
    </form>
</body>
</html>
