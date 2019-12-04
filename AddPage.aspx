<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPage.aspx.cs" Inherits="CMSWebsite.AddPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Page Title:

    <asp:TextBox ID="PageTitleInput" runat="server"></asp:TextBox>

    Page Body: 

    <asp:TextBox ID="PageBodyInput" runat="server"></asp:TextBox>

    <asp:Button ID="AddBtn" class="btn" OnClick="Add_Click" runat="server" Text="Add" />


</asp:Content>
