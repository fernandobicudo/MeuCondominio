<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuInicialCondominoMorador.aspx.cs" Inherits="MeuCondominio1.MenuInicialCondomino" %>

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
    
    <title>Menu inicial do Condômino</title>
</head>
<body class="menu">
    <form id="MenuInicialCondomino" runat="server">
        <div>
            <div class="header">
                <h1>Menu do Condômino</h1>
            </div>
            <div class="main">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-xs-6">
                            <asp:ImageButton ID="ibMeuPerfil" runat="server" Height="100px" ImageUrl="~/Images/Usuarios_G.png" Width="100px" OnClick="IrParaPaginaMeuPerfil" /><br />
                            <asp:Label ID="lbMeuPerfil" runat="server" Text="Meu Perfil"></asp:Label>
                        </div>
                        <div class="col-xs-6">
                            <asp:ImageButton ID="ibConfiguracoes" runat="server" Height="100px" ImageUrl="~/Images/Configuracoes_G.png" Width="100px" /><br />
                            <asp:Label ID="lbConfiguracoes" runat="server" Text="Configurações"></asp:Label><br />
                            <br />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-6">
                            <asp:ImageButton ID="ibVagas" runat="server" Height="100px" ImageUrl="~/Images/Carro_G.png" Width="100px" OnClick="IrParaPaginaVagas" /><br />
                            <asp:Label ID="lbVagas" runat="server" Text="Vagas"></asp:Label><br />
                            <br />
                        </div>
                        <div class="col-xs-6">
                            <asp:ImageButton ID="ibBoleto" runat="server" Height="100px" ImageUrl="~/Images/barcode_G.png" Width="100px" /><br />
                            <asp:Label ID="lbBoleto" runat="server" Text="Boletos"></asp:Label><br />
                            <br />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-6">
                            <asp:ImageButton ID="ibUsuarios" runat="server" Height="100px" ImageUrl="~/Images/hand_G.png" Width="100px" OnClick="IrParaPaginaEleicoes" /><br />
                            <asp:Label ID="lbUsuario" runat="server" Text="Votações"></asp:Label><br />
                            <br />
                        </div>
                        <div class="col-xs-6">
                            <asp:ImageButton ID="ibReservaEspacoLazer" runat="server" Height="100px" ImageUrl="~/Images/calendar_G.png" Width="100px" OnClick="IrParaPaginaReservas" /><br />
                            <asp:Label ID="lbReservaEspaco" runat="server" Text="Reservas"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="footer">
                <asp:Button ID="btVoltar" runat="server" Text="Sair" Class="btn btn-primary" OnClick="BtVoltarClick" /><br /> <!--CssClass="botaoDefault botaoHover" -->
            </div>
        </div>
    </form>
</body>
</html>
