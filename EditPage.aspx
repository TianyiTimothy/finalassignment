<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="CMSWebsite.EditPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="pageWrapper" runat="server">
        Page Title: 
        <asp:TextBox ID="PageTitle" runat="server"></asp:TextBox>

        Page Body: 
        <asp:TextBox ID="PageBody" runat="server"></asp:TextBox>

        <asp:Button ID="EditBtn" class="btn" OnClick="Edit_Click" runat="server" Text="Edit" />
        <asp:Button ID="RecoverBtn" class="btn btn-info" OnClick="Recover_Click" runat="server" Text="Recover" />
        <asp:Button ID="DeleteBtn" class="btn btn-danger" OnClick="Delete_Click" runat="server" Text="Delete" />
    </div>
</asp:Content>
