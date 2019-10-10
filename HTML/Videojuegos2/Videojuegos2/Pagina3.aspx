<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina3.aspx.cs" Inherits="Videojuegos2.Pagina3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
        Criticas del usuario :
        <asp:Label ID="lbUsuario" runat="server"></asp:Label>
        <br />
        <br />
        Selecciona el juego para saber su crítica:<br />
        <br />
    
        juegos:
        <asp:DropDownList ID="ddJuegos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddJuegos_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        Critica:<br />
        <br />
        <asp:Label ID="lbCritica" runat="server"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ir a juegos" />
        <br />
        <br />
        <asp:Label ID="lbError" runat="server"></asp:Label>


        </div>
    </form>
</body>
</html>
