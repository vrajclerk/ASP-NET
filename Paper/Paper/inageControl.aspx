<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inageControl.aspx.cs" Inherits="Paper.inageControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        
        .auto-style2 {
            width: 300px;
            height:222px;
        }
        
        .auto-style3 {
            height: 285px;
            width: 393px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <div class="auto-style1">
        <table border="1" class="auto-style2" style="border-style: solid; border-width: medium" >
            <tr>
                <td class="auto-style3">
                    <asp:Image ID="Image1" runat="server" Height="204px" Width="193px" ImageUrl="~/images/0.jpg" />
                </td>
            </tr>
     </table>
        </div>
        <asp:Button ID="Button1" runat="server" BackColor="Lime" ForeColor="Black" OnClick="Button1_Click" Text="Upload" />
        
    </form>
</body>
</html>
