<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Statistics.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton Text="NewData" ID="searchButton" runat="server" PostBackUrl="~/NewData.aspx" />
            <br />
            <br />
            <asp:DropDownList runat="server" ID="dropDown">
                <asp:ListItem Text="Search..." />
                <asp:ListItem Text="Country" />
                <asp:ListItem Text="Capital" />
                <asp:ListItem Text="Population" />
            </asp:DropDownList>
            <asp:Button Text="Search" runat="server" ID="buttonSearch" OnClick="buttonSearch_Click" />
            <br />
            <br />
            <asp:TextBox id="result" runat="server" />  
            <br />
            <br />
            <asp:Label Text="" ID="labelResult" runat="server" />
        </div>
    </form>
</body>
</html>
