<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteCadastro.aspx.cs" Inherits="MeuCondominio1.ClienteCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Meu Perfil</title>
</head>
<body class="cadastro">
    <h1>Meu Perfil</h1>
    <form id="frmMeuPerfil" runat="server">
        <div>
            <asp:Label ID="lbNomeCliente" runat="server" Text="Nome" CssClass="label"></asp:Label>
            <asp:TextBox ID="txNomeCliente" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbCPF" runat="server" Text="CPF" CssClass="label"></asp:Label>
            <asp:TextBox ID="txCPF" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbEmail" runat="server" Text="Email" CssClass="label"></asp:Label>
            <asp:TextBox ID="txEmail" runat="server" CssClass="campoTexto"></asp:TextBox>
            <asp:Label ID="txEndereco" runat="server" Text="Logradouro" CssClass="label"></asp:Label>
            <asp:TextBox ID="txLogradouro" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbNumeroLogradouro" runat="server" Text="Número" CssClass="label"></asp:Label>
            <asp:TextBox ID="txNumeroLogradouro" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbComplemento" runat="server" Text="Complemento" CssClass="label"></asp:Label>
            <asp:TextBox ID="txComplemento" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbBairro" runat="server" Text="LabelBairro" CssClass="label"></asp:Label>
            <asp:TextBox ID="txBairro" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbCidade" runat="server" Text="Cidade" CssClass="label"></asp:Label>
            <asp:TextBox ID="txCidade" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbEstado" runat="server" Text="Estado" CssClass="label"></asp:Label>
            <asp:TextBox ID="txEstado" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Label ID="lbCEP" runat="server" Text="CEP" CssClass="label"></asp:Label>
            <asp:TextBox ID="txCEP" runat="server" CssClass="campoTexto"></asp:TextBox><br/>
            <asp:Button ID="btAlterarSenha" runat="server" Text="Alterar senha" CssClass="botaoPequeno botaoHover" OnClick="Bt_AlterarSenha" />
            <h2>Minhas unidades</h2>
            <asp:GridView ID="gvUnidadesDoCliente" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="nomeCondominio" HeaderText="Condomínio" />
                    <asp:BoundField DataField="identificacao" HeaderText="Unidade" />
                    <asp:BoundField DataField="MoradorDaUnidade" HeaderText="É morador?" />
                    <asp:BoundField DataField="ProprietarioDaUnidade" HeaderText="É proprietário?" />
                </Columns>
            </asp:GridView><br/><br/>
            <asp:Button ID="btVoltar" runat="server" CssClass="botaoDefault botaoHover" Text="Voltar" OnClick="BtVoltarClick" /><br />
        </div>
    </form>
</body>
</html>
