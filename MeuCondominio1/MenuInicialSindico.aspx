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
                        <asp:ImageButton ID="ibConfiguracoes" runat="server" Height="100px" ImageUrl="~/Images/Configuracoes_G.png" Width="100px" />
                        <asp:Label ID="lbCondifuracoes" runat="server" Text="Configurações"></asp:Label>
                    </div>
                    <div class="item">
                        <asp:ImageButton ID="ibSorteioVagas" runat="server" Height="100px" ImageUrl="~/Images/Carro_G.png" Width="100px" OnClick="IrParaPaginaSorteio"/>
                        <asp:Label ID="lbSorteioVagas" runat="server" Text="Sorteio de Vagas"></asp:Label>
                    </div>
                    <div class="item">
                        <asp:ImageButton ID="ImageButton3" runat="server" />
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="footer">

            </div>
        </div>
    </form>
</body>
</html>
