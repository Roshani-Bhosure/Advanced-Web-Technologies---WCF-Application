<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumerForm.aspx.cs" Inherits="WCFApplication.ConsumerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter number 1: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/><br/>
        <asp:Label ID="Label2" runat="server" Text="Enter number 2: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/><br/>
        <asp:Label ID="Label3" runat="server" Text="Result: "></asp:Label>&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Sub" OnClick="Button2_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Multiply" OnClick="Button3_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Divide" OnClick="Button4_Click" />
        </div>
    </form>
</body>
</html>
