<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteConsultaListaEleicoesB.aspx.cs" Inherits="MeuCondominio1.ClienteConsultaListaEleicoesB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/estilos-global.css" />
    <script lang="javascript" src="./scripts/jquery-3.3.1.min.js"> </script>
    <title>Eleições do Condomínio</title>
</head>
<body>
    <h1>Eleições do Condomínio</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnEleicoes" runat="server"></asp:Panel>
            <asp:GridView ID="gvEleicoes" runat="server" OnRowCreated="GridView_RowCreated" OnSelectedIndexChanged="GridView_SelectedIndex_Changed" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="idEleicao" HeaderText="Código" />
                    <asp:BoundField DataField="nomeEleicao" HeaderText="Título" />
                    <asp:BoundField DataField="descricaoEleicao" HeaderText="Descrição" />
                    <asp:BoundField DataField="statusEleicao" HeaderText="Status" />
                    <asp:BoundField DataField="dataInicioEleicao" HeaderText="Início" />
                    <asp:BoundField DataField="dataFimEleicao" HeaderText="Término" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
    </form>
</body>
</html>

<script lang="javascript">


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

    /*    $("tr").on("mouseenter", function () {
            $(this).css("background-color", "grey");
        }
        );
        $("tr").on("mousleave", function () {
            $(this).css("background-color", "white");
        }
        );*/
</script>