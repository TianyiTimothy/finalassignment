<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="CMSWebsite.DetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 id="PageTitle" runat="server"></h1>
    <p id="PageBody" runat="server"></p>
    <div id="PageAction" style="display:inline-block" runat="server"></div>

    <asp:Button ID="RecoverBtn" class="btn btn-success" OnClick="Recover_Click" runat="server" Text="Recover" />
    <asp:Button ID="DeleteBtn" class="btn btn-danger" OnClick="Delete_Click" runat="server" Text="Delete" />
</asp:Content>
