<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperacaoSenha.aspx.cs" Inherits="MeuCondominio1.RecuperacaoSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                    <asp:TextBox ID="txEmail" CssClass="campoTexto" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txEmail" CssClass="alerta" ErrorMessage="Informe um e-mail válido."></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="alerta" ErrorMessage="E-mail inválido." ControlToValidate="txEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <div class="centro">
                        <br />
                        <asp:Button ID="btEnviar" runat="server" Text="Enviar" CssClass="botaoDefault botaoHover" OnClick="btReenviarSenha" />
                        <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="botaoDefault botaoHover" OnClick="btVoltar_Click" />
                        <br />
                        <asp:Label ID="lbResultado" runat="server" Text=""></asp:Label>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="botaoDefault botaoHover"/><br />
        </div>
    </form>
</body>
</html>
