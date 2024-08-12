<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="table.aspx.cs" Inherits="Paper.table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <table style="width: 100%;">
            <tr>
                <td> select rows&nbsp;</td>
                <td><asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>&nbsp;</td>
               
            </tr>
            <tr>
                <td>select cols
                    
                        
                    </td>
                
                <td><asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                 
        </asp:DropDownList>
                    &nbsp;<br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="show table" />
                    <br />
                </td>
                                <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem Text="TextBox" Value="TextBox">TextBox</asp:ListItem>
    <asp:ListItem Text="Hyperlink" Value="Hyperlink"></asp:ListItem>
    <asp:ListItem Text="LinkButton" Value="LinkButton"></asp:ListItem>
</asp:RadioButtonList>
                </td>
           
            </tr>
             <tr>
                <td> your table is here:</td>
                <td>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
               
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
