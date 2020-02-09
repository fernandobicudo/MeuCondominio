<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SindicoSubMenuConfiguracoes.aspx.cs" Inherits="MeuCondominio1.SindicoSubMenuConfiguracoes" %>

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
    <title>Configurações</title>
</head>
<body class="menu">
    <h1>Configurações</h1>
    <form id="frmConfiguracoes" runat="server">
        <div>
            <div class="header">
                <div class="main">
                    <div class="item">
                        <asp:ImageButton ID="ibEspacoLazer" runat="server" Height="100px" ImageUrl="~/Images/Configuracoes_G.png" Width="100px" OnClick="IrParaPaginaCadastrarEspacoReserva" /><br />
                        <asp:Label ID="lbEspacoLazer" runat="server" Text="Cadastrar Espaço de Lazer"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <div class="footer">
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="BtVoltarClick" /><br />
        </div>
    </form>
</body>
</html>
