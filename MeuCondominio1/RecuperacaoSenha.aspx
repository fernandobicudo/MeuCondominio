<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperacaoSenha.aspx.cs" Inherits="MeuCondominio1.RecuperacaoSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="./css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="./scripts/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="./scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="./css/estilos-global.css" />
</head>
<body class="recuperacao">
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
            <h1>Reenviar senha</h1>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    Aguarde. Processando...
                </ProgressTemplate>
            </asp:UpdateProgress>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <label>E-mail</label>
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-8">
                                <asp:TextBox ID="txEmail" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txEmail" CssClass="alerta" ErrorMessage="Informe um e-mail válido."></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="alerta" ErrorMessage="E-mail inválido." ControlToValidate="txEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <div class="centro">
                        <asp:Button ID="btEnviar" runat="server" CssClass="btn btn-primary" Text="Enviar" OnClick="btReenviarSenha" />
                        <asp:Button ID="btVoltar" runat="server" CssClass="btn btn-primary" Text="Voltar" OnClick="btVoltar_Click" />
                        <asp:Label ID="lbResultado" runat="server" Text=""></asp:Label>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
