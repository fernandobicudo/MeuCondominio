<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="CondominoEleicaoInfo.aspx.cs" Inherits="MeuCondominio1.CondominoEleicaoInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />

    <title>Informações sobre a votação</title>

</head>
<body>

    <h1>Informações sobre a votação</h1>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel ID="ipVotacao" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="pnVotacaoInfo" runat="server"></asp:Panel>
                    <br />
                    <asp:Button ID="btVotar" runat="server" Text="Votar" OnClick="bt_Votar_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>

