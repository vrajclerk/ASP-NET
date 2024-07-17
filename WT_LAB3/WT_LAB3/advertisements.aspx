<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advertisements.aspx.cs" Inherits="WT_LAB3.advertisements" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Advertisement</title>
    <style>
        .ad-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            margin: 20px;
        }
        .ad-item {
            margin: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="ad-container">
            <asp:AdRotator ID="AD1" runat="server"  DataSourceID="XmlDataSource1" />
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Advertisement.xml"></asp:XmlDataSource>
        </div>
    </form>
</body> 
</html>
