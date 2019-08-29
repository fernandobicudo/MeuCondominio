<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MeuCondominio1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Login</title>
     <link rel="stylesheet" href="./css/estilos-global.css" />
</head>
<body class="login">
        <h1>Login</h1>
    <form id="login" runat="server">
        <div>
            <asp:Label ID="lbAviso" runat="server" CssClass="alerta" Text=""></asp:Label><br />
            <label>E-mail</label>
            <asp:TextBox ID="txEmail" runat="server" CssClass="campoTexto"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="validaSeEmailPreenchido" runat="server" ErrorMessage="Informe seu e-mail." ControlToValidate="txEmail" CssClass="alerta campoTexto"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="validaFormatoEmail" runat="server" ErrorMessage="Informe um e-mail válido." ControlToValidate="txEmail" CssClass="alerta campoTexto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <label>Senha</label>
            <asp:TextBox ID="txSenha" type="password" runat="server" CssClass="campoTexto"></asp:TextBox>
        </div>
        <div class="centro">
            <asp:Button ID="btEntrar" runat="server" Text="Entrar" CssClass="botaoDefault" OnClick="fazerLogin" /><br />
            <a href="RecuperacaoSenha.aspx" id="lkRecuperarSenha" class="link_p">Relembrar senha</a>
            <asp:Label ID="loginStatus" runat="server" Text=""></asp:Label>
            <asp:Label ID="lbCodUser" runat="server" CssClass="link_p" Text=""></asp:Label><br />
            <asp:Label ID="lbNomeUser" runat="server" CssClass="link_p" Text=""></asp:Label><br />
            <asp:Label ID="lbEmailUser" runat="server" CssClass="link_p" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>
