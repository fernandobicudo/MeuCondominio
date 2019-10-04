<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SindicoImportarDadosDeCondominio.aspx.cs" Inherits="MeuCondominio1.SindicoImportarDadosDeCondominio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <title>Importação de Dados dos Condôminos</title>
</head>
<body>
    <h1>Importação de Dados dos Condôminos</h1>
    <form id="idImportacaoDadosCondominosSindico" runat="server">
        <div>
            <asp:Label ID="lbArquivoDeImportacao" runat="server" Text="Informe o arquivo"></asp:Label>
            <asp:FileUpload ID="fuArquivoDeImportacao" runat="server" />
            <asp:Button ID="btUpload" runat="server" Text="Upload" CssClass="botaoDefault botaoHover" OnClick="btUpload_Click" /><br />
            <br />
            <!--<asp:Button ID="idPreviewDosDados" runat="server" Text="Preview" CssClass="botaoPequeno botaoHover" OnClick="btPreview_Click" />-->
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lbAlertaStatusDosDadosImportados" runat="server" Text=""></asp:Label><br />
                    <asp:GridView ID="gvDadosDosCondominos" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="nome" HeaderText="Nome" />
                            <asp:BoundField DataField="email" HeaderText="Email" />
                            <asp:BoundField DataField="telefone" HeaderText="Telefone" />
                            <asp:BoundField DataField="endereco" HeaderText="Endereco" />
                            <asp:BoundField DataField="numero" HeaderText="Número" />
                            <asp:BoundField DataField="complemento" HeaderText="Complemento" />
                            <asp:BoundField DataField="bairro" HeaderText="Bairro" />
                            <asp:BoundField DataField="cidade" HeaderText="Cidade" />
                            <asp:BoundField DataField="CEP" HeaderText="CEP" />
                            <asp:BoundField DataField="CPF" HeaderText="CPF" />
                        </Columns>
                    </asp:GridView><br/>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Button ID="idImportar" runat="server" Text="Importar dados" CssClass="botaoDefault botaoHover" OnClick="btImportarDados_Click" />
        </div>
    </form>
</body>
</html>
