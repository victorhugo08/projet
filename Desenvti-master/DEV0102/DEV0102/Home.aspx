<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DEV0102.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color: gray">
    <form id="form1" runat="server">
        <div>
            <div style="background-color:gray">
                
                <asp:Menu ID="MenuPrincipal" runat="server" Orientation="Horizontal" BackColor="Gray">
                    <items>
                        <asp:MenuItem Text="Produtos">
                        <asp:MenuItem Text="Cadastros"></asp:MenuItem>
                        <asp:MenuItem Text="Relatórios"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="Cadastros de Usuarios" NavigateUrl="~/cadUsuario.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Sair" NavigateUrl="~/Login.aspx?Sair"></asp:MenuItem>
         
                           
                        </items>

                   </asp:Menu>
                     
                </div>


        </div>
    </form>
</body>
</html>
