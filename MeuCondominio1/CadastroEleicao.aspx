<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEleicao.aspx.cs" Inherits="MeuCondominio1.CadastroEleicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="./css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="./scripts/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="./scripts/bootstrap.min.js"></script>

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
<body class="cadastro">
    <h1>Cadastro de Eleição</h1>
    <form id="frCadastroEleicao" runat="server" class="form-horizontal">
        <div>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-xs-8">
                        <div class="form-group">
                            <asp:Label ID="lbNomeEleicao" runat="server" Text="Título da Eleição"></asp:Label>
                            <asp:TextBox ID="txNomeEleicao" runat="server" CssClass="form-control"></asp:TextBox><br />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-4">
                        <div class="form-group">
                            <asp:Label ID="lbTipoEleicao" runat="server" Text="Tipo de Eleição"></asp:Label>
                            <asp:DropDownList ID="ddTipoEleicao" runat="server" CssClass="dropdown">
                                <asp:ListItem>Plebiscito</asp:ListItem>
                                <asp:ListItem>Eleição para Síndico</asp:ListItem>
                                <asp:ListItem>Projetos e Serviços Prediais</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <br />
                <br />
                <div class="row">
                    <div class="col-xs-12">
                        <div class="form-group">
                            <asp:Label ID="lbDescricao" runat="server" Text="Descrição"></asp:Label>
                            <asp:TextBox ID="txDescricao" runat="server" CssClass="form-control input-lg" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-6">
                        <div class="form-group">
                            <asp:Label ID="lbDataInicio" runat="server" Text="Data de Abertura"></asp:Label>
                            <asp:TextBox ID="txDataInicio" runat="server" CssClass="campoTextoDatePicker_p form-control" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <br />
                <!--TODO: pensar em campo Hora-->
                <div class="row">
                    <div class="col-xs-6">
                        <div class="form-group">
                            <asp:Label ID="lbDataFim" runat="server" Text="Data de Encerramento"></asp:Label>
                            <asp:TextBox ID="txDataFim" runat="server" CssClass="campoTextoDatePicker_p  form-control" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <asp:Panel ID="pnInclusaoOpcaoaSerVotada" runat="server"></asp:Panel>
                <br />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="upAdicionarOpcao" runat="server">
                    <ContentTemplate>
                        <div class="row">
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <asp:Label ID="lbOpcoesDeVotacao" runat="server" Text="Opções de votação"></asp:Label>
                                    <asp:TextBox ID="txOpcao" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:Button ID="btAdicionarOpcao" runat="server" OnClick="AdicionarOpcaodeVotacao" Text="Adicionar" CssClass="btn btn-link" />
                                </div>
                            </div>
                        </div>
                        <asp:BulletedList ID="blListaOpcoesAdicionadas" runat="server">
                        </asp:BulletedList>
                        <asp:Button ID="btRemoverOpcoes" runat="server" Text="Remover opções" CssClass="btn btn-link" OnClick="RemoverOpcoes_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="BtVoltarClick" />
                <asp:Button ID="btCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-primary" OnClick="CadastrarEleicao_Click" /><br />
                <asp:Button ID="btEncerraEleicao" runat="server" Text="Encerrar eleição" CssClass="botaoPequeno" OnClick="Encerrar_Eleicao_Click" />
            </div>
        </div>
    </form>
</body>
</html>
