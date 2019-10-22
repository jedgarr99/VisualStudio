<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="PruebaSessionCookies.Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbUs" runat="server" Text="Usuario: "></asp:Label>
            <asp:TextBox ID="tbUsuario" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbCon" runat="server" Text="Contraseña:  "></asp:Label>
            <asp:TextBox ID="tbContraseña" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btCambio" runat="server" Text="Pagina 2" OnClick="btCambio_Click" />
            <br />
            <asp:Label ID="lbContador" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
