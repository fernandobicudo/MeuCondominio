<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteNovaReservaEspacoLazer.aspx.cs" Inherits="MeuCondominio1.ClienteNovaReservaEspacoLazer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <link rel="stylesheet" href="./css/jquery-ui.css" />
    <!--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" /> -->
    <script src="./scripts/jquery-3.3.1.js"> </script>
    <script src="./scripts/jquery-ui.js"></script>
    <!--<script src="./scripts/jquery-3.3.1.min.js"></script>
    <script src="./scripts/bootstrap.min.js"></script>
    <script src="./scripts/bootstrap.js"></script> -->
    <script>
        $(function () {
            $(".campoTextoDatePicker_p").datepicker({ dateFormat: 'dd/mm/yy' });
        });
    </script>

    <title>Nova Reserva</title>
</head>
<body class="cadastro">
    <h1>Nova reserva</h1>
    <form id="frmNovaReserva" runat="server">
        <div>
            <asp:Label ID="lbEspacoReserva" runat="server" Text="Espaço a reservar: "></asp:Label>
            <asp:DropDownList ID="ddTipoDeEspaco" runat="server">
                <asp:ListItem>Salão de festas</asp:ListItem>
                <asp:ListItem>Churrasqueira</asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="lbDataReserva" runat="server" Text="Data: "></asp:Label>
            <asp:TextBox ID="txDataReserva" runat="server" CssClass="campoTextoDatePicker_p" AutoCompleteType="Disabled"></asp:TextBox><br />
            <asp:CheckBox ID="chkRegulamento" runat="server" />
            <asp:LinkButton ID="lkbRegulamento" runat="server">Li e concordo com o regulamento.</asp:LinkButton><br />
            <asp:Button ID="btReservar" runat="server" Text="Reservar" CssClass="botaoDefault" OnClick="Bt_Reservar"/><br /><br />
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="botaoDefault botaoHover" OnClick="BtVoltarClick"/><br />
        </div>
        <!--<div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="modal" id="regulamentoModal" tabindex="-1">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h4 class="modal-title">Regulamento</h4>
                                    <button class="close" data-dismiss="modal">&times;</button>
                                </div>
                                <div class="modal-body">
                                        <div class="form-group">
                                            <asp:TextBox ID="idRegulamento" runat="server"></asp:TextBox>
                                        </div>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="btFechar" runat="server" data-dismiss="modal" Text="Fechar" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>-->
    </form>
</body>
</html>
