<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPage.aspx.cs" Inherits="CMSWebsite.AddPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class=".display-1">Add Page</h1>
    <label for="MainContent_PageTitle">Page Title: </label>
    <br />

    <asp:TextBox ID="PageTitle" CssClass="form-control" runat="server"></asp:TextBox>
    <br />
    <br />

    <label for="MainContent_PageBody">Page Body: </label>
    <br />

    <asp:TextBox ID="PageBody" CssClass="form-control" runat="server" TextMode="MultiLine" Height="300px"></asp:TextBox>
    <br />

    <asp:Button ID="AddBtn" CssClass="btn btn-primary" OnClick="Add_Click" runat="server" Text="Add" />


</asp:Content>
