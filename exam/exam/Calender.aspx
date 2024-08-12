<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calender.aspx.cs" Inherits="exam.Calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" SelectionMode="DayWeekMonth"></asp:Calendar>
            <asp:Button ID="Button1" runat="server" Text="print week" />
            <asp:Button ID="Button2" runat="server" Text="Date arithmetic" />
        </div>
    </form>
</body>
</html>
