<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advertisements.aspx.cs" Inherits="WT_LAB3.advertisements" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Advertisement</title>
    
</head>
<body>
    <form id="form1" runat="server">
 
             <div>
                 
                 <asp:AdRotator ID="AdRotator1" runat="server" Target="_blank" KeywordFilter="Rose" AdvertisementFile="~/Advertisement.xml" />
        </div>
       <%--target property will navigateurl in new browser tab--%>
    </form>
</body> 
</html>
