<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewData.aspx.cs" Inherits="Statistics.NewData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton Text="Search" ID="searchButton" runat="server" PostBackUrl="~/Search.aspx" />
        <br />
        <br />
        <asp:Label Text="Country:" runat="server" />
        <br />
        <asp:TextBox id="countryTxt" runat="server" />  
        <br />
        <br />
        <asp:Label Text="Capital:" runat="server" />
        <br />
        <asp:TextBox id="capitalTxt" runat="server" />
        <br />
        <br />
        <asp:Label Text="Population:" runat="server" />
        <br />
        <asp:TextBox id="populationTxt" runat="server" TextMode="Number" />
        <br />
        <asp:Button Text="Import" ID="buttonImport" runat="server" OnClick="buttonImport_Click" />
        <br />
        <asp:Label Text="" runat="server" ID="exeption" />

    </div>
    </form>
</body>
</html>
