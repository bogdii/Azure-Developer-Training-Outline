<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01NewASPWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

        <h1>Welcome to My ASP.NET Web Application</h1>
        <p>This is a simple web application built using ASP.NET.</p>

        <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>

        <br />
        <asp:Button ID="btnCalculate" OnClick="btnCalculate_Click" runat="server" Text="Calculate" />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
