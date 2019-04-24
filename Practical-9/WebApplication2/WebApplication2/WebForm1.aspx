<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtA" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtB" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnPlus" runat="server" Text="+" onclick="btnPlus_Click" />
        <asp:Button ID="btnSub" runat="server" Text="-" onclick="btnSub_Click" />
        <asp:Button ID="btnMul" runat="server" Text="*" onclick="btnMul_Click" />
        <asp:Button ID="btnDiv" runat="server" Text="/" onclick="btnDiv_Click" /><br />
        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
    </div>
    </form>
</body>
</html>
