<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuInicialCondomino.aspx.cs" Inherits="MeuCondominio1.MenuInicialCondomino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Menu inicial do Condômino</title>
</head>
<body class="menu">
    <h1>Menu do Condômino</h1>
    <form id="MenuInicialCondomino" runat="server">
        <div>
            <div class="header">
            </div>
            <div class="main">
                <div class="item">
                    <asp:ImageButton ID="ibConfiguracoes" runat="server" Height="100px" ImageUrl="~/Images/Configuracoes_G.png" Width="100px" /><br/>
                    <asp:Label ID="lbConfiguracoes" runat="server" Text="Configurações"></asp:Label><br /><br />
                </div>
                <div class="item">
                    <asp:ImageButton ID="ibVagas" runat="server" Height="100px" ImageUrl="~/Images/Carro_G.png" Width="100px" OnClick="IrParaPaginaVagas"/><br/>
                    <asp:Label ID="lbVagas" runat="server" Text="Vagas"></asp:Label><br /><br />
                </div>
                <div class="item">
                    <asp:ImageButton ID="ibBoleto" runat="server" Height="100px" ImageUrl="~/Images/barcode_G.png" Width="100px"/><br/>
                    <asp:Label ID="lbBoleto" runat="server" Text="Boletos"></asp:Label><br /><br />
                </div>
                <div class="item">
                    <asp:ImageButton ID="ibUsuarios" runat="server" Height="100px" ImageUrl="~/Images/Usuarios_G.png" Width="100px"/><br />
                    <asp:Label ID="lbUsuario" runat="server" Text="Meus Dados"></asp:Label><br /><br /> 
                </div>
            </div>
            <div class="footer">
            </div>
        </div>
    </form>
</body>
</html>
