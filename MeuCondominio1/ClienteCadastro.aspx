<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteCadastro.aspx.cs" Inherits="MeuCondominio1.ClienteCadastro" %>

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
    <title>Meu Perfil</title>
</head>
<body class="cadastro">
    <h1>Meu Perfil</h1>
    <form id="frmMeuPerfil" runat="server">
        <div class="container-fluid">

            <asp:Label ID="lbNomeCliente" runat="server" Text="Nome" ></asp:Label>
            <div class="row">
                <asp:TextBox ID="txNomeCliente" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
            <asp:Label ID="lbCPF" runat="server" Text="CPF" ></asp:Label>
            <div class="row">
                <asp:TextBox ID="txCPF" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
            <asp:Label ID="lbEmail" runat="server" Text="Email" ></asp:Label>
            <div class="row">
                <asp:TextBox ID="txEmail" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
            <asp:Label ID="txEndereco" runat="server" Text="Logradouro" ></asp:Label>
            <div class="row">
            <asp:TextBox ID="txLogradouro" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
                <asp:Label ID="lbNumeroLogradouro" runat="server" Text="Número" ></asp:Label>
            <div class="row">
            <asp:TextBox ID="txNumeroLogradouro" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
                <asp:Label ID="lbComplemento" runat="server" Text="Complemento" ></asp:Label>
            <div class="row">
            <asp:TextBox ID="txComplemento" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
                <asp:Label ID="lbBairro" runat="server" Text="LabelBairro" ></asp:Label>
            <div class="row">
            <asp:TextBox ID="txBairro" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
                <asp:Label ID="lbCidade" runat="server" Text="Cidade" ></asp:Label>
            <div class="row">
            <asp:TextBox ID="txCidade" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
                <asp:Label ID="lbEstado" runat="server" Text="Estado" ></asp:Label>
            <div class="row">
                <asp:TextBox ID="txEstado" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
                <asp:Label ID="lbCEP" runat="server" Text="CEP" ></asp:Label>
            <div class="row">
                <asp:TextBox ID="txCEP" runat="server" CssClass="col-sm-8"></asp:TextBox>
            </div>
                <asp:Button ID="btAlterarSenha" runat="server" Text="Alterar senha" CssClass="botaoPequeno botaoHover" OnClick="Bt_AlterarSenha" />
            <h2>Minhas unidades</h2>
            <asp:GridView ID="gvUnidadesDoCliente" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="nomeCondominio" HeaderText="Condomínio" />
                    <asp:BoundField DataField="identificacao" HeaderText="Unidade" />
                    <asp:BoundField DataField="MoradorDaUnidade" HeaderText="É morador?" />
                    <asp:BoundField DataField="ProprietarioDaUnidade" HeaderText="É proprietário?" />
                </Columns>
            </asp:GridView>
            
            
            <asp:Button ID="btVoltar" runat="server" CssClass="botaoDefault botaoHover" Text="Voltar" OnClick="BtVoltarClick" />
        </div>
    </form>
</body>
</html>
