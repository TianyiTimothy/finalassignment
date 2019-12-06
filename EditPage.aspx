<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="CMSWebsite.EditPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="pageWrapper" runat="server">
        <h1 class=".display-1">Edit Page</h1>
        <label for="MainContent_PageTitle">Page Title: </label>
        <br />
        <asp:TextBox ID="PageTitle" CssClass="form-control" runat="server"></asp:TextBox>

        <br />
        <br />

        <label for="MainContent_PageBody">Page Body: </label>
        <br />
        <asp:TextBox ID="PageBody" CssClass="form-control" runat="server" TextMode="MultiLine" Height="300px"></asp:TextBox>
        <br />

        <asp:Button ID="EditBtn" class="btn btn-info" OnClick="Edit_Click" runat="server" Text="Edit" />
        <asp:Button ID="RecoverBtn" class="btn btn-success" OnClick="Recover_Click" runat="server" Text="Recover" />
        <asp:Button ID="DeleteBtn" class="btn btn-danger" OnClick="Delete_Click" runat="server" Text="Delete" />
    </div>
</asp:Content>
