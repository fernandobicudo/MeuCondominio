<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteResultadoDaEleicao.aspx.cs" Inherits="MeuCondominio1.CondominoResultadoDaEleicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resultado da Eleição</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="./css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="./scripts/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="./scripts/bootstrap.min.js"></script>
    
    <link rel="stylesheet" href="./css/estilos-global.css" />
</head>
<body>
    <h1>
        Resultado da Eleição:
        <asp:Label ID="lbTituloDaEleicao" runat="server" Text=""></asp:Label>
    </h1>
    <form id="form1" runat="server">
        <div>
            <h2>
                
            </h2>
            <asp:GridView ID="gvResultadoDaEleicao" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="nomeOpcaoVotada" HeaderText="Opção da votação" />
                    <asp:BoundField DataField="QtdVotos" HeaderText="Votos recebidos" />
                </Columns>
            </asp:GridView><br/>
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="BtVoltarClick"/>
        </div>
    </form>
</body>
</html>
