<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>First Book List</h1>
    <asp:GridView runat="server" ID="bookgrd"></asp:GridView>

        <h1>Second Book List</h1>
        <asp:GridView runat="server" ID="GridView1"></asp:GridView>
        
        <h1>Unique Book List</h1>
        <asp:GridView runat="server" ID="GridView2"></asp:GridView>
    </div>
    </form>
</body>
</html>
