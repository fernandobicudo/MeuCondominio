<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlteracaoDeSenha.aspx.cs" Inherits="MeuCondominio1.AlteracaoDeSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Alteração de Senha</title>
</head>
<body class ="AlteracaoDeSenha">
    <h1>Alteração de Senha</h1>
    <form id="frmAlterarSenha" runat="server" autocomplete="off">
        <div>
            <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txEmail" runat="server" AutoCompleteType="Disabled" autocomplete="off"></asp:TextBox>
            <asp:Button ID="btVerificar" runat="server" Text="Verificar" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lbSenhaAtual" runat="server" Text="Senha atual: "></asp:Label>
                    <asp:TextBox ID="txSenhaAtual" type="password" ValidationGroup="Senha" runat="server" AutoCompleteType="Disabled" autocomplete="off"></asp:TextBox><br/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="alerta" ControlToValidate="txSenhaAtual" ValidationGroup="Senha" ErrorMessage="Digite a senha."></asp:RequiredFieldValidator><br/>
                    <asp:Label ID="lbSenhaNova1" runat="server" Text="Nova senha: "></asp:Label>
                    <asp:TextBox ID="txSenhaNova1" type="password" ValidationGroup="Senha" runat="server"></asp:TextBox><br/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="alerta" ControlToValidate="txSenhaNova1" ValidationGroup="Senha" ErrorMessage="Digite a nova senha."></asp:RequiredFieldValidator><br/>
                    <asp:Label ID="lbSenhaNova2" runat="server" Text="Repita a nova senha: "></asp:Label>
                    <asp:TextBox ID="txSenhaNova2" type="password" ValidationGroup="Senha" runat="server"></asp:TextBox><br/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txSenhaNova2" CssClass="alerta" ValidationGroup="Senha" ErrorMessage="Repita a nova senha."></asp:RequiredFieldValidator><br/>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ValidationGroup="Senha" CssClass="alerta" ControlToValidate="txSenhaNova1" ControlToCompare="txSenhaNova2" Operator="Equal" ErrorMessage="A nova senha deve ser exatamente igual nos dois últimos campos."></asp:CompareValidator><br/>
                    
                    <asp:Button ID="btAlterarSenha" runat="server" ValidationGroup="Senha" Text="Alterar senha" OnClick="Bt_AlterarSenha" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
