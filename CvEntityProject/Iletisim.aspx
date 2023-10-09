<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="CvEntityProject.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered" style="margin-left: 20px; margin-right: 20px">
    <tr>
        <th>ID</th>
        <th>AD SOYAD</th>
        <th>MAIL</th>
        <th>KONU</th>
        <th>MESAJI GÖR</th>
    </tr>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <tr>
                <td><%# Eval("ID")  %></td>
                <td><%# Eval("fullName")  %></td>
                <td><%# Eval("mail")  %></td>
                <td><%# Eval("topic")  %></td>
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"MesajDetay.aspx?ID=" + Eval("ID") %>' BackColor="#CC6699" CssClass="btn btn-warning">Mesajı Gör</asp:HyperLink>

                </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>

</table>
</asp:Content>
