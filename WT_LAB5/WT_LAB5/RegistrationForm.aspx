<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="WT_LAB5.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             ID:
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <br />
             <br />
             Name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Mobile No. : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Email:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            Country:
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            State: <asp:DropDownList ID="DropDownList2" runat="server" CausesValidation="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            City:
            <asp:DropDownList ID="DropDownList3" runat="server"  AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            Certificate: <asp:CheckBoxList ID="CheckBoxList1" runat="server"  AutoPostBack="True">
                <asp:ListItem>GRE</asp:ListItem>
                <asp:ListItem>IELTS</asp:ListItem>
                <asp:ListItem>GATE</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            Gender:
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
