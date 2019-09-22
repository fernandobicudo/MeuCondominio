<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CondominoConsultaListaEleicoes.aspx.cs" Inherits="MeuCondominio1.CondominoConsultaListaEleicoes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Eleições do Condomínio</title>
</head>
<body>
    <h1>Eleições do Condomínio</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnEleicoes" runat="server"></asp:Panel>
        </div>
        <asp:GridView ID="gvEleicoes" runat="server"></asp:GridView>
    </form>
</body>
</html>
