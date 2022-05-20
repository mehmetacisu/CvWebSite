<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CvEntity.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="table table-bordered" style="margin-left:20px;">
        <tr>
            <th>ID</th>
            <th>Yetenek</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater runat="server" ID="RepeaterYetenekler">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id")%> </td>
                    <td><%#Eval("Yetenek")%> </td>
                    <td><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "YetenekSil.aspx?Id="+ Eval("Id") %>'>Sil</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl='<%# "YetenekGuncelle.aspx?Id="+ Eval("Id") %>'>Güncelle</asp:HyperLink></td>
                    
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        <tr>
        </tr>
    </table>
    <a href="YeniYetenek.aspx" class="btn btn-primary" style="margin-left:20px;">Yeni Yetenek Ekle</a>
</asp:Content>
