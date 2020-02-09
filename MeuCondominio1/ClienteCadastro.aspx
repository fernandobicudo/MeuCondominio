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
    <form id="frmMeuPerfil" runat="server" class="form-horizontal">
        <div class="container-fluid">
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbNomeCliente" runat="server" Text="Nome"></asp:Label>
                        <asp:TextBox ID="txNomeCliente" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbCPF" runat="server" Text="CPF"></asp:Label>
                        <asp:TextBox ID="txCPF" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="txEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="txEndereco" runat="server" Text="Logradouro"></asp:Label>
                        <asp:TextBox ID="txLogradouro" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbNumeroLogradouro" runat="server" Text="Número"></asp:Label>
                        <asp:TextBox ID="txNumeroLogradouro" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbComplemento" runat="server" Text="Complemento"></asp:Label>
                        <asp:TextBox ID="txComplemento" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbBairro" runat="server" Text="Bairro"></asp:Label>
                        <asp:TextBox ID="txBairro" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbCidade" runat="server" Text="Cidade"></asp:Label>
                        <asp:TextBox ID="txCidade" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbEstado" runat="server" Text="Estado"></asp:Label>
                        <asp:TextBox ID="txEstado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <asp:Label ID="lbCEP" runat="server" Text="CEP"></asp:Label>
                        <asp:TextBox ID="txCEP" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <asp:Button ID="btAlterarSenha" runat="server" Text="Alterar senha" CssClass="btn btn-link" OnClick="Bt_AlterarSenha" />
        </div>
        <h3>Minhas unidades</h3>
        <asp:GridView ID="gvUnidadesDoCliente" runat="server" AutoGenerateColumns="False" CssClass="table-responsive table-condensed centro header" >
            <Columns>
                <asp:BoundField DataField="nomeCondominio" HeaderText="Condomínio" />
                <asp:BoundField DataField="identificacao" HeaderText="Unidade" />
                <asp:BoundField DataField="MoradorDaUnidade" HeaderText="É morador?" />
                <asp:BoundField DataField="ProprietarioDaUnidade" HeaderText="É proprietário?" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btVoltar" runat="server" CssClass="btn btn-primary" Text="Voltar" OnClick="BtVoltarClick" />
    </form>
</body>
</html>
