<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sueldo.aspx.cs" Inherits="Sueldo.Sueldo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<br />
        Monto de ventas:
        <asp:TextBox ID="tbVentas" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="bCalcular" runat="server" Text="Calcular Sueldo" OnClick="bCalcular_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
 
        </div>
    </form>
</body>
</html>
