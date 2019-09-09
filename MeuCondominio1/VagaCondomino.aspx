<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VagaCondomino.aspx.cs" Inherits="MeuCondominio1.VagaCondomino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Suas vagas</title>
    <link rel="stylesheet" href="./css/estilos-global.css" />
</head>
<body>
    <h1>Vagas do Condômino</h1>
    <form id="vagasCondomino" runat="server">
        <div id="conteudoVagas">
            <h2>Suas vagas</h2>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        </div>
        <div id="headerPainelVaga">
            <asp:Panel ID="pnHeaderVaga" runat="server"></asp:Panel>
        </div>
        <div id="numeroVaga">
            <asp:Panel ID="pnNumeroVaga" runat="server"></asp:Panel>
        </div>
        <div id="validadeVaga">
            <asp:Panel ID="pnValidadeVaga" runat="server"></asp:Panel>
        </div>

    </form>
</body>
</html>
