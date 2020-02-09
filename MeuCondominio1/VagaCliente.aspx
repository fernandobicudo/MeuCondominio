<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VagaCliente.aspx.cs" Inherits="MeuCondominio1.VagaCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Suas vagas</title>
        <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="./css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="./scripts/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="./scripts/bootstrap.min.js"></script>

    <link rel="stylesheet" href="./css/estilos-global.css" />
</head>
<body>
    <h1>Vagas do Condômino</h1>
    <form id="vagasCondomino" runat="server">
        <div id="conteudoVagas">
            <h3>Suas vagas</h3>
            <!--<asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>-->
        </div>
        <div id="headerPainelVaga">
            <asp:Panel ID="pnHeaderVaga" runat="server"></asp:Panel>
        </div>
        <div id="numeroVaga">
            <asp:Panel ID="pnTituloNumeroVaga" runat="server"></asp:Panel>
            <br />
            <br />
            <asp:Panel ID="pnNumeroVaga" runat="server"></asp:Panel>
            <br />
            <br />
        </div>
        <div id="validadeVaga">
            <asp:Panel ID="pnValidadeVaga" runat="server"></asp:Panel>
        </div>
        <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="BtVoltarClick"/>
    </form>
</body>
</html>
