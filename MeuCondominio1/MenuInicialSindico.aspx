<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuInicialSindico.aspx.cs" Inherits="MeuCondominio1.MenuInicialSindico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Menu inicial do Síndico</title>
</head>
<body class="menu">
    <h1>Menu do Síndico</h1>
    <form id="MenuInicialSindico" runat="server">
        <div>
            <div class="header">
                <div class="main">
                    <div class="item">
                        <asp:ImageButton ID="ibConfiguracoes" runat="server" Height="100px" ImageUrl="~/Images/Configuracoes_G.png" Width="100px" /><br/>
                        <asp:Label ID="lbCondifuracoes" runat="server" Text="Configurações"></asp:Label><br/><br/>
                    </div>
                    <div class="item">
                        <asp:ImageButton ID="ibSorteioVagas" runat="server" Height="100px" ImageUrl="~/Images/Carro_G.png" Width="100px" OnClick="IrParaPaginaSorteio" /><br/>
                        <asp:Label ID="lbSorteioVagas" runat="server" Text="Sorteio de Vagas"></asp:Label><br/><br/>
                    </div>
                    <div class="item">
                        <asp:ImageButton ID="ibUsuarios" Height="100px" ImageUrl="~/Images/Usuarios_G.png" Width="100px" runat="server" /><br/>
                        <asp:Label ID="lbUsuarios" runat="server" Text="Usuários"></asp:Label><br/>
                    </div>
                    <div class="item">
                        <asp:ImageButton ID="ibVotacao" runat="server" Height="100px" ImageUrl="~/Images/hand_G.png" Width="100px" OnClick="IrParaPaginaEleicoes" /><br/>
                        <asp:Label ID="lbVotacao" runat="server" Text="Votações" ></asp:Label><br/>
                    </div>
                </div>
            </div>
            <div class="footer">
            </div>
        </div>
    </form>
</body>
</html>
