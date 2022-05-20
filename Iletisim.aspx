<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="CvEntity.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <table class="table table-bordered" style="margin-left:20px;">
        <tr>
            <th>ID</th>
            <th>Ad Soyad</th>
            <th>Mail</th>
            <th>Konu</th>
            <th>Mesajı Gör</th>
        </tr>
        <asp:Repeater runat="server" ID="RepeaterMesajlar">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id")%> </td>
                    <td><%#Eval("AdSoyad")%> </td>
                    <td><%#Eval("Mail")%> </td>
                    <td><%#Eval("Konu")%> </td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "MesajDetay.aspx?Id="+ Eval("Id") %>' BackColor="#CC6699">Mesajı Gör</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        <tr>
        </tr>
    </table>
</asp:Content>
