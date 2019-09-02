<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroSorteioVagas.aspx.cs" Inherits="MeuCondominio1.cadastro_sorteio_vagas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Novo sorteio de vagas de garagem</title>
    <link rel="stylesheet" href="./css/jquery-ui.css" />
    <script src="./scripts/jquery-3.3.1.js"> </script>
    <script src="./scripts/jquery-ui.js"></script>
    <script>
        $(function () {
            $(".campoTextoDatePicker_p").datepicker();
        });
    </script>
</head>
<body class="lista">
    <h1>Novo sorteio de vagas</h1>
    <form id="login" runat="server">
        <div>
            <asp:Label ID="lbDataSorteio" runat="server" Text="Data do Sorteio" ></asp:Label><br />
            <asp:TextBox ID="txDataSorteio" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="8"></asp:TextBox><br /><br/>
            <asp:Label ID="lbValidadeSorteio" runat="server" Text="Validade do sorteio" ></asp:Label><br />
            <asp:Label ID="lbDataValidadeInicio" runat="server" Text="De"></asp:Label>
            <asp:TextBox ID="txDataValidadeInicio" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="8"></asp:TextBox>
            <asp:Label ID="lbDataValidadeFim" runat="server" Text="até" ></asp:Label>
            <asp:TextBox ID="txDataValidadeFim" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="8"></asp:TextBox><br/><br/>
            <asp:Label ID="lbTipoSorteio" runat="server" Text="Tipo de Sorteio"></asp:Label><br/>
            <asp:RadioButton ID="rbFiladeSorteio" runat="server" GroupName="tipoSorteio" Text="Fila"  /><br/><br/>
            <asp:RadioButton ID="rbSorteioPorUnidade" runat="server" GroupName="tipoSorteio" Text="Sorteio por unidade" /><br/><br/>
            <asp:Label ID="lbVagasPorUnidade" runat="server" Text="Vagas por unidade" ></asp:Label><br/>
            <asp:DropDownList ID="ddVagasPorUnidade" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
            </asp:DropDownList><br/>
            <!--<asp:Label ID="lbTotalVagas" runat="server" Text="Total de vagas disponíveis" ></asp:Label><br/>
            <asp:TextBox ID="txTotalVagas" runat="server" ></asp:TextBox><br/><br/>-->
            <asp:Label ID="lbSeHaVagasSequenciais" runat="server" Text="Vagas são sequenciais?" ></asp:Label><br/>
            <asp:RadioButton ID="rbSeHaVagasSequenciaisSim" runat="server" Text="Sim" GroupName="SeHaVagasSequenciais" /><br/>
            <asp:RadioButton ID="rbSeHaVagasSequenciaisNao" runat="server" Text="Não" GroupName="SeHaVagasSequenciais" /><br/><br/>
            <!--<asp:Label ID="lbQtdeMaxPorSequencia" runat="server" Text="Qtd. máx. por sequência" ></asp:Label><br/>
            <asp:DropDownList ID="ddQtdeMaxPorSequencia" runat="server"></asp:DropDownList><br/>-->
            <asp:Button ID="btCadastrar" runat="server" Text="Cadastrar" CssClass="botaoDefault" OnClick="CadastrarSorteioDeVagas" />
        </div>
    </form>
</body>
</html>
