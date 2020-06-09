<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculadora._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 100%; height: 129px;">
        <tr>
            <td style="width: 66px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 66px">&nbsp;</td>
            <td>
                <input id="TxtNumero" style="width: 240px" type="text" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 66px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 66px">&nbsp;</td>
            <td>
                <input id="Btn7" style="width: 60px" type="button" value="7" /><input id="Btn8" style="width: 60px" type="button" value="8" /><input id="Btn9" style="width: 60px" type="button" value="9" /><input id="BtnDiv" style="width: 60px" type="button" value="Div" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 66px">&nbsp;</td>
            <td>
                <input id="Btn4" style="width: 60px" type="button" value="4" /><input id="Btn5" style="width: 60px" type="button" value="5" /><input id="Btn6" style="width: 60px;" type="button" value="6" /><input id="BunMult" style="width: 60px" type="button" value="*" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 66px">&nbsp;</td>
            <td>
                <input id="Btn1" style="width: 60px" type="button" value="1" /><input id="Btn2" style="width: 60px" type="button" value="2" /><input id="Btn3" style="width: 60px" type="button" value="3" /><input id="Btnsub" style="width: 60px" type="button" value="-" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 66px">&nbsp;</td>
            <td>
                <input id="BtnPorcento" style="width: 60px" type="button" value="%" /><input id="Btn0" style="width: 60px" type="button" value="0" /><input id="BtnLimpa" style="width: 60px" type="button" value="C" /><input id="BtnMult" style="width: 60px" type="button" value="*" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 66px; height: 24px;"></td>
            <td style="height: 24px">
                <input id="Button17" style="width: 60px" type="button" value="R$" /><input id="BtnVirgula" style="width: 60px" type="button" value="," /><input id="BtnVolata" style="width: 60px" type="button" value="&lt;&lt;" /><input id="BtnIgual" style="width: 60px" type="button" value="=" /></td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td style="width: 66px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />

</asp:Content>
