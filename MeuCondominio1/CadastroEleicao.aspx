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
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="lbTipoEleicao" runat="server" Text="Tipo de Eleição"></asp:Label><br />
            <asp:DropDownList ID="ddTipoEleicao" runat="server">
                <asp:ListItem>Eleição para Síndico</asp:ListItem>
                <asp:ListItem>Projetos e Serviços Prediais</asp:ListItem>
            </asp:DropDownList><br />
        </div>
    </form>
</body>
</html>
