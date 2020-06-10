<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculadora.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 33px;
        }
        .auto-style2 {
            width: 33px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 274px;
        }
        .auto-style5 {
            height: 23px;
            width: 274px;
        }
    </style>
</head>
<body style="height: 205px">
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="LblAnt" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtNum" runat="server" MaxLength="20" Width="243px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Btn7" runat="server" OnClick="Button1_Click" Text="7" Width="60px" />
                    <asp:Button ID="Btn8" runat="server" OnClick="Btn8_Click" Text="8" Width="60px" />
                    <asp:Button ID="Btn9" runat="server" OnClick="Btn9_Click" Text="9" Width="60px" />
                    <asp:Button ID="BtnDiv" runat="server" OnClick="BtnDiv_Click" Text="Div" Width="60px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Btn4" runat="server" OnClick="Btn4_Click" Text="4" Width="60px" />
                    <asp:Button ID="Btn5" runat="server" OnClick="Btn5_Click" Text="5" Width="60px" />
                    <asp:Button ID="Btn6" runat="server" OnClick="Btn6_Click" Text="6" Width="60px" />
                    <asp:Button ID="BtnMult" runat="server" Text="*" Width="60px" OnClick="BtnMult_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Btn1" runat="server" OnClick="Btn1_Click" Text="1" Width="60px" />
                    <asp:Button ID="Btn2" runat="server" OnClick="Btn2_Click" Text="2" Width="60px" />
                    <asp:Button ID="Btn3" runat="server" OnClick="Btn3_Click" Text="3" Width="60px" />
                    <asp:Button ID="BtnMenus" runat="server" Text="-" Width="60px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style5">
                    <asp:Button ID="BtnPonto" runat="server" Text="." Width="60px" />
                    <asp:Button ID="Btn0" runat="server" OnClick="Btn0_Click" Text="0" Width="60px" />
                    <asp:Button ID="BtnIgual" runat="server" Text="=" Width="60px" />
                    <asp:Button ID="BtnMais" runat="server" Text="+" Width="60px" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="BtnClear" runat="server" Text="C" Width="60px" />
                    <asp:Button ID="BtnPonto1" runat="server" Text="+/-" Width="60px" />
                    <asp:Button ID="BtnPorCent" runat="server" Text="%" Width="60px" />
                    <asp:Button ID="BtnDel" runat="server" Text="DEL" Width="60px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
