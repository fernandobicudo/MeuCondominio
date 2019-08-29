<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroSorteioVagas.aspx.cs" Inherits="MeuCondominio1.cadastro_sorteio_vagas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Novo sorteio de vagas de garagem</title>
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <script src="jquery-3.3.1.min.js"> </script>
    <script>
        $(function () {
            $("#datepicker").datepicker();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbDataSorteio" runat="server" Text="Data do Sorteio"></asp:Label>
            <asp:TextBox ID="txDataSorteio" runat="server" ></asp:TextBox>
        </div>
    </form>
</body>
</html>
