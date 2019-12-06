<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="CMSWebsite.Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class=".display-1">Manage Pages</h1>
    <div id="page_search_div" class="form-group">
        <asp:Label for="page_search" runat="server">Search:</asp:Label>
        <asp:TextBox ID="page_search" class="form-control" runat="server"></asp:TextBox>
        <asp:Button class="btn" runat="server" Text="submit" />
    </div>

    <a class="btn btn-primary" href="\AddPage.aspx?">Add</a>
    <div class="text-center">
        <div class="row">
            <div class="col-xs-3">PAGE ID</div>
            <div class="col-xs-3">PAGE TITLE</div>
            <div class="col-xs-3">IS PUBLISHED</div>
            <div class="col-xs-3">ACTION</div>
        </div>
        <div id="page_result" runat="server">
            <div class="row">
                <div class="col-xs-3">Something</div>
                <div class="col-xs-3">is</div>
                <div class="col-xs-3">going</div>
                <div class="col-xs-3">wrong</div>
            </div>
        </div>
    </div>

    <%--<asp:Table id="Table_Result" CssClass="table table-bordered table-hover" runat="server">
        <asp:TableHeaderRow>
            <asp:TableCell>
                PAGE ID
            </asp:TableCell>
            <asp:TableCell>
                PAGE TITLE
            </asp:TableCell>
            <asp:TableCell>
                PAGE BODY
            </asp:TableCell>
            <asp:TableCell>
                IS PUBLISHED
            </asp:TableCell>
        </asp:TableHeaderRow>
    </asp:Table>--%>
</asp:Content>
