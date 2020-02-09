<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="ConsultaListaEleicoes.aspx.cs" Inherits="MeuCondominio1.ConsultaListaEleicoes" %>

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
    <script lang="javascript" src="./scripts/jquery-3.3.1.min.js"> </script>
    <title>Eleições do Condomínio</title>
</head>
<body>
    <h1>Eleições do Condomínio</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnEleicoes" runat="server"></asp:Panel>
            <asp:GridView ID="gvEleicoes" runat="server" OnRowCreated="GridView_RowCreated" OnSelectedIndexChanged="GridView_SelectedIndex_Changed" AutoGenerateColumns="False" CssClass="table-responsive centro table-hover"  >
                <Columns>
                    <asp:BoundField DataField="idEleicao" HeaderText="Código" />
                    <asp:BoundField DataField="nomeEleicao" HeaderText="Título" />
                    <asp:BoundField DataField="statusEleicao" HeaderText="Status"  />
                    <asp:BoundField DataField="dataInicioEleicao" HeaderText="Início" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="dataFimEleicao" HeaderText="Término" DataFormatString="{0:d}" />
                </Columns>
                <HeaderStyle HorizontalAlign="Center" />
            </asp:GridView><br/>
            <asp:Button ID="btNovaEleicao" runat="server" Text="Nova votação" CssClass="btn btn-primary" OnClick="btNovaVotacao_Click"/><br />
            <asp:Button ID="btVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="BtVoltarClick"/><br />
        </div>
        <br />
    </form>
</body>
</html>


<script lang="javascript">
/*

    $("tr").mouseenter(function () {
        $(this).css("background-color", "#01579B");
        $(this).css("color", "white");
        $(this).css("font-weight", "bolder");
    }
    );
    $("tr").mouseleave(function () {
        $(this).css("background-color", "white");
        $(this).css("color", "black");
        $(this).css("font-weight", "normal");

    }
    );
*/
    /*    $("tr").on("mouseenter", function () {
            $(this).css("background-color", "grey");
        }
        );
        $("tr").on("mousleave", function () {
            $(this).css("background-color", "white");
        }
        );*/
</script>
