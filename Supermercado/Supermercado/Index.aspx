<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Supermercado.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container bg-light">
            <div class="row">
                <div class="col  text-center mt-5">
                   
                    <h1>Menú principal</h1>
                       
                        <asp:Label ID="lblForm1" runat="server" Text="Ir a la carga de información por medio de xml formulario1"></asp:Label>
                        <div class="my-2">               
                        <asp:Button ID="btnForm1" runat="server" Text="Ir a la infomación" CssClass="btn btn-info" OnClick="btnForm1_Click" />
                        </div>
                          
                        <asp:Label ID="lblForm2" runat="server" Text="Ir a la carga de información por medio de base de datos formulario2"></asp:Label>
                       <div class="my-2">
                        <asp:Button ID="btnForm2" runat="server" Text="Ir a la información " CssClass="btn btn-success" OnClick="btnForm2_Click" />
                       </div>
                    
                        <asp:Label ID="lblForm3" runat="server" Text="Ir a la carga de información formulario3"></asp:Label>
                        <div class="my-2">
                        <asp:Button ID="btnForm3" runat="server" Text="Ir a la información" CssClass="btn btn-warning" OnClick="btnForm3_Click" />
                        </div> 
                        
                        <asp:Label ID="lblForm4" runat="server" Text="Ir a la carga de archivo JSON"></asp:Label>
                        <div class="my-2">
                        <asp:Button ID="btnForm4" runat="server" Text="Ir a la información" CssClass="btn btn-danger" OnClick="btnForm4_Click" />
                        </div> 
                    
                </div>   
  
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
