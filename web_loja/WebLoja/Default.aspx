<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebLoja.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Loja</title>
    <style type="text/css">
        .auto-style1 {
            width: 111px;
        }

        .auto-style2 {
            display: block;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            background-clip: padding-box;
            border-radius: .25rem;
            transition: none;
            border: 1px solid #ced4da;
            background-color: #fff;
        }

        .auto-style3 {
            width: 430px;
        }

        .auto-style5 {
            width: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding-top: 2%"></div>
        <div class="col-sm-8">
            <h2>Loja de Presentes</h2>
        </div>
        <div style="padding-top: 2%"></div>
        <div class="col-sm-8">
            

            <table class="w-100">
                <tr>
                    <td class="auto-style1">Tipo Presente:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DdwTipoPresente" runat="server" CssClass="form-control" Width="400px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Marca:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DdwMarca" runat="server" CssClass="form-control" Width="400px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Finalidade:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DdwFinalidade" runat="server" CssClass="form-control" Width="400px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Fornecedor:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DdwFornecedor" runat="server" CssClass="form-control" Width="400px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Tamanho:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DdwTamanhoPresente" runat="server" CssClass="form-control" Width="400px">
                            <asp:ListItem>P</asp:ListItem>
                            <asp:ListItem>M</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>GG</asp:ListItem>
                            <asp:ListItem>NA</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Presente:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtPresente" runat="server" CssClass="form-control input-lg"  Width="400px" TabIndex="1"></asp:TextBox>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Preço:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtPreco" runat="server"  CssClass="form-control input-lg"  Width="400px" TabIndex="1"></asp:TextBox>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div class="col-sm-8">
            <p></p>
        </div>
        <div class="col-sm-2">
            <div class="form-group">
                <asp:Button ID="BtnSalvar" runat="server" CssClass="btn btn-primary" OnClick="BtnSalvar_Click" Text="Salvar" />
            </div>
        </div>
        <div class="col-sm-8">
            <asp:GridView ID="GVPresentes" CssClass="table table-dark" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="codPresente" HeaderText="Código Presente " >
                    <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="descPresente" HeaderText="Presente" />
                    <asp:BoundField DataField="descMarca" HeaderText="Marca" />
                    <asp:BoundField DataField="corPresente" HeaderText="Cor" />
                    <asp:BoundField DataField="tamanhoPresente" HeaderText="Tamanho" />
                    <asp:BoundField DataField="precoPresente" HeaderText="Preço" >
                    <HeaderStyle ForeColor="#FF9900" />
                    </asp:BoundField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
