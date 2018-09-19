<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppAhorcadoCliente.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPalabraNueva" runat="server" Visible="False"></asp:Label>
            <asp:Button ID="btnPalabraNueva" runat="server" Text="Nueva Palabra" OnClick="btnPalabraNueva_Click" />
            <asp:Label ID="Label1" runat="server" Text="Intentos Restantes: "></asp:Label>
            <asp:Label ID="lblVidas" runat="server" Text="7"></asp:Label>
            <br />
            <asp:Label ID="lblPalabraNuevaGuion" runat="server" Font-Bold="False" Font-Size="XX-Large" ForeColor="#0000CC"></asp:Label>
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
        <p>
            <asp:Image ID="Image1" runat="server" Height="210px" ImageUrl="~/Sources/images/hang7.jpg" Width="279px" />
        </p>
        <p>
            <asp:Button ID="btnA" runat="server" OnClick="btn_Click" Text="A" Width="23px" />
            <asp:Button ID="btnB" runat="server" OnClick="btn_Click" Text="B" />
            <asp:Button ID="btnC" runat="server" OnClick="btn_Click" Text="C" />
            <asp:Button ID="btnD" runat="server" Text="D" OnClick="btn_Click" />
            <asp:Button ID="btnE" runat="server" OnClick="btn_Click" Text="E" Width="23px" />
            <asp:Button ID="btnF" runat="server" Text="F" OnClick="btn_Click" />
            <asp:Button ID="btnG" runat="server" Text="G" OnClick="btn_Click" />
            <asp:Button ID="btnH" runat="server" Text="H" OnClick="btn_Click" />
            <asp:Button ID="btnI" runat="server" Text="I" OnClick="btn_Click" />
            <asp:Button ID="btnJ" runat="server" Text="J" OnClick="btn_Click" />
            <asp:Button ID="btnK" runat="server" Text="K" OnClick="btn_Click" />
            <asp:Button ID="btnL" runat="server" Text="L" OnClick="btn_Click" />
            <asp:Button ID="btnM" runat="server" OnClick="btn_Click" Text="M" Width="25px" />
            <asp:Button ID="btnN" runat="server" Text="N" OnClick="btn_Click" />
        </p>
        <p>
            <asp:Button ID="btnO" runat="server" Text="O" OnClick="btn_Click" />
            <asp:Button ID="btnP" runat="server" Text="P" OnClick="btn_Click" />
            <asp:Button ID="btnQ" runat="server" Text="Q" OnClick="btn_Click" />
            <asp:Button ID="btnR" runat="server" Text="R" OnClick="btn_Click" />
            <asp:Button ID="btnS" runat="server" OnClick="btn_Click" Text="S" Width="24px" />
            <asp:Button ID="btnT" runat="server" Text="T" OnClick="btn_Click" />
            <asp:Button ID="btnU" runat="server" Text="U" OnClick="btn_Click" />
            <asp:Button ID="btnV" runat="server" Text="V" OnClick="btn_Click" />
            <asp:Button ID="btnW" runat="server" Text="W" OnClick="btn_Click" />
            <asp:Button ID="btnX" runat="server" Text="X" OnClick="btn_Click" />
            <asp:Button ID="btnY" runat="server" Text="Y" OnClick="btn_Click" />
            <asp:Button ID="btnZ" runat="server" Text="Z" OnClick="btn_Click" />
        </p>
    </form>
</body>
</html>
