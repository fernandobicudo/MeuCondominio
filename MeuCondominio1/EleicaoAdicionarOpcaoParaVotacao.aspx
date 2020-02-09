<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EleicaoAdicionarOpcaoParaVotacao.aspx.cs" Inherits="MeuCondominio1.EleicaoAdicionarOpcaoParaVotacao" %>

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
    <title></title>
</head>
<body>
    <h1>Adicionar opção de voto</h1>
    <form id="frm" runat="server">
        <div>
            <asp:Label ID="lbDescricaoOpcao" runat="server" Text="Descrição da opção: "></asp:Label>
            <asp:TextBox ID="txDescricaoOpcao" Name="txDescricaoOpcao" runat="server" Width="40%"></asp:TextBox>
            <asp:Button ID="btAdicionarDescricaoOpcao" runat="server" Text="Incluir" CssClass="btn btn-link" OnClick="CriarObjeto" /><br />
            <asp:Button ID="brVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="BtVoltarClick" /><br />
        </div>
    </form>
</body>
</html>
