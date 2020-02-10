<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MeuCondominio1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Login</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="./css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="./scripts/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="./scripts/bootstrap.min.js"></script>

    <link rel="stylesheet" href="./css/estilos-global.css" />
</head>
<body class="login">
    <h1>Login</h1>
    <form id="login" runat="server">
        <div>
            <div class="form-horizontal container-fluid">
                <div class="row">
                    <div class="form-group">
                        <div class="col-xs-8">
                            <asp:Label ID="lbEmail" runat="server" Text="E-mail"></asp:Label>
                            <asp:TextBox ID="txEmail" runat="server" CssClass="form-control"></asp:TextBox><!--CssClass="form-control"-->
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <div class="col-xs-8">
                            <asp:Label ID="lbSenha" runat="server" Text="Senha"></asp:Label>
                            <asp:TextBox ID="txSenha" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-6">
                        <asp:RequiredFieldValidator ID="validaSeEmailPreenchido" runat="server" ErrorMessage="Informe seu e-mail." ControlToValidate="txEmail" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="validaFormatoEmail" runat="server" ErrorMessage="Informe um e-mail válido." ControlToValidate="txEmail" CssClass="alert alert-danger" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <asp:Label ID="lbAviso" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <div class="centro">
            <asp:Button ID="btEntrar" runat="server" CssClass="btn btn-primary" Text="Entrar" OnClick="Bt_Entrar" /><br />
            <a href="RecuperacaoSenha.aspx" id="lkRecuperarSenha" class="link_p">Relembrar senha</a>
            <asp:Label ID="loginStatus" runat="server" Text=""></asp:Label>
            <asp:Label ID="lbCodUser" runat="server" CssClass="link_p" Text=""></asp:Label><br />
            <asp:Label ID="lbNomeUser" runat="server" CssClass="link_p" Text=""></asp:Label><br />
            <asp:Label ID="lbEmailUser" runat="server" CssClass="link_p" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>
