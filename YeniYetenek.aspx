<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniYetenek.aspx.cs" Inherits="CvEntity.YeniYetenek" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Yeni Yetenek Ekleme Sayfası</h4>
    <br />
    <asp:Label runat="server" ID="label" Text="Yetenek Açıklama"></asp:Label>
    <asp:TextBox ID="TextBoxYetenek" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Button runat="server" ID="buttonKayet" Text="Kaydet" CssClass="btn btn-info" OnClick="buttonKayet_Click"/>
</asp:Content>
