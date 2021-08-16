<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Plataforma.aspx.cs" Inherits="WebProfe.Plataforma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 144px;
        }
        .auto-style35 {
            width: 100%;
            height: 457px;
        }
        .auto-style36 {
            height: 51px;
        }
        .auto-style37 {
            width: 268px;
        }
    </style>
</head>
<body background ="Imagenes/Fondo2.jpg" background-repeat: no-repeat;>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button4" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" OnClick="Button4_Click" Text="Usuario" />
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" OnClick="Button5_Click" Text="Insertar Profesor" Height="32px" Width="269px" />
                </td>
                <td>
                    <asp:Button ID="Button7" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" OnClick="Button7_Click" Text="Eliminar Profesor datos" Height="33px" Width="272px" />
                </td>
                <td>
                    <asp:Button ID="Button47" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Medium" ForeColor="White" OnClick="Button47_Click1" Text="Buscar Profesor" Height="31px" Width="251px" />
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" OnClick="Button6_Click" Text="Mostrar Tablas" />
                </td>
                <td>
                    <asp:Button ID="Button39" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" OnClick="Button8_Click" Text="Modificar Datos" />
                </td>
                <td>
                    <asp:Button ID="Button40" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Medium" ForeColor="White" OnClick="Button40_Click" Text="Salir de Plataforma" Width="211px" />
                </td>
            </tr>
        </table>
        <asp:Panel ID="Panel1" runat="server" Height="602px" Width="1368px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Nombre Usuario:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView4" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="16px" Width="309px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Correo:"></asp:Label>
            <asp:GridView ID="GridView5" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="16px" Width="303px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Celular:"></asp:Label>
            <asp:GridView ID="GridView6" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="16px" Width="303px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />

        <asp:Panel ID="Panel2" runat="server" Height="892px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Inserciones" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView9" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="16px" Width="303px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <asp:Label ID="Label128" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Ultimos numeros de registro: "></asp:Label>
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label129" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="label"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Profesor"></asp:Label>
            <table class="auto-style35">
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Registro Empleado"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Nombre"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Ap_pat"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Ap_Materia"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Genero"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox45" runat="server" Width="166px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox43" runat="server" Width="136px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox32" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox44" runat="server" Width="128px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <br />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Categoria"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Correo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Celular"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero Estado Civil"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox29" runat="server" Width="147px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox31" runat="server" Width="149px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList38" runat="server" Height="16px" Width="139px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button27" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Height="30px" OnClick="Button27_Click" Text="Insertar Profesor" Width="178px" />
                        <br />
                    </td>
                    <td>
                        <asp:Label ID="Label169" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Perfil Profesor"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="F_Profesor"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="F_Grado"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Estado"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Fecha Obtencion "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Evidencia"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox46" runat="server" Width="144px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox47" runat="server" Width="144px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <br />
                        <asp:Button ID="Button29" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Height="29px" OnClick="Button29_Click" Text="Insertar Perfil de Profesor" Width="226px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Grado Especialidad"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label145" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Titulo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Institucion"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Pais"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Extra"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label185" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="NumRegistro"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox48" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox49" runat="server" Width="120px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox35" runat="server" Width="142px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Width="143px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox50" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style36"></td>
                    <td class="auto-style36"></td>
                    <td class="auto-style36">
                        <br />
                        <asp:Button ID="Button9" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Small" ForeColor="White" Height="28px" OnClick="Button9_Click" Text="Insertar Especialidad" Width="213px" />
                    </td>
                    <td class="auto-style36">
                        <br />
                        <asp:Label ID="Label29" runat="server" Font-Bold="True" Font-Names="Aclonica" Font-Size="Medium" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style36">
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label184" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Asignar Profesor con Materia"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label180" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Num Profesor"></asp:Label>
                        <br />
                    </td>
                    <td>
                        <asp:Label ID="Label181" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Regstro Materia"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label182" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero Grupo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label183" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Extra"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox51" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox52" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox53" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox54" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button48" runat="server" BackColor="#336699" ForeColor="White" Height="36px" OnClick="Button48_Click" Text="Insertar " Width="121px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel3" runat="server" Height="657px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="Insertar Materia, Programa y Cuatrimestre"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Materia"></asp:Label>
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Registro Materia"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label33" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Nombre Materia"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label34" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Hoas  A la semana"></asp:Label>
                    </td>
                    <td class="auto-style37">
                        <asp:Label ID="Label35" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Extra"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style37">
                        <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style37">
                        &nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style37">
                        <asp:Button ID="Button30" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Height="32px" OnClick="Button30_Click" Text="Insertar Materia" Width="145px" />
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label43" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Programa Educativo"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style37">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Registro Programa"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label45" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Programa Educativo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label46" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero de Carrera"></asp:Label>
                    </td>
                    <td class="auto-style37">
                        <asp:Label ID="Label186" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Extra"></asp:Label>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style24">
                        <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style24">
                        <asp:TextBox ID="TextBox55" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style24">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style37">
                        <asp:TextBox ID="TextBox56" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style26"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style24"></td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style37">
                        <asp:Button ID="Button31" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Height="32px" OnClick="Button31_Click" Text="Insertar Programa Educativo" Width="255px" />
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label47" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Cuatrimestre"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style37"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label48" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Registro Cuatrimestre"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label49" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Periodo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label50" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Año"></asp:Label>
                    </td>
                    <td class="auto-style37">
                        <asp:Label ID="Label187" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Inicio"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="Label188" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Fin"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="Label189" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Extra"></asp:Label>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox57" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox37" runat="server" Width="147px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" Width="132px"></asp:TextBox>
                    </td>
                    <td class="auto-style37">
                        <asp:TextBox ID="TextBox58" runat="server" Width="209px"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TextBox59" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TextBox60" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style37">
                        <asp:Button ID="Button32" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Height="34px" OnClick="Button32_Click" Text="Insertar Nuevo Cuatrimestre" Width="260px" />
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="Label170" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label51" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Grupo Cuatrimestre"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style37">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label52" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero Programa Educativo Asignado"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label53" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero de Grupo Asignado"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label54" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero de registro Cuatrimestre"></asp:Label>
                    </td>
                    <td class="auto-style37">
                        <asp:Label ID="Label55" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Turno"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:Label ID="Label190" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Modalidad"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:Label ID="Label191" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Extra"></asp:Label>
                    </td>
                    <td class="auto-style10"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox63" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox26" runat="server" Height="20px" Width="142px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox38" runat="server" Width="131px"></asp:TextBox>
                    </td>
                    <td class="auto-style37">
                        <asp:TextBox ID="TextBox8" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TextBox61" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TextBox62" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style37">
                        <br />
                        <asp:Button ID="Button11" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Small" ForeColor="White" Height="33px" OnClick="Button11_Click1" Text="Insertar Grupo Cuatrimestre" Width="265px" />
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style12">
                        <br />
                        <br />
                    </td>
                    <td class="auto-style12">
                        <br />
                        <br />
                    </td>
                    <td class="auto-style12">
                        <br />
                        <asp:Label ID="Label56" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Text="Label"></asp:Label>
                        <br />
                    </td>
                    <td>
                        <br />
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br /><br />
        <br />
        <asp:Panel ID="Panel4" runat="server" Height="542px">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label57" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="Eliminar Datos "></asp:Label>
            &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;<br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style23">
                        <asp:Label ID="Label63" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Eliminar Profesor"></asp:Label>
                    </td>
                    <td class="auto-style2">
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Label ID="Label167" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Nombre Profesor:"></asp:Label>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;<asp:Label ID="Label168" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Numero de registro del profesor:"></asp:Label>
                        <asp:TextBox ID="TextBox42" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label66" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero de registro en especalidad"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox64" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Button ID="Button35" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Medium" ForeColor="White" OnClick="Button35_Click1" Text="Eliminar Profesor" Width="280px" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td>
                        <br />
                        <asp:Label ID="Label192" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Eliminar Materia"></asp:Label>
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Label ID="Label69" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Numero de Registro Materia"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label72" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero de registro Cuatrimestre"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox40" runat="server" Width="141px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Label ID="Label75" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Numero de registro de Programa Educativo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label78" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" ForeColor="White" Text="Numero Registro Profesor"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label81" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Numero Registro Cuatrimestre"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Button ID="Button12" runat="server" BackColor="#0000CC" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Medium" ForeColor="White" OnClick="Button12_Click" Text="Eliminar Materia" Width="257px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <br />
                        <br />
                    </td>
                    <td>
                        <br />
                        <asp:Label ID="Label85" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Text="Label"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel7" runat="server" Height="809px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label130" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="Busquedas Profesores"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView10" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="125px" Width="946px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView11" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="125px" Width="946px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <table class="auto-style15">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label101" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Profesor"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="Label102" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Materias "></asp:Label>
                    </td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="Label103" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Programa educativo profesor"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <br />
                        <asp:Label ID="Label105" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Nombre :"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <br />
                        <asp:Label ID="Label106" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Nombre Profesor:"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <br />
                        <asp:Label ID="Label107" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Materia:"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style6">
                        <br />
                        <asp:Label ID="Label108" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Nombre del programa:"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button19" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Small" ForeColor="White" OnClick="Button11_Click" Text="Buscar Profesor" Width="143px" />
                    </td>
                    <td>
                        <asp:Button ID="Button20" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Small" ForeColor="White" OnClick="Button20_Click" Text="Buscar Materias" Width="141px" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label109" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Large" ForeColor="White" Text="Por favor inserte todos los campos para la busqueda de Programa educativo"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style21">
                        <br />
                        <asp:Label ID="Label113" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Periodo cursando:"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox20" runat="server" Width="137px"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <br />
                        <asp:Label ID="Label114" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Grupo:"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox21" runat="server" Width="139px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">
                        <br />
                        <asp:Label ID="Label115" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="registro:"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox22" runat="server" Width="156px"></asp:TextBox>
                    </td>
                    <td>
                        <br />
                        <asp:Label ID="Label116" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Grado:"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox23" runat="server" Width="139px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">
                        &nbsp;</td>
                    <td class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style16">
                        <asp:Button ID="Button21" runat="server" BackColor="#336699" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="Small" ForeColor="White" OnClick="Button21_Click" Text="Buscar Programa Educativo" Width="256px" />
                    </td>
                    <td class="auto-style19">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td>
                        <asp:Label ID="Label118" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>


        <asp:Panel ID="Panel8" runat="server" Height="217px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /><asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="125px" Width="946px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </asp:Panel>



        <asp:Panel ID="Panel6" runat="server" Height="906px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label98" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="Muestra De Tablas"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label99" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="Profesores"></asp:Label>
            <br />
            <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="946px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="Label100" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="Programas educativos"></asp:Label>
            <br />
            <asp:GridView ID="GridView13" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="125px" Width="946px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <asp:Label ID="Label146" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="Perfil Profesores"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="946px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <asp:Label ID="Label147" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Size="X-Large" ForeColor="White" Text="Grado Especialidad"></asp:Label>
            <br />
            <asp:GridView ID="GridView14" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="946px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
