<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="CMSWebsite.Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class=".display-1">Manage Pages</h1>
    <div id="page_search_div" class="form-group" style="display:inline;">
        <asp:Label for="MainContent_page_search" runat="server">Search:</asp:Label>
        <asp:TextBox ID="page_search" class="form-control" style="display:inline-block;" runat="server"></asp:TextBox>
        <asp:Button class="btn btn-success" style="display:inline-block;" runat="server" Text="Search" />
    </div>
    <a class="btn btn-primary" href="\AddPage.aspx?">Add</a>
    <br />
    <br />
    <br />
    <div class="text-center">
        <div class="row" style="margin-bottom: 10px;">
            <div class="col-xs-3" style="font-weight:bold;">PAGE ID</div>
            <div class="col-xs-3" style="font-weight:bold;">PAGE TITLE</div>
            <div class="col-xs-3" style="font-weight:bold;">IS PUBLISHED</div>
            <div class="col-xs-3" style="font-weight:bold;">ACTION</div>
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
