<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteReservaEspacoLazer.aspx.cs" Inherits="MeuCondominio1.ClienteReservaEspacoLazer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="./css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="./scripts/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="./scripts/bootstrap.min.js"></script>

    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Reserva de Espaço de Lazer</title>
</head>
<body class="cadastro   ">
    <h1>Reserva de Espaço de Lazer</h1>
    <form id="frmReservaEspacoLazer" runat="server">
        <div>
            <asp:Label ID="lbMensagemReserva" runat="server" Text=""></asp:Label>
            <asp:GridView ID="gvReservas" runat="server" AutoGenerateColumns="false" CssClass="table-responsive table-hover centro">
                <Columns>
                    <asp:BoundField DataField="nomeEspacoLazer" HeaderText="Local" />
                    <asp:BoundField DataField="dtInicioReserva" HeaderText="Início da Reserva" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="dtFimReserva" HeaderText="Término da Reserva" DataFormatString="{0:d}" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btNovaReserva" runat="server" Text="Nova reserva" CssClass="btn btn-primary" OnClick="Bt_NovaReserva" /><br />
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="BtVoltarClick" /><br />
        </div>
    </form>
</body>
</html>
