<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncelle.aspx.cs" Inherits="CvEntity.YetenekGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4>Yetenek Güncelleme Sayfası</h4>
    <br />
    <asp:Label runat="server" ID="label" Text="Yetenek Açıklama"></asp:Label>
    <asp:TextBox ID="TextBoxYetenek" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Button runat="server" ID="buttonKayet" Text="Güncelle" CssClass="btn btn-success" OnClick="buttonKayet_Click" />
</asp:Content>
