<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="Videojuegos2.Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Control de acceso a la clase DAI<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
        :
        <asp:TextBox ID="txContraseña" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btPagina2" runat="server" OnClick="btPagina2_Click" Text="ir a la página 2" />
        <br />
        <br />
        <asp:Label ID="lbContador" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
