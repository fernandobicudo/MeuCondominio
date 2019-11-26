<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroSorteioVagas.aspx.cs" Inherits="MeuCondominio1.CadastroSorteioVagas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Novo sorteio de vagas de garagem</title>
    <link rel="stylesheet" href="./css/jquery-ui.css" />
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <script src="./scripts/jquery-3.3.1.js"> </script>
    <script src="./scripts/jquery-ui.js"></script>
    <script>
        $(function () {
            $(".campoTextoDatePicker_p").datepicker({ dateFormat: 'dd/mm/yy' });
        });
    </script>
</head>
<body class="cadastro">
    <h1>Novo sorteio de vagas</h1>
    <form id="login" runat="server">
        <div>
            <asp:Label ID="lbDataSorteio" runat="server" Text="Data do Sorteio" CssClass="label"></asp:Label>
            <asp:TextBox ID="txDataSorteio" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="6" AutoCompleteType="Disabled"></asp:TextBox><br />
            <br />
            <asp:Label ID="lbValidadeSorteio" runat="server" Text="Data de validade de" CssClass="label"></asp:Label>
            <asp:TextBox ID="txDataValidadeInicio" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="6" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:Label ID="lbDataValidadeFim" runat="server" Text="até" CssClass="label"></asp:Label>
            <asp:TextBox ID="txDataValidadeFim" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="6" AutoCompleteType="Disabled"></asp:TextBox><br />
            <br />
            <asp:Label ID="lbTipoSorteio" runat="server" Text="Tipo de Sorteio" CssClass="label"></asp:Label>
            <asp:RadioButton ID="rbFiladeSorteio" runat="server" GroupName="tipoSorteio" CssClass="radioButton"  />Fila
            <asp:RadioButton ID="rbSorteioPorUnidade" runat="server" GroupName="tipoSorteio" CssClass="radioButton"  />Sorteio por unidade<br /><br />
            <asp:Label ID="lbVagasPorUnidade" runat="server" Text="Vagas por unidade" CssClass="label"></asp:Label>
            <asp:DropDownList ID="ddVagasPorUnidade" runat="server" CssClass="comboBox">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
            </asp:DropDownList><br />
            <!--<asp:Label ID="lbTotalVagas" runat="server" Text="Total de vagas disponíveis" ></asp:Label><br/>
            <asp:TextBox ID="txTotalVagas" runat="server" ></asp:TextBox><br/><br/>-->
            <asp:Label ID="lbSeHaVagasSequenciais" runat="server" Text="Vagas são sequenciais?" CssClass="label"></asp:Label>
            <asp:RadioButton ID="rbSeHaVagasSequenciaisSim" runat="server" CssClass="radioButton" GroupName="SeHaVagasSequenciais" />Sim
            <asp:RadioButton ID="rbSeHaVagasSequenciaisNao" runat="server" CssClass="radioButton" GroupName="SeHaVagasSequenciais" />Não<br />
            <br />
            <!--<asp:Label ID="lbQtdeMaxPorSequencia" runat="server" Text="Qtd. máx. por sequência" ></asp:Label><br/>
            <asp:DropDownList ID="ddQtdeMaxPorSequencia" runat="server"></asp:DropDownList><br/>-->
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="botaoDefault botaoHover" OnClick="BtVoltarClick" />
            <asp:Button ID="btCadastrar" runat="server" Text="Cadastrar" CssClass="botaoDefault" OnClick="CadastrarSorteioDeVagas" /><br />
            <asp:Button ID="btSortearTeste" runat="server" Text="Testar Sorteio" CssClass="botaoPequeno botaoHover" OnClick="SortearVagas" /><br />
            <br />
        </div>
    </form>
</body>
</html>