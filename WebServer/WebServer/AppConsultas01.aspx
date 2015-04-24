<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppConsultas01.aspx.cs" Inherits="WebServer.AppConsultas01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
&nbsp;<asp:TextBox ID="txtnom" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
&nbsp;<asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
        :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Correo:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btningresar" runat="server" OnClick="btningresar_Click" Text="Ingrersar" Width="379px" />
    
    </div>
    </form>
</body>
</html>
