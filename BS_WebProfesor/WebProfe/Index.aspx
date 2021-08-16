<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebProfe.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Profesores</title>
   <style type="text/css">
        .auto-style1 {
            width: 372px;
        }
       .auto-style2 {
           margin-bottom: 0px;
       }
    </style>
</head>
<body background ="Imagenes/Fondo1.jpg" background-repeat: no-repeat;>
     <form id="form1" runat="server" class="auto-style16">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Abduction2000" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Text="Inicio de Sesion "></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
        <table class="auto-style9">
            <tr>
                <td class="auto-style2">&nbs&nbsp;</td>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Usuario:" Font-Bold="True" Font-Italic="True" Font-Names="Abduction2000" Font-Size="X-Large" Font-Underline="True"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtUsuario" runat="server" Width="194px" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Medium" ForeColor="White"></asp:TextBox>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Correo:" Font-Bold="True" Font-Italic="True" Font-Names="Abduction2000" Font-Size="X-Large" Font-Underline="True"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtContraseña" runat="server" Width="193px" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Medium"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <br />
                </td>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Celular:" Font-Bold="True" Font-Italic="True" Font-Names="Abduction2000" Font-Size="X-Large"></asp:Label>
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtRFC" runat="server" Width="192px" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Medium" CssClass="auto-style2"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                </td>
                <td class="auto-style15">
                    <br />
                </td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
         <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Abduction2000" Font-Size="Large" ForeColor="White" Height="38px" Width="155px" />
        <p>
            <asp:TextBox ID="TextBox4" runat="server" Width="992px" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Medium" ForeColor="#000099"></asp:TextBox>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        @Computo
</body>
</html>
