<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SindicoImportarDadosDeCondominio.aspx.cs" Inherits="MeuCondominio1.SindicoImportarDadosDeCondominio" %>

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
    <title>Importação de Dados dos Condôminos</title>
</head>
<body>
    <h1>Importação de Dados dos Condôminos</h1>
    <form id="idImportacaoDadosCondominosSindico" runat="server">
        <div>

            <br />

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lbArquivoDeImportacao" runat="server" Text="Informe o arquivo"></asp:Label>
                    <asp:FileUpload ID="fuArquivoDeImportacao" runat="server" />
                    <asp:Button ID="btUpload" runat="server" Text="Upload" CssClass="btn btn-primary" OnClick="BtUpload_Click" /><br />
                    <asp:Label ID="lbAlertaStatusDosDadosImportados" runat="server" Text=""></asp:Label><br />
                    <asp:GridView ID="gvDadosDosClientes" runat="server" AutoGenerateColumns="false" CssClass="table-responsive table-responsive centro">
                        <Columns>
                            <asp:BoundField DataField="nome" HeaderText="Nome" />
                            <asp:BoundField DataField="email" HeaderText="Email" />
                            <asp:BoundField DataField="telefone" HeaderText="Telefone" />
                            <asp:BoundField DataField="endereco" HeaderText="Endereco" />
                            <asp:BoundField DataField="numero" HeaderText="Número" />
                            <asp:BoundField DataField="complemento" HeaderText="Complemento" />
                            <asp:BoundField DataField="bairro" HeaderText="Bairro" />
                            <asp:BoundField DataField="cidade" HeaderText="Cidade" />
                            <asp:BoundField DataField="UF" HeaderText="UF" />
                            <asp:BoundField DataField="CEP" HeaderText="CEP" />
                            <asp:BoundField DataField="CPF" HeaderText="CPF" />
                            <asp:BoundField DataField="Tipo de usuário" HeaderText="Tipo" />
                            <asp:BoundField DataField="Unidade" HeaderText="Unidade" />
                            <asp:BoundField DataField="É morador" HeaderText="É morador" />
                            <asp:BoundField DataField="É condômino" HeaderText="É condômino" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <asp:Button ID="btImportar" runat="server" Text="Importar dados" CssClass="btn btn-primary" OnClick="BtImportarDados_Click" />

                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="btUpload" />
                    <asp:PostBackTrigger ControlID="btImportar" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="BtVoltarClick" />
        </div>
    </form>
</body>
</html>
