<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncelle.aspx.cs" Inherits="CvEntityProject.YetenekGüncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>YETENEK GÜNCELLEME SAYFASI</h4>
    <br />
    <asp:TextBox ID="TextBox1" CssClass="form-control" placeholder="Yetenek" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="Button1_Click" />
</asp:Content>
