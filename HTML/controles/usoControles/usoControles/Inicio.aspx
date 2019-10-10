<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="usoControles.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <font face="Comic Sans MS" size="10" color="red"> <b>Uso Controles</b></font><br />
            
            <br />
            <font face="Comic Sans MS" size="6" color="blue"> Colores&nbsp;&nbsp;&nbsp;</font>
            <asp:DropDownList ID="ddColores" runat="server" AutoPostBack="True" BackColor="Black" ForeColor="Yellow" Height="25px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="98px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lbColores" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <font face="Comic Sans MS" size="6" color="magenta">Sabores:<br /></font>
            <asp:RadioButtonList ID="rbSabores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbSabores_SelectedIndexChanged">
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="lbIndiceS" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbContenidoS" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <font face="Comic Sans MS" size="6" color="green">Cafe<br /></font>
            <asp:CheckBoxList ID="cbCafe" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbCafe_SelectedIndexChanged">
            </asp:CheckBoxList>
            <br />
            <font face="Comic Sans MS" size="6" color="purple">Contenido&nbsp;&nbsp;&nbsp;</font>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="55px" Width="88px"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server" Height="55px" Width="135px"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lbSession" runat="server" Text=""></asp:Label>
            <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
