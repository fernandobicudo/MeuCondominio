<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroSorteioVagas.aspx.cs" Inherits="MeuCondominio1.cadastro_sorteio_vagas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Novo sorteio de vagas de garagem</title>
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <link rel="stylesheet" href="./css/jquery-ui.css" />
    <script src="./scripts/jquery-3.3.1.js"> </script>
    <script src="./scripts/jquery-ui.js"></script>
    <script>
        $(function () {
            $(".campoTextoDatePicker_p").datepicker();
        });
    </script>
</head>
<body class="login">
    <h1>Novo sorteio de vagas</h1>
    <form id="login" runat="server">
        <div>
            <asp:Label ID="lbDataSorteio" runat="server" Text="Data do Sorteio" CssClass="p_label"></asp:Label><br />
            <asp:TextBox ID="txDataSorteio" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="8"></asp:TextBox><br />
            <asp:Label ID="lbValidadeSorteio" runat="server" Text="Validade do sorteio" CssClass="p_label"></asp:Label><br />
            <asp:Label ID="lbDataValidadeInicio" runat="server" Text="De" CssClass="p_label"></asp:Label>
            <asp:TextBox ID="txDataValidadeInicio" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="8"></asp:TextBox>
            <asp:Label ID="lbDataValidadeFim" runat="server" Text="até" CssClass="p_label"></asp:Label>
            <asp:TextBox ID="txDataValidadeFim" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="8"></asp:TextBox><br/>
            <asp:Label ID="lbTipoSorteio" runat="server" Text="Tipo de Sorteio" CssClass="p_label"></asp:Label>
            <asp:RadioButton ID="rbFiladeSorteio" runat="server" GroupName="tipoSorteio" Text="Fila" />
            <asp:RadioButton ID="rbSorteioPorUnidade" runat="server" GroupName="tipoSorteio" Text="Vagas por unidade" />
            <asp:Label ID="lbVagasPorUnidade" runat="server" Text="Vagas por unidade" CssClass="p_label"></asp:Label>
            <asp:DropDownList ID="ddVagasPorUnidade" runat="server"></asp:DropDownList>
            <asp:Label ID="lbTotalVagas" runat="server" Text="Total de vagas disponíveis" CssClass="p_label"></asp:Label>
            <asp:TextBox ID="txTotalVagas" runat="server" CssClass="campoTexto_p"></asp:TextBox>
            <asp:Label ID="lbSeHaVagasSequenciais" runat="server" Text="Há vagas sequenciais?" CssClass="p_label"></asp:Label>
            <asp:RadioButton ID="rbSeHaVagasSequenciaisSim" runat="server" Text="Sim" GroupName="SeHaVagasSequenciais" />
            <asp:RadioButton ID="rbSeHaVagasSequenciaisNao" runat="server" Text="Não" GroupName="SeHaVagasSequenciais" />
            <asp:Label ID="lbQtdeMaxPorSequencia" runat="server" Text="Qtd. máx. por sequência" CssClass="p_label" ></asp:Label>
            <asp:DropDownList ID="ddQtdeMaxPorSequencia" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
