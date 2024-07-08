<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calc_command.aspx.cs" Inherits="WT_LAB2.calc_command" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" CommandArgument="+" OnCommand="Button1_command" Text="ADD" />
            <asp:Button ID="Button2" runat="server" CommandArgument="-" OnCommand="Button1_command" Text="SUB" />
            <asp:Button ID="Button3" runat="server" CommandArgument="*" OnCommand="Button1_command" Text="MUL" />
            <asp:Button ID="Button4" runat="server" CommandArgument="/" OnCommand="Button1_command" Text="DIV" />
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-top: 0px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
