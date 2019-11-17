<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEleicao.aspx.cs" Inherits="MeuCondominio1.CadastroEleicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/jquery-ui.css" />
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <script src="./scripts/jquery-3.3.1.js"> </script>
    <script src="./scripts/jquery-ui.js"></script>
    <script>
        $(function () {
            $(".campoTextoDatePicker_p").datepicker({ dateFormat: 'dd/mm/yy' });
        });
    </script>
    <title>Cadastro de Eleição</title>
</head>
<body>
    <h1>Cadastro de Eleição</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbNomeEleicao" runat="server" Text="Título da Eleição"></asp:Label>
            <asp:TextBox ID="txNomeEleicao" runat="server" CssClass="campoTexto"></asp:TextBox><br />
            <asp:Label ID="lbTipoEleicao" runat="server" Text="Tipo de Eleição"></asp:Label>
            <asp:DropDownList ID="ddTipoEleicao" runat="server">
                <asp:ListItem>Plebiscito</asp:ListItem>
                <asp:ListItem>Eleição para Síndico</asp:ListItem>
                <asp:ListItem>Projetos e Serviços Prediais</asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="lbDescricao" runat="server" Text="Descrição" ></asp:Label>
            <asp:TextBox ID="txDescricao" runat="server" CssClass="campoTexto" Length="300px"></asp:TextBox><br />
            <asp:Label ID="lbDataInicio" runat="server" Text="Data de Abertura da votação"></asp:Label>
            <asp:TextBox ID="txDataInicio" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="6" AutoCompleteType="Disabled"></asp:TextBox><br />
            <!--TODO: pensar em campo Hora-->
            <asp:Label ID="lbDataFim" runat="server" Text="Data de Encerramento da Votação"></asp:Label>
            <asp:TextBox ID="txDataFim" runat="server" CssClass="campoTextoDatePicker_p" MaxLength="6" AutoCompleteType="Disabled"></asp:TextBox><br />
            <asp:Panel ID="pnInclusaoOpcaoaSerVotada" runat="server"></asp:Panel><br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="upAdicionarOpcao" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lbOpcoesDeVotacao" runat="server" Text="Opções de votação"></asp:Label>
                    <asp:TextBox ID="txOpcao" runat="server"></asp:TextBox>
                    <asp:Button ID="btAdicionarOpcao" runat="server" OnClick="AdicionarOpcaodeVotacao" Text="Adicionar" CssClass=" botaoPequeno" />
                    <br />
                    <asp:BulletedList ID="blListaOpcoesAdicionadas" runat="server">
                    </asp:BulletedList>
                    <asp:Button ID="btRemoverOpcoes" runat="server" Text="Remover opções" CssClass="botaoPequeno botaoHover" OnClick="RemoverOpcoes_Click"/>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="botaoDefault botaoHover" OnClick="BtVoltarClick"/>
            <asp:Button ID="btCadastrar" runat="server" Text="Cadastrar" CssClass="botaoDefault botaoHover" OnClick="CadastrarEleicao_Click"/><br/>
            <asp:Button ID="btEncerraEleicao" runat="server" Text="Encerrar eleição" CssClass="botaoPequeno" OnClick="Encerrar_Eleicao_Click"/>
        </div>
    </form>
</body>
</html>
