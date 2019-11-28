<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teste_Modal.aspx.cs" Inherits="MeuCondominio1.Teste_Modal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
</head>
<body runat="server">
    <script src="./scripts/jquery-3.3.1.min.js"> </script>
    <script src="./scripts/bootstrap.min.js"></script>

    <div class="container">
        <div class="row">
            <div class="col-xs-12">
                
                <div class="modal" id="testemodal" tabindex="-1">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-heaer">
                                <button class="close" data-dismiss="modal">&times;</button>
                                <h4 class="modal-title">Teste</h4>
                            </div>
                            <div class="modal-body">
                                <form id="form1" runat="server">
                                    <div class="form-group">
                                        <asp:Button runat="server" ID="Button1" class="btn btn-primary btn-sm pull-right" Text="Teste" data-target="#loginModal" data-toggle="modal" OnClick="btClick"/>
                                        <label for="input1">Input 1</label>
                                        <input class="form-control" placeholder="Input 1" type="text" id="input1" />
                                    </div>
                                </form>
                            </div>
                            <div class="modal-footer">
                                <button class="btn btn-primary" data-dismiss="modal">Fechar</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
