<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NextPage.aspx.cs" Inherits="SecurityProject.NextPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Your Code"></asp:Label>
        <asp:TextBox ID="codeText" runat="server"></asp:TextBox>
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="#FF3300"></asp:Label>
    </form>
</body>
</html>
