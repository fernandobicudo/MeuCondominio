<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SindicoCadastroEspacoLazer.aspx.cs" Inherits="MeuCondominio1.SindicoCadastroEspacoLazer" %>

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
    <title>Cadastro de espaços de lazer</title>
</head>
<body class="cadastro">
    <h1>Cadastro de Espaço de Lazer</h1>
    <form id="frmCadastroEspacoLazer" runat="server">
        <div>
            <div class="form-horizontal container-fluid">
                <div class="row">
                    <div class="form-group">
                        <div class="col-xs-10">
                            <asp:Label ID="lbNomeEspaco" runat="server" Text="Nome do espaço" CssClass="label"></asp:Label>
                            <asp:TextBox ID="txNomeEspaco" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <div class="col-xs-10">
                            <asp:Label ID="lbAreaEspaco" runat="server" Text="Área do espaço" CssClass="label"></asp:Label>
                            <asp:TextBox ID="txAreaEspaco" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <div class="col-xs-10">
                            <asp:Label ID="lbValorReserva" runat="server" Text="Valor da reserva" CssClass="label"></asp:Label>
                            <asp:TextBox ID="txValorReserva" runat="server" CssClass="form-control"></asp:TextBox><br />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <div class="col-xs-12">
                            <asp:Label ID="lbRegulamento" runat="server" Text="Regulamento de uso" CssClass="label"></asp:Label>
                            <asp:TextBox ID="txRegulamento" runat="server" TextMode="MultiLine" CssClass="form-control input-lg"></asp:TextBox><br />
                        </div>
                    </div>
                </div>
                <footer class="container-fluid">
                    <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary btn-left" OnClick="BtVoltarClick" />
                    <asp:Button ID="btCadastrarEspaco" runat="server" Text="Cadastrar" CssClass="btn btn-primary btn-right" OnClick="BtCadastrarEspacoReserva" />
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
