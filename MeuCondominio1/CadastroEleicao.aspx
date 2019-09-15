<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEleicao.aspx.cs" Inherits="MeuCondominio1.CadastroEleicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/jquery-ui.css" />
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <script src="./scripts/jquery-3.3.1.js"> </script>
    <script src="./scripts/jquery-ui.js"></script>
    <title>Cadastro de Eleição</title>
</head>
<body>
    <h1>Cadastro de Eleição</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbNomeEleicao" runat="server" Text="Título da Eleição"></asp:Label>
            <asp:TextBox ID="txNomeEleicao" runat="server" MaxLength="30" Length="30"></asp:TextBox><br />
            <asp:Label ID="lbTipoEleicao" runat="server" Text="Tipo de Eleição"></asp:Label>
            <asp:DropDownList ID="ddTipoEleicao" runat="server">
                <asp:ListItem>Plebiscito</asp:ListItem>
                <asp:ListItem>Eleição para Síndico</asp:ListItem>
                <asp:ListItem>Projetos e Serviços Prediais</asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="lbDescricao" runat="server" Text="Descrição"></asp:Label>
            <asp:TextBox ID="txDescricao" runat="server"></asp:TextBox><br />
            <asp:Label ID="lbDataInicio" runat="server" Text="Data de Abertura da votação"></asp:Label>
            <asp:TextBox ID="txDataInicio" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="6" AutoCompleteType="Disabled"></asp:TextBox><br />
            <!--TODO: pensar em campo Hora-->
            <asp:Label ID="lbDataFim" runat="server" Text="Data de Encerramento da Votação"></asp:Label>
            <asp:TextBox ID="txDataFim" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="6" AutoCompleteType="Disabled"></asp:TextBox><br />
            <asp:Panel ID="pnInclusaoOpcaoaSerVotada" runat="server"></asp:Panel>
            <asp:ImageButton ID="ibAdicionarOpcaoDeVotacao" runat="server" ImageUrl="~/Images/add-circle-green-512.png" Height="20px" OnClick="AdicionarOpcaoDeVotacao" />
            <asp:Label ID="lbAdicionarOpcaoDeVotacao" runat="server" Text="Adicionar opção a ser votada"></asp:Label><br />
            <asp:GridView ID="gvOpcoesDeVotacaoAdicionadas" runat="server"></asp:GridView>
            <br />
            <asp:Button ID="btCadastrarEleicao" runat="server" CssClass="botaoDefault" Text="Cadastrar eleição" OnClick="CadastrarEleicao" /><br />
        </div>
    </form>
</body>
</html>
