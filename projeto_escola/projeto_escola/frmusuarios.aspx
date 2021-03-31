<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmusuarios.aspx.cs" Inherits="projeto_escola.frmusuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
            <br />
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
        &nbsp;</div>
    </form>
</body>
</html>
