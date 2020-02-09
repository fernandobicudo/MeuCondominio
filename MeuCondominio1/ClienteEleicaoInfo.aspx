<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="ClienteEleicaoInfo.aspx.cs" Inherits="MeuCondominio1.CondominoEleicaoInfo" %>

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

    <title>Informações sobre a votação</title>

</head>
<body>
    <h1>Informações sobre a votação</h1>
    <form id="frmInfoSobreVotacao" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel ID="ipVotacao" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="pnVotacaoInfo" runat="server"></asp:Panel>
                    <br />
                    <asp:Button ID="btVotar" runat="server" Text="Votar" CssClass="btn btn-primary" OnClick="bt_Votar_Click" />
                </ContentTemplate>
            </asp:UpdatePanel><br />
            <asp:Button ID="btVoltar" runat="server" CssClass="btn btn-primary" Text="Voltar" OnClick="BtVoltarClick" /><br />
        </div>
    </form>
</body>
</html>

