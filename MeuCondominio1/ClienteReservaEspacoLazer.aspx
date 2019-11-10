<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteReservaEspacoLazer.aspx.cs" Inherits="MeuCondominio1.ClienteReservaEspacoLazer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Reserva de Espaço de Lazer</title>
</head>
<body class="cadastro   ">
    <h1>Reserva de Espaço de Lazer</h1>
    <form id="frmReservaEspacoLazer" runat="server">
        <div>
            <asp:Label ID="lbMensagemReserva" runat="server" Text=""></asp:Label>
            <asp:Button ID="btNovaReserva" runat="server" Text="Nova reserva" CssClass="botaoDefault" OnClick="Bt_NovaReserva"/>
        </div>
    </form>
</body>
</html>
