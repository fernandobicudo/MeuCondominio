<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SindicoCadastroEspacoLazer.aspx.cs" Inherits="MeuCondominio1.SindicoCadastroEspacoLazer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Cadastro de espaços de lazer</title>
</head>
<body class="cadastro">
    <h1>Cadastro de Espaço de Lazer</h1>
    <form id="frmCadastroEspacoLazer" runat="server">
        <div>
            <asp:Label ID="lbNomeEspaco" runat="server" Text="Nome do espaço" CssClass="label"></asp:Label>
            <asp:TextBox ID="txNomeEspaco" runat="server" CssClass="campoTexto"></asp:TextBox> <br/>
            <asp:Label ID="lbAreaEspaco" runat="server" Text="Área do espaço" CssClass="label"></asp:Label>
            <asp:TextBox ID="txAreaEspaco" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbValorReserva" runat="server" Text="Valor da reserva" CssClass="label"></asp:Label>
            <asp:TextBox ID="txValorReserva" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <br />
            <asp:Label ID="lbRegulamento" runat="server" Text="Regulamento de uso" CssClass="label"></asp:Label>
            <asp:TextBox ID="txRegulamento" runat="server" Height="138px" TextMode="MultiLine" Width="515px" CssClass="campoTexto"></asp:TextBox><br/><br/>
            <asp:Button ID="btCadastrarEspaco" runat="server" Text="Cadastrar" CssClass="botaoDefault botaoHover" OnClick="BtCadastrarEspacoReserva"/><br/>
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="botaoDefault botaoHover" OnClick="BtVoltarClick"/><br />
        </div>
    </form>
</body>
</html>
