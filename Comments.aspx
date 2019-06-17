<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="_382Project.Comments1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
          <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
              <Columns>
                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                  <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                  <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                  <asp:BoundField DataField="activity" HeaderText="activity" SortExpression="activity" />
              </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebProjectConnectionString %>" SelectCommand="SELECT [id], [title], [type], [activity] FROM [Activities]"></asp:SqlDataSource>
      <div class="d-flex">

            <asp:SqlDataSource ID="CommentList" runat="server" ConnectionString="<%$ ConnectionStrings:WebProjectConnectionString %>" SelectCommand="SELECT [activity_id], [comment_include] FROM [Comments]"></asp:SqlDataSource>

            <div class="p-2">
                <div class="input-group-prepend">
                    <asp:DropDownList ID="SelectActivity" runat="server" CssClass="btn-group" DataSourceID="Select_Activity_For_Comment" DataTextField="title" DataValueField="title"></asp:DropDownList>
                    <span class="input-group-text"><i class="fa fa-envelope"></i></span>
                    <asp:TextBox ID="Comment" runat="server" CssClass="form-control" TextMode="MultiLine" Width="700px" required></asp:TextBox>
                    <div class="form-group">
                        <asp:Button ID="Kaydet" runat="server" CssClass="btn btn-primary btn-block" Text="Gönder" OnClick="Kaydet_Click" />
                    </div>
                    <p>
                </div>
            </div>
            <asp:SqlDataSource ID="Select_Activity_For_Comment" runat="server" ConnectionString="<%$ ConnectionStrings:WebProjectConnectionString %>" SelectCommand="SELECT [title] FROM [Activities]"></asp:SqlDataSource>
            <p></p>

 
        </div>

        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataSourceID="CommentList" AllowPaging="True" PageSize="5">
            <Columns>
                <asp:BoundField DataField="activity_id" HeaderText="Activity ID" SortExpression="activity_id" />
                <asp:BoundField DataField="comment_include" HeaderText="Comment" SortExpression="comment_include" />
            </Columns>
        </asp:GridView>
            </form>
</asp:Content>
