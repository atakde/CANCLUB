<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Trends.aspx.cs" Inherits="_382Project.trends" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="align-self-start">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  AllowPaging="True" PageSize="5" CssClass="table table-striped" DataKeyNames="id">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            <asp:BoundField DataField="activity" HeaderText="activity" SortExpression="activity" />
            <asp:BoundField DataField="score" HeaderText="score" SortExpression="score" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebProjectConnectionString %>" SelectCommand="SELECT [id], [title], [type], [activity], [score] FROM [Activities] ORDER BY [score] DESC"></asp:SqlDataSource>
        </div>
</asp:Content>
